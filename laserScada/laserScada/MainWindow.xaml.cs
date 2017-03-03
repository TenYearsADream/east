﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SpIceControllerLib;
using log4netSample.Logging;
namespace laserScada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        bool laerFinish = false;
        bool lastLaerFinish = false;

        bool pauseFinish = false;
        bool lastPauseFinish = false;

        bool pr_main_connect
        {
           
            set
            {
                main_led_connect.IsActive = value;
                if (value == true)
                    lbConectedStatus.Content = "Соединение установлено";
                else
                    lbConectedStatus.Content = "Ошибка соединения";
            }
        }

        plc m_plc;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
          //  Logger.InitLogger();
          //  Logger.Log.Info("____");
            Log.Write(LogLevel.Debug, "Start program");
            
            m_plc = new plc();

            pr_main_connect = m_plc.connect();

            
          

            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;

        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SpIceController.deinitialize();
          //  throw new NotImplementedException();
        }

        ~MainWindow()
            {
            SpIceController.deinitialize();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            timer.Tick += new EventHandler(updateSignals);

            timer.Start();
        }

        private void updateSignals(object sender, EventArgs e)
        {
           // Log.Write(LogLevel.Debug, "tst");

            //connect
            tbCounter.Text = m_plc.tags.get_dint().ToString();
            //karetka
            kar_tb_position.Text = m_plc.tags.get_ust_karetka_poziciya().ToString(); //go to
            kar_tb_current_pos.Text = m_plc.tags.get_kar_tek_poz().ToString();
            kar_tb_step.Text = m_plc.tags.get_ust_karetka_rasst().ToString();
            kar_tb_left_speed.Text = m_plc.tags.get_ust_karetka_skor_vlevo().ToString();
            kar_tb_right_speed.Text = m_plc.tags.get_ust_karetka_skor_vpravo().ToString();
            //kar_cb_lk.IsChecked = m_plc.tags.get_karetka_sleva();
            //kar_cb_pk.IsChecked = m_plc.tags.get_karetka_sprava();
            kar_led_lk.IsActive = m_plc.tags.get_karetka_sleva();
            kar_led_pk.IsActive = m_plc.tags.get_karetka_sleva();

            // kar_cb_error.IsChecked ??? 

            //stol
            stol_tb_porsh_otn0.Text = m_plc.tags.get_ust_stol_poz_porsh_ot_nulya().ToString();
            stol_tb_plita_width.Text = m_plc.tags.get_ust_stol_tolshh_plity().ToString();
            stol_tb_position.Text = m_plc.tags.get_ust_stol_poziciya().ToString();
            stol_tb_step_value.Text = m_plc.tags.get_ust_stol_otn_rasst().ToString();
            stol_tb_speed.Text = m_plc.tags.get_ust_stol_skor_vverh().ToString();
            stol_tb_line.Text = m_plc.tags.get_linejka().ToString();

            //dat
            dat_po1.Data = m_plc.tags.get_ga_po1().ToString();
            dat_po2.Data = m_plc.tags.get_ga_po2().ToString();
            dat_po3.Data = m_plc.tags.get_ga_po3().ToString();
            dat_ph2.Data = m_plc.tags.get_ga_ph2().ToString();
            dat_T1.Data = m_plc.tags.get_ga_t1().ToString();
            dat_T2.Data = m_plc.tags.get_ga_t2().ToString();
            dat_T3.Data = m_plc.tags.get_ga_t3().ToString();
            dat_T4.Data = m_plc.tags.get_ga_t4().ToString();
            dat_davl9.Data = m_plc.tags.get_davl9().ToString();
            dat_davl10.Data = m_plc.tags.get_davl10().ToString();
            dat_davl11.Data = m_plc.tags.get_davl11().ToString();

            dat_sk_pot.IsActive = m_plc.tags.get_prot_skanator();
            //dat_sk_tmp.IsActive = m_plc.tags.get_te
            dat_kl_pot.IsActive = m_plc.tags.get_prot_gol_laz_i_kalimator();
            //dat_kl_tmp.IsActive
            dat_ls_pot.IsActive = m_plc.tags.get_prot_lazer();
            //dat_ls_temp.IsActive

            //autoFire
            laerFinish = (lastLaerFinish == true && !m_plc.tags.get_sloj_rab());               
            lastLaerFinish = m_plc.tags.get_sloj_rab();

            pauseFinish = (lastPauseFinish == true && !m_plc.tags.get_kom_pauza());
            lastPauseFinish = m_plc.tags.get_kom_pauza();

            bool s1 = m_plc.tags.get_ust_kol_slojov() >0 && laerFinish && !m_plc.tags.get_kom_pauza() && !m_plc.tags.get_kom_prer();
            bool s2 = m_plc.tags.get_sloi_nepr_rab() && pauseFinish && m_plc.tags.get_kom_rab_do_pauzy() &&  !m_plc.tags.get_kom_prer();

            if (s1 || s2)
            {
                Log.Write(LogLevel.Info, "start laer ");
                SpIceController.StartLayer_(true);
            }

            //main
            m_main_layerCount_finish.Text = m_plc.tags.get_schjot_slojov().ToString();
            m_main_layerCount.Text = m_plc.tags.get_ust_kol_slojov().ToString();

            //shnek
            snek_s1_tb.Data = m_plc.tags.get_ust_vrem_rab_sh1().ToString();
            snek_s2_tb.Data = m_plc.tags.get_ust_vrem_rab_sh2().ToString();
            snek_s3_tb.Data = m_plc.tags.get_ust_vrem_rab_sh3().ToString();
            snek_s3_tb_nagr.Data = m_plc.tags.get_tok_sh3().ToString();
            snek_s3_lo.IsActive = m_plc.tags.get_nizhn_ur_poroshka();
            snek_s3_up.IsActive = m_plc.tags.get_verhn_ur_poroshka();
            //sloi
            layer_widh.Data = m_plc.tags.get_ust_tolshh_sloya().ToString();
            layer_time_rot_m3.Data = m_plc.tags.get_ust_vrem_vrashh_na_meste().ToString();
            layer_stop_m3.Data = m_plc.tags.get_ust_kar_poz_otkl_sh3().ToString();
            layer_doz_num.Data = m_plc.tags.get_ust_kol_slojov_dlya_dozatora().ToString();
            layer_doz_rem.Data = m_plc.tags.get_ost_slojov_dlya_dozatora().ToString();
            layer_pusk_num.Data = m_plc.tags.get_ust_kol_slojov().ToString();
            layer_pusk_rem.Data = m_plc.tags.get_ost_slojov().ToString();
            layer_pusk_gotov.Data = m_plc.tags.get_schjot_slojov().ToString();
        }

        private void tbDeviceIP_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void kar_tb_position_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция перехода", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_karetka_poziciya(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_tb_step_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Шаг", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_karetka_rasst(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_tb_left_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость влево", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_karetka_skor_vlevo(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_tb_right_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость вправо", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_karetka_skor_vpravo(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_bt_stop_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_karetka_stop(true);
        }

        private void kar_bt_start_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_kar_abs(true);
        }

        private void kar_bt_vlevo_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_kar_otn_vlevo(true);
        }

        private void kar_bt_vpravo_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_kar_otn_vpravo(true);
        }

        private void kar_bt_find_orign_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_kar_poisk_nulya(true);
        }
        //stol
        private void stol_tb_plita_width_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("толщина плиты", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_stol_tolshh_plity(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_position_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_stol_poziciya(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_step_value_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Шаг", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_stol_otn_rasst(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_stol_skor_vverh(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_line_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Линейка", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_linejka(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_bt_find_zero_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_poisk_nulya(true);
        }

        private void stol_bt_set_zero_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_ust_nulya(true);
        }

        private void stol_bt_go_to_position_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_abs(true);
        }

        private void stol_bt_step_up_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_otn_pusk_vverh(true);
        }

        private void stol_bt_step_down_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_otn_pusk_vniz(true);
        }

        private void stol_bt_stop_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_stop(true);
        }

        private void stol_bt_cler_Error_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_sbros(true);
        }

        private void stol_bt_line_clearing_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_obnulit_linejku(true);
        }

        private void stol_bt_line_control_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_pereschjot(true);
        }

        private void spIceCtl_Click(object sender, RoutedEventArgs e)
        {
            SpIceControllerLib.SpIceController.initForm();
        }

        private void main_bt_startLayer_Click(object sender, RoutedEventArgs e)
        {
            Log.Write(LogLevel.Info, "start layer ");
            SpIceController.StartLayer_(true);
        }

        private void main_bt_light(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_svet(true);
        }

        private void main_laser_power(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_got_lazer(true);
        }

        private void m_main_layerCount_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Количество слоев", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_kol_slojov(short.Parse(dialog.ResponseText));
            }
        }

        private void main_bt_start_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sloj(true);
        }

        private void main_bt_process_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_proc_obshh(true);

        }

        private void main_bt_pause_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_pauza(true);
        }

        private void main_bt_interupt_Click(object sender, RoutedEventArgs e)
        {
            //  m_plc.tags.set_kom_p
            Log.Write(LogLevel.Info, "Unimplemented!!!!");
        }

        private void snek_s1_bt_start_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sh1_rele(true);
        }

        private void snek_s1_tb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_vrem_rab_sh1(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s2_tb_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_vrem_rab_sh2(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s3_tb_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_vrem_rab_sh3(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s3_tb_nagr_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void snek_s3_tb_nagr_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Нагрузка", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_tok_sh3(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s2_bt_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sh2_rele(true);
        }

        private void snek_s3_bt_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sh3_vperjod(true);
        }

        private void main_power_scanator_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_pit_skan(true);
        }

        private void layer_time_rot_m3_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void layer_avtomat_d_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_dozator_avtomat(true);
        }

        private void layer_avtomat_pusk_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sloj(true);
        }

        private void layer_time_rot_m3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время вращения М3 на месте", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_vrem_vrashh_na_meste(float.Parse(dialog.ResponseText));
            }
        }

        private void layer_stop_m3_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция отключения М3", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_kar_poz_otkl_sh3(float.Parse(dialog.ResponseText));
            }
        }

        private void layer_doz_num_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Дозатор -количество слоёв", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_kol_slojov_dlya_dozatora(short.Parse(dialog.ResponseText));
            }
        }

        private void layer_pusk_num_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Количество слоёв", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_kol_slojov(short.Parse(dialog.ResponseText));
            }
        }

        private void layer_avtomat_reset_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_sloj_sbros_schjotchika(true);
        }

        private void layer_widh_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Толщина слоя", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                m_plc.tags.set_ust_tolshh_sloya(short.Parse(dialog.ResponseText));
            }
        }
    }
}
