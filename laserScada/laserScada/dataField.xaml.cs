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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace laserScada
{
    /// <summary>
    /// Interaction logic for dataField.xaml
    /// </summary>
    public partial class dataField : UserControl
    {
        public String Text
        {
            get
            {
                return (string)lb_text.Content;
            }
            set
            {
                lb_text.Content = value;
            }
        }

        public String Data
        {
            get
            {
                return (string)tb_data.Text;
            }
            set
            {
                tb_data.Text = value;
            }
        }
        public dataField()
        {
            InitializeComponent();
        }
    }
}
