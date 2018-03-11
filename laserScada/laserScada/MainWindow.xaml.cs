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
using log4netSample.Logging;
using System.Reflection;
using System.Diagnostics;

namespace laserScada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        public delegate void checkState();
        List<checkState> m_checks = new List<checkState>();

    

        bool laerFinish = false;
        bool lastLaerFinish = false;

        bool pauseFinish = false;
        bool lastPauseFinish = false;
        bool m_pause = false;
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


            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            this.Title = "Лазерный принтер (v" + version + ")";
            //System.Windows.Controls.Button newBtn = new Button();
            //newBtn.Content = "wwwww";
            // newBtn.Name = "Button" + "www";
            System.Windows.Controls.WrapPanel panel = new WrapPanel();
            panel.Orientation = Orientation.Horizontal;
            debugPanel.Content = panel;
            m_plc.tags.init_sSetters();
            m_plc.tags.init_sGetters();


            foreach (KeyValuePair<string, Tags.gTags[]> dicItem in m_plc.tags.groupingDict)
            {
                System.Windows.Controls.GroupBox grBox = new GroupBox();
                System.Windows.Controls.WrapPanel panelH2 = new WrapPanel();
                panelH2.Orientation = Orientation.Vertical;
                grBox.Content = panelH2;
                panel.Children.Add(grBox);
                grBox.Header = dicItem.Key;

                System.Windows.Controls.WrapPanel localgroup= new WrapPanel();
                localgroup.Orientation = Orientation.Horizontal;
                panelH2.Children.Add(localgroup);

                foreach (Tags.gTags tag in dicItem.Value)
                {
                    if (tag == Tags.gTags.separator)
                    {
                        localgroup = new WrapPanel();
                        localgroup.Orientation = Orientation.Horizontal;
                        panelH2.Children.Add(localgroup);
                    }
                    else
                    {
                        localgroup.Children.Add(getControll(tag));
                    }
                    //   panelH2.Children.Add(getControll(tag));
                }
            }



        }


        UIElement getControll(Tags.gTags tag)
        {
            Tags.activeType type = m_plc.tags.getActiveType(tag);

            if (type == Tags.activeType.command) {
                System.Windows.Controls.Button newBtn = new Button();
                newBtn.Content = m_plc.tags.getDebugName(tag);
                newBtn.MinWidth = 100;
                newBtn.Click += (s, e) => { m_plc.tags.setSValue(tag, "true"); };

                return newBtn;
            }

            if (type == Tags.activeType.led)
            {
                LedControl.Led newLed = new LedControl.Led();
                newLed.ColorOn = Colors.Green;
                newLed.ColorOff = Colors.Gray;
                newLed.MinWidth = 100;
                newLed.Text = m_plc.tags.getDebugName(tag); 
                m_checks.Add(() => {
                    bool val;
                    string text = m_plc.tags.getSValue(tag);
                    if (bool.TryParse(text, out val))
                        newLed.IsActive = bool.Parse(text);
                }
                );

                return newLed;
            }

            if (type == Tags.activeType.dataField)
            {
                dataField newFld = new dataField();
                newFld.Text = m_plc.tags.getDebugName(tag);
                newFld.Data = "0";
                //newFld.tb_data.Width = 100;
                //newFld.lb_text.Width = 150;
                newFld.MouseDoubleClick += (s, e) => {
                    var dialog = new inputDialog(m_plc.tags.getDebugName(tag), ((dataField)s).Data);
                    if (dialog.ShowDialog() == true)
                        m_plc.tags.setSValue(tag, dialog.ResponseText);
                };
                m_checks.Add(() => { newFld.Data = m_plc.tags.getSValue(tag); });
                return newFld;
            }

            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.Content = "-- fail --";
            return newBtn1;

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


        private void manualConnect(object sender, EventArgs e)
        {
            m_plc.disconnect();
            pr_main_connect = m_plc.connect();
        }

        private void updateSignals(object sender, EventArgs e)
        {
            // Log.Write(LogLevel.Debug, "tst");

            foreach (checkState ch in m_checks)
            {
                ch();
            }

            if (m_pause)
            {
                main_bt_pause.Background = Brushes.Aqua;
              //  main_bt_pause.BorderThickness = new Thickness(1,1,1,3);
              //  main_bt_pause.BorderBrush = Brushes.Red;
                // main_bt_pause.s
                // main_bt_pause.Style = (Style)Application.Current.Resources["activeButton"];
            }
            else
            {
                main_bt_pause.ClearValue(Button.BackgroundProperty);
                main_bt_pause.ClearValue(Button.BorderThicknessProperty);
                main_bt_pause.ClearValue(Button.BorderBrushProperty);
            }

            //connect
        //    tbCounter.Text = m_plc.tags.get_dint().ToString();
            //karetka
         //   kar_tb_position.Text = m_plc.tags.get_ust_karetka_poziciya().ToString(); //go to
         //   kar_tb_current_pos.Text = m_plc.tags.get_kar_tek_poz().ToString();
         //   kar_tb_step.Text = m_plc.tags.get_ust_karetka_rasst().ToString();
         //   kar_tb_left_speed.Text = m_plc.tags.get_ust_karetka_skor_vlevo().ToString();
          //  kar_tb_right_speed.Text = m_plc.tags.get_ust_karetka_skor_vpravo().ToString();
            //kar_cb_lk.IsChecked = m_plc.tags.get_karetka_sleva();
            //kar_cb_pk.IsChecked = m_plc.tags.get_karetka_sprava();
          //  kar_led_lk.IsActive = m_plc.tags.get_karetka_sleva();
          //  kar_led_pk.IsActive = m_plc.tags.get_karetka_sprava();
          /*
            if (m_plc.tags.get_vyhd_kar_dom())
                kar_bt_find_orign.Background = Brushes.Aqua;
            else
                kar_bt_find_orign.ClearValue(Button.BackgroundProperty);

            if (m_plc.tags.get_vyhd_kar_abs())
                kar_bt_start.Background = Brushes.Aqua;
            else
                kar_bt_start.ClearValue(Button.BackgroundProperty);

            if (m_plc.tags.get_vyhd_kar_otn_vlevo())
                kar_bt_vlevo.Background = Brushes.Aqua;
            else
                kar_bt_vlevo.ClearValue(Button.BackgroundProperty);

            if (m_plc.tags.get_vyhd_kar_otn_vpravo())
                kar_bt_vpravo.Background = Brushes.Aqua;
            else
                kar_bt_vpravo.ClearValue(Button.BackgroundProperty);
            // kar_cb_error.IsChecked ??? 
            */
            //stol
         //   stol_tb_porsh_otn0.Text = m_plc.tags.get_ust_stol_poz_porsh_ot_nulya().ToString();
         //   stol_tb_plita_width.Text = m_plc.tags.get_ust_stol_tolshh_plity().ToString();
         //   stol_tb_position.Text = m_plc.tags.get_ust_stol_poziciya().ToString();
        //    stol_tb_step_value.Text = m_plc.tags.get_ust_stol_otn_rasst().ToString();
        //    stol_tb_speed.Text = m_plc.tags.get_ust_stol_skor_vverh().ToString();
        //    stol_tb_line.Text = m_plc.tags.get_linejka().ToString();
        //    main_linejka_dublicate.Data = m_plc.tags.get_linejka().ToString();
            main_laserCount.Data = SpIceControllerLib.SpIceController.laserCount.ToString();
          //  if (m_plc.tags.get_vyhd_pereschjot())
           //     stol_bt_line_control.Background = Brushes.Aqua;
            //else
           //     stol_bt_line_control.ClearValue(Button.BackgroundProperty);


       //     if (m_plc.tags.get_vyhd_stol_poisk_nulya())
     //           stol_bt_find_zero.Background = Brushes.Aqua;
     //       else
      //          stol_bt_find_zero.ClearValue(Button.BackgroundProperty);
//


            //dat
            //dat_po1.Data = m_plc.tags.get_ga_po1().ToString();
            //dat_po2.Data = m_plc.tags.get_ga_po2().ToString();
            //dat_po3.Data = m_plc.tags.get_ga_po3().ToString();
            //dat_ph2.Data = m_plc.tags.get_ga_ph2().ToString();
            //dat_T1.Data = m_plc.tags.get_ga_t1().ToString();
            //dat_T2.Data = m_plc.tags.get_ga_t2().ToString();
            //dat_T3.Data = m_plc.tags.get_ga_t3().ToString();
            //dat_T4.Data = m_plc.tags.get_ga_t4().ToString();
            //dat_davl9.Data = m_plc.tags.get_davl9().ToString();
            //dat_davl10.Data = m_plc.tags.get_davl10().ToString();
            //dat_davl11.Data = m_plc.tags.get_davl11().ToString();

            //dat_sk_pot.IsActive = m_plc.tags.get_prot_skanator();
            //dat_sk_tmp.IsActive = m_plc.tags.get_vys_temp_skanator();
            //dat_kl_pot.IsActive = m_plc.tags.get_prot_gol_laz_i_kalimator();
            //dat_kl_tmp.IsActive = m_plc.tags.get_vys_temp_gol_laz_i_kalimator();
            //dat_ls_pot.IsActive = m_plc.tags.get_prot_lazer();
            //dat_ls_temp.IsActive = m_plc.tags.get_vys_temp_lazer();
            //dat_cooller.IsActive = m_plc.tags.get_ohl_skan()==1;

            //if (m_plc.tags.get_ohl_skan() == 1)
            //    dat_cooller.Text = "Охлаждение в норме";
            //else if (m_plc.tags.get_ohl_skan() == 0)
            //    dat_cooller.Text = "Охлаждение недостаточно";
            //else dat_cooller.Text = "Охлаждение превышено";


            dat_ls_active.IsActive = SpIceController.isBusy();
            dat_ls_wait.IsActive = SpIceController.isWait();

          //  m_plc.tags.set_prozhig_rab(SpIceController.isBusy());
            //autoFire
          //  laerFinish = (lastLaerFinish == true && !m_plc.tags.get_sloj_rab());              
          //  lastLaerFinish = m_plc.tags.get_sloj_rab();

            

            if (laerFinish)
            {
                int stop = 1;
            }

            //laerFinish1 = (lastLaerFinish1 == true && !m_plc.tags.get_sloj_rab());
            //lastLaerFinish1 = m_plc.tags.get_sloj_rab();

         //   pauseFinish = (lastPauseFinish == true && !m_plc.tags.get_kom_pauza());
          //  lastPauseFinish = m_plc.tags.get_kom_pauza();
           // pauseFinish = !m_plc.tags.get_kom_pauza();
          //  bool s1 = m_plc.tags.get_ust_kol_slojov() >0 && laerFinish && !m_plc.tags.get_kom_pauza() && !m_plc.tags.get_kom_prer();
          //  bool s2 = !m_plc.tags.get_sloj_rab() && pauseFinish && m_plc.tags.get_kom_rab_do_pauzy() &&  !m_plc.tags.get_kom_prer();

            //if (s1 || s2)
            //{
            //    Log.Write(LogLevel.Info, "start layer ");
            //    SpIceController.StartLayer_(true);
            //}

            //main
          //  m_main_layerCount_finish.Text = m_plc.tags.get_schjot_slojov().ToString();
         //   m_main_layerCount.Text = m_plc.tags.get_ust_kol_slojov().ToString();

            //shnek
            //snek_s1_tb.Data = m_plc.tags.get_ust_vrem_rab_sh1().ToString();
            //snek_s2_tb.Data = m_plc.tags.get_ust_vrem_rab_sh2().ToString();
            //snek_s3_tb.Data = m_plc.tags.get_ust_vrem_rab_sh3().ToString();
            //snek_s3_tb_nagr.Data = m_plc.tags.get_tok_sh3().ToString();
            //snek_s3_lo.IsActive = m_plc.tags.get_nizhn_ur_poroshka();
            //snek_s3_up.IsActive = m_plc.tags.get_verhn_ur_poroshka();
            //sloi
           // layer_widh.Data = m_plc.tags.get_ust_tolshh_sloya().ToString();
           // layer_time_rot_m3.Data = m_plc.tags.get_ust_vrem_vrashh_na_meste().ToString();
           // layer_stop_m3.Data = m_plc.tags.get_ust_kar_poz_otkl_sh3().ToString();
           // layer_doz_num.Data = m_plc.tags.get_ust_kol_slojov_dlya_dozatora().ToString();
           // layer_doz_rem.Data = m_plc.tags.get_ost_slojov_dlya_dozatora().ToString();
          //  layer_pusk_num.Data = m_plc.tags.get_ust_kol_slojov().ToString();
           // layer_pusk_rem.Data = m_plc.tags.get_ost_slojov().ToString();
         ////   layer_pusk_gotov.Data = m_plc.tags.get_schjot_slojov().ToString();
            layer_scriptFile.Content = SpIceController.getScripFileName();
            //if (m_plc.tags.get_proc_obshh_rab())
            //    main_bt_process.Background = Brushes.Aqua;
            //else
            //    main_bt_process.ClearValue(Button.BackgroundProperty);

            //modul postroenia
            // build_led1.IsActive = m_plc.tags.get_
         

            //bool errVal = !m_plc.tags.get_prot_skanator() || m_plc.tags.get_vys_temp_skanator() ||
            //     !m_plc.tags.get_prot_gol_laz_i_kalimator() || m_plc.tags.get_vys_temp_gol_laz_i_kalimator() ||
            //     !m_plc.tags.get_prot_lazer() || m_plc.tags.get_vys_temp_lazer() || m_plc.tags.get_ohl_skan() != 1;
           
            //    main_bt_startLayer.IsEnabled = !errVal;
            //layer_avtomat_pusk.IsEnabled = !errVal;

            //if (false && m_plc.tags.get_proc_obshh_rab() && (m_plc.tags.get_avar_doz() || m_plc.tags.get_avar_m3()))
            //{
            //    m_pause = !m_pause;
            //    m_plc.tags.set_kom_pauza(m_pause);

            //    string reason = "";
            //    if (m_plc.tags.get_avar_doz())
            //    {
            //        m_plc.tags.set_avar_doz(false);
            //        reason += "[avar_doz]";
            //    }
            //    if (m_plc.tags.get_avar_m3())
            //    {
            //        m_plc.tags.set_avar_m3(false);
            //        reason += "[avar_m3]";
            //    }

            //    System.Windows.MessageBox.Show("Принудительная приостановка процесса прожига " + reason);
            //}


        }

        private void tbDeviceIP_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private bool parseFloat(string s)
        {
            float f;
            return float.TryParse(s, out f);
        }

        private void kar_tb_position_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция перехода", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val)) { System.Windows.MessageBox.Show("Неправильное значение");  return; }
             //   m_plc.tags.set_ust_karetka_poziciya(val);
            }
        }

        private void kar_tb_step_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Шаг", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val)) {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return; }
             //   m_plc.tags.set_ust_karetka_rasst(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_tb_left_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость влево", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_karetka_skor_vlevo(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_tb_right_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость вправо", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_karetka_skor_vpravo(float.Parse(dialog.ResponseText));
            }
        }

        private void kar_bt_stop_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_karetka_stop(true);
        }

        private void kar_bt_start_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_kar_abs(true);
        }

        private void kar_bt_vlevo_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_kar_otn_vlevo(true);
        }

        private void kar_bt_vpravo_Click(object sender, RoutedEventArgs e)
        {
            //m_plc.tags.set_kom_kar_otn_vpravo(true);
        }

        private void kar_bt_find_orign_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_kar_poisk_nulya(true);
        }
        //stol
        private void stol_tb_plita_width_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("толщина плиты", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
            //    m_plc.tags.set_ust_stol_tolshh_plity(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_position_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
             //   m_plc.tags.set_ust_stol_poziciya(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_step_value_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Шаг", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
                m_plc.tags.set_ust_stol_otn_rasst(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_speed_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Скорость", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_stol_skor_vverh(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_tb_line_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Линейка", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
              //  m_plc.tags.set_linejka(float.Parse(dialog.ResponseText));
            }
        }

        private void stol_bt_find_zero_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_stol_poisk_nulya(true);
        }

        private void stol_bt_set_zero_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_stol_ust_nulya(true);
        }

        private void stol_bt_go_to_position_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_abs(true);
        }

        private void stol_bt_step_up_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_stol_otn_pusk_vverh(true);
        }

        private void stol_bt_step_down_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_stol_otn_pusk_vniz(true);
        }

        private void stol_bt_stop_Click(object sender, RoutedEventArgs e)
        {
            m_plc.tags.set_kom_stol_stop(true);
        }

        private void stol_bt_cler_Error_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_stol_sbros(true);
        }

        private void stol_bt_line_clearing_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_obnulit_linejku(true);
        }

        private void stol_bt_line_control_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_pereschjot(true);
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
        //    m_plc.tags.set_kom_svet(true);
        }

        private void main_laser_power(object sender, RoutedEventArgs e)
        {
         //   m_plc.tags.set_kom_got_lazer(true);
        }

        private void m_main_layerCount_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Количество слоев", ((TextBox)sender).Text);
            if (dialog.ShowDialog() == true)
            {
                short val;
                if (!short.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
              //  m_plc.tags.set_ust_kol_slojov(short.Parse(dialog.ResponseText));
            }
        }

        private void main_bt_start_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_sloj(true);
        }

        private void main_bt_process_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_proc_obshh(true);

        }

        private void main_bt_pause_Click(object sender, RoutedEventArgs e)
        {
            m_pause = !m_pause;
         //   m_plc.tags.set_kom_pauza(m_pause);
        }

        private void main_bt_interupt_Click(object sender, RoutedEventArgs e)
        {
            //  m_plc.tags.set_kom_p
           // m_plc.tags.set_kom_prer(true);
          //  Log.Write(LogLevel.Info, "Unimplemented!!!!");
        }

        private void snek_s1_bt_start_Click(object sender, RoutedEventArgs e)
        {
       //     m_plc.tags.set_kom_sh1_rele(true);
        }

        private void snek_s1_tb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
          //      m_plc.tags.set_ust_vrem_rab_sh1(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s2_tb_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
         //       m_plc.tags.set_ust_vrem_rab_sh2(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s3_tb_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время работы", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
        //        m_plc.tags.set_ust_vrem_rab_sh3(float.Parse(dialog.ResponseText));
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
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
        //        m_plc.tags.set_tok_sh3(float.Parse(dialog.ResponseText));
            }
        }

        private void snek_s2_bt_Click(object sender, RoutedEventArgs e)
        {
       //     m_plc.tags.set_kom_sh2_rele(true);
        }

        private void snek_s3_bt_Click(object sender, RoutedEventArgs e)
        {
       //     m_plc.tags.set_kom_sh3_vperjod(true);
        }

        private void main_power_scanator_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_pit_skan(true);
        }

        private void layer_time_rot_m3_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void layer_avtomat_d_Click(object sender, RoutedEventArgs e)
        {
           // m_plc.tags.set_kom_dozator_avtomat(true);
        }

        private void layer_avtomat_pusk_Click(object sender, RoutedEventArgs e)
        {
            //m_plc.tags.set_kom_sloj(true);
        }

        private void layer_time_rot_m3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Время вращения М3 на месте", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_vrem_vrashh_na_meste(float.Parse(dialog.ResponseText));
            }
        }

        private void layer_stop_m3_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Позиция отключения М3", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                float val;
                if (!float.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
              //  m_plc.tags.set_ust_kar_poz_otkl_sh3(float.Parse(dialog.ResponseText));
            }
        }

        private void layer_doz_num_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Дозатор -количество слоёв", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                short val;
                if (!short.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
                //m_plc.tags.set_ust_kol_slojov_dlya_dozatora(short.Parse(dialog.ResponseText));
            }
        }

        private void layer_pusk_num_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Количество слоёв", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                short val;
                if (!short.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_kol_slojov(short.Parse(dialog.ResponseText));
            }
        }

        private void layer_avtomat_reset_Click(object sender, RoutedEventArgs e)
        {
          //  m_plc.tags.set_kom_sloj_sbros_schjotchika(true);
        }

        private void layer_widh_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Толщина слоя", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                short val;
                if (!short.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }
               // m_plc.tags.set_ust_tolshh_sloya(short.Parse(dialog.ResponseText));
            }
        }

        private void main_Sherif_Click(object sender, RoutedEventArgs e)
        {
            // m_plc.tags.set_kom_s
            Log.Write(LogLevel.Info, "___________Unimplemented!!!!____________");
        }

        private void build_nul_acc_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_nul_toch(true);
        }

        private void build_set_up_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_s1_pod_jom(true);
        }

        private void build_set_down_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_s2_opuskanie(true);
        }

        private void build_zakat_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_s3_zakat(true);
        }

        private void build_vikat_Click(object sender, RoutedEventArgs e)
        {
      //      m_plc.tags.set_kom_s4_vykat(true);
        }


        private void main_laserCount_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new inputDialog("Кол-во лазеров", ((dataField)sender).Data);
            if (dialog.ShowDialog() == true)
            {
                short val;
                if (!short.TryParse(dialog.ResponseText, out val))
                {
                    System.Windows.MessageBox.Show("Неправильное значение");
                    return;
                }

                if ((short.Parse(dialog.ResponseText)) > 4)
                {
                    System.Windows.MessageBox.Show("Кол-во лазеров больше 4 не поддерживается");
                    return;
                }
                SpIceControllerLib.SpIceController.laserCount = (short.Parse(dialog.ResponseText));
            }
        }

      
    }
}
