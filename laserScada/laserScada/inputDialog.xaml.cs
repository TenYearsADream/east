using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace laserScada
{
    public delegate bool MyParse(string x);

  
    /// <summary>
    /// Interaction logic for inputDialog.xaml
    /// </summary>
    public partial class inputDialog :  MetroWindow
    {
  
        public inputDialog(string nameVar, string initVal )
        {
           
            InitializeComponent();
            lb_name_var.Text = nameVar;
            ResponseTextBox.Text = initVal;
            ResponseTextBox.SelectAll();

            var point = Mouse.GetPosition(Application.Current.MainWindow);
         
        //   HorizontalOffset = point.X;
        //    VerticalOffset = point.Y;
        }

        public string ResponseText
        {
            get { return ResponseTextBox.Text; }
            set { ResponseTextBox.Text = value; }
        }

        private void ResponseTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
         
            DialogResult = true;

        }
        private void FailButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

        }

        private void ResponseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                DialogResult = true;
        }


    }
}
