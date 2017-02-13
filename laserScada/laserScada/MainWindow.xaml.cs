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

namespace laserScada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        plc m_plc;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
 
            m_plc = new plc();


            lbConectedStatus.Content = m_plc.connect() ? "Ok" : "Fail";
          

            this.Loaded += MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            timer.Tick += new EventHandler(updateSignals);

            timer.Start();
        }

        private void updateSignals(object sender, EventArgs e)
        {

           

                tbCounter.Text = m_plc.tags.get_dint().ToString();
            kar_tb_position.Text = m_plc.tags.get_ust_karetka_poziciya().ToString();
            kar_tb_step.Text = m_plc.tags.get_ust_karetka_rasst().ToString();
 


        }

        private void tbDeviceIP_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
