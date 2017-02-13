using System;
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
namespace laserScada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        plc m_plc;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
 
            m_plc = new plc();


            lbConectedStatus.Content = m_plc.connect() ? "Ok" : "Fail";
          

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

           
            //connect
            tbCounter.Text = m_plc.tags.get_dint().ToString();
            //karetka
            kar_tb_position.Text = m_plc.tags.get_ust_karetka_poziciya().ToString(); //go to
            kar_tb_current_pos.Text = m_plc.tags.get_kar_tek_poz().ToString();
            kar_tb_step.Text = m_plc.tags.get_ust_karetka_rasst().ToString();
            kar_tb_left_speed.Text = m_plc.tags.get_ust_karetka_skor_vlevo().ToString();
            kar_tb_right_speed.Text = m_plc.tags.get_ust_karetka_skor_vpravo().ToString();
            kar_cb_lk.IsChecked = m_plc.tags.get_karetka_sleva();
            kar_cb_pk.IsChecked = m_plc.tags.get_karetka_sprava();
            // kar_cb_error.IsChecked ??? 

            //stol
            stol_tb_porsh_otn0.Text = m_plc.tags.get_ust_stol_poz_porsh_ot_nulya().ToString();
            stol_tb_plita_width.Text = m_plc.tags.get_ust_stol_tolshh_plity().ToString();
            stol_tb_position.Text = m_plc.tags.get_ust_stol_poziciya().ToString();
            stol_tb_step_value.Text = m_plc.tags.get_ust_stol_otn_rasst().ToString();
            stol_tb_speed.Text = m_plc.tags.get_ust_stol_skor_vverh().ToString();
            stol_tb_line.Text = m_plc.tags.get_linejka().ToString();



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
    }
}
