using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lasetCtrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer.Interval = (100);
            timer.Tick += new EventHandler(updateSignals);
            
            timer.Start();
            

              m_plc = new plc();


            if (m_plc.connect())
                lconnect.Text = "connect";
            else
                lconnect.Text = "connection  error";




            
        }

        private void updateSignals(object sender, EventArgs e)
        {
            tb_inc.Text = m_plc.tags.get_ust_tolshh_sloya().ToString();

            tb_real.Text = m_plc.tags.get_real().ToString();
            tb_dint.Text = m_plc.tags.get_dint().ToString();
            tb_bool.Text = m_plc.tags.get_bool().ToString();
            
            //karetka
            tb_karetka_position.Text = m_plc.tags.get_ust_karetka_poziciya().ToString();
            tb_kar_step_width.Text = m_plc.tags.get_ust_karetka_rasst().ToString();
            tb_kar_righet_speed.Text = m_plc.tags.get_ust_karetka_skor_vpravo().ToString();
            tb_kar_position.Text = m_plc.tags.get_kar_tek_poz().ToString();
            tb_kar_left_speed.Text = m_plc.tags.get_ust_karetka_skor_vlevo().ToString();
            cb_kar_goto_zero_busy.Checked = m_plc.tags.get_vyhd_kar_dom();
            cb_konc_left.Checked = m_plc.tags.get_karetka_sleva();
            cb_konc_right.Checked = m_plc.tags.get_karetka_sprava();

           // cb_kar_error.Checked =m_plc.tags.get_vyhd_ka


        }

        plc m_plc;
  
        private Timer timer = new Timer();

        private void btCtl_Click(object sender, EventArgs e)
        {
            var val = Int16.Parse(tb_ctl.Text);
            //m_plc.tags.setInc(val);
            m_plc.tags.set_nomer_vyhoda(val);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_bool(checkBox1.Checked);

            m_plc.tags.set_real(0);
            m_plc.tags.set_dint(0);
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWithLabel1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void tb_karetka_position_DoubleClick(object sender, EventArgs e)
        {

            InputBox input = InputBox.Show(((TextBoxWithLabel)sender).LabelText, new InputBoxItem("Val", ((TextBox)sender).Text), InputBoxButtons.OKCancel);
            if (input.Result == InputBoxResult.OK)
                m_plc.tags.set_ust_karetka_poziciya(float.Parse(input.Items["Val"]));
        }

        private void tb_kar_step_width_DoubleClick(object sender, EventArgs e)
        {
            InputBox input = InputBox.Show(((TextBoxWithLabel)sender).LabelText, new InputBoxItem("Val", ((TextBox)sender).Text), InputBoxButtons.OKCancel);
            if (input.Result == InputBoxResult.OK)
                m_plc.tags.set_ust_karetka_rasst(float.Parse(input.Items["Val"]));
        }

        private void bt_kar_goto_zero_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_kar_poisk_nulya(true);
        }


        private void tb_kar_righet_speed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InputBox input = InputBox.Show(((TextBoxWithLabel)sender).LabelText, new InputBoxItem("Val", ((TextBox)sender).Text), InputBoxButtons.OKCancel);
            if (input.Result == InputBoxResult.OK)
                m_plc.tags.set_ust_karetka_skor_vpravo(float.Parse(input.Items["Val"]));
        }

        private void tb_kar_left_speed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InputBox input = InputBox.Show(((TextBoxWithLabel)sender).LabelText, new InputBoxItem("Val", ((TextBox)sender).Text), InputBoxButtons.OKCancel);
            if (input.Result == InputBoxResult.OK)
                m_plc.tags.set_ust_karetka_skor_vlevo(float.Parse(input.Items["Val"]));
        }

        private void bt_kar_start_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_kar_abs(true);
        }

        private void bt_kar_com_left_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_kar_otn_vlevo(true);
        }

        private void bt_kar_com_right_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_kar_otn_vpravo(true);
        }

        private void bt_kar_com_stop_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_karetka_stop(true);
        }

        private void bt_kar_com_clear_error_Click(object sender, EventArgs e)
        {
            m_plc.tags.set_kom_karetka_sbros(true);
        }



    }
}
