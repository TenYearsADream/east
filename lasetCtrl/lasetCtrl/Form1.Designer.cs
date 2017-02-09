namespace lasetCtrl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lconnect = new System.Windows.Forms.Label();
            this.tb_inc = new System.Windows.Forms.TextBox();
            this.tb_ctl = new System.Windows.Forms.TextBox();
            this.btCtl = new System.Windows.Forms.Button();
            this.tb_real = new System.Windows.Forms.TextBox();
            this.tb_dint = new System.Windows.Forms.TextBox();
            this.tb_bool = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_kar_start = new System.Windows.Forms.Button();
            this.bt_kar_goto_zero = new System.Windows.Forms.Button();
            this.bt_kar_com_right = new System.Windows.Forms.Button();
            this.bt_kar_com_left = new System.Windows.Forms.Button();
            this.bt_kar_com_clear_error = new System.Windows.Forms.Button();
            this.bt_kar_com_stop = new System.Windows.Forms.Button();
            this.cb_konc_right = new System.Windows.Forms.CheckBox();
            this.cb_konc_left = new System.Windows.Forms.CheckBox();
            this.cb_kar_error = new System.Windows.Forms.CheckBox();
            this.cb_kar_goto_zero_busy = new System.Windows.Forms.CheckBox();
            this.tb_kar_righet_speed = new TextBoxWithLabel();
            this.tb_kar_left_speed = new TextBoxWithLabel();
            this.tb_kar_step_width = new TextBoxWithLabel();
            this.tb_kar_position = new TextBoxWithLabel();
            this.tb_karetka_position = new TextBoxWithLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(12, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "192.168.100.2";
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lconnect
            // 
            this.lconnect.AutoSize = true;
            this.lconnect.Location = new System.Drawing.Point(118, 15);
            this.lconnect.Name = "lconnect";
            this.lconnect.Size = new System.Drawing.Size(62, 13);
            this.lconnect.TabIndex = 2;
            this.lconnect.Text = " disconnect";
            // 
            // tb_inc
            // 
            this.tb_inc.Location = new System.Drawing.Point(579, 301);
            this.tb_inc.Name = "tb_inc";
            this.tb_inc.Size = new System.Drawing.Size(69, 20);
            this.tb_inc.TabIndex = 3;
            // 
            // tb_ctl
            // 
            this.tb_ctl.Location = new System.Drawing.Point(672, 301);
            this.tb_ctl.Name = "tb_ctl";
            this.tb_ctl.Size = new System.Drawing.Size(61, 20);
            this.tb_ctl.TabIndex = 4;
            this.tb_ctl.Text = "0";
            // 
            // btCtl
            // 
            this.btCtl.Location = new System.Drawing.Point(672, 327);
            this.btCtl.Name = "btCtl";
            this.btCtl.Size = new System.Drawing.Size(75, 23);
            this.btCtl.TabIndex = 5;
            this.btCtl.Text = "button1";
            this.btCtl.UseVisualStyleBackColor = true;
            this.btCtl.Click += new System.EventHandler(this.btCtl_Click);
            // 
            // tb_real
            // 
            this.tb_real.Location = new System.Drawing.Point(579, 327);
            this.tb_real.Name = "tb_real";
            this.tb_real.Size = new System.Drawing.Size(69, 20);
            this.tb_real.TabIndex = 6;
            // 
            // tb_dint
            // 
            this.tb_dint.Location = new System.Drawing.Point(579, 353);
            this.tb_dint.Name = "tb_dint";
            this.tb_dint.Size = new System.Drawing.Size(69, 20);
            this.tb_dint.TabIndex = 7;
            // 
            // tb_bool
            // 
            this.tb_bool.Location = new System.Drawing.Point(579, 379);
            this.tb_bool.Name = "tb_bool";
            this.tb_bool.Size = new System.Drawing.Size(69, 20);
            this.tb_bool.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(762, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_kar_goto_zero_busy);
            this.groupBox1.Controls.Add(this.cb_kar_error);
            this.groupBox1.Controls.Add(this.cb_konc_left);
            this.groupBox1.Controls.Add(this.cb_konc_right);
            this.groupBox1.Controls.Add(this.bt_kar_com_clear_error);
            this.groupBox1.Controls.Add(this.bt_kar_com_stop);
            this.groupBox1.Controls.Add(this.bt_kar_com_right);
            this.groupBox1.Controls.Add(this.bt_kar_com_left);
            this.groupBox1.Controls.Add(this.bt_kar_goto_zero);
            this.groupBox1.Controls.Add(this.bt_kar_start);
            this.groupBox1.Controls.Add(this.tb_kar_righet_speed);
            this.groupBox1.Controls.Add(this.tb_kar_left_speed);
            this.groupBox1.Controls.Add(this.tb_kar_step_width);
            this.groupBox1.Controls.Add(this.tb_kar_position);
            this.groupBox1.Controls.Add(this.tb_karetka_position);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 198);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каретка";
            // 
            // bt_kar_start
            // 
            this.bt_kar_start.Location = new System.Drawing.Point(216, 37);
            this.bt_kar_start.Name = "bt_kar_start";
            this.bt_kar_start.Size = new System.Drawing.Size(75, 21);
            this.bt_kar_start.TabIndex = 5;
            this.bt_kar_start.Text = "Пуск";
            this.bt_kar_start.UseVisualStyleBackColor = true;
            this.bt_kar_start.Click += new System.EventHandler(this.bt_kar_start_Click);
            // 
            // bt_kar_goto_zero
            // 
            this.bt_kar_goto_zero.Location = new System.Drawing.Point(297, 34);
            this.bt_kar_goto_zero.Name = "bt_kar_goto_zero";
            this.bt_kar_goto_zero.Size = new System.Drawing.Size(75, 21);
            this.bt_kar_goto_zero.TabIndex = 6;
            this.bt_kar_goto_zero.Text = "Поиск нуля";
            this.bt_kar_goto_zero.UseVisualStyleBackColor = true;
            this.bt_kar_goto_zero.Click += new System.EventHandler(this.bt_kar_goto_zero_Click);
            // 
            // bt_kar_com_right
            // 
            this.bt_kar_com_right.Location = new System.Drawing.Point(297, 72);
            this.bt_kar_com_right.Name = "bt_kar_com_right";
            this.bt_kar_com_right.Size = new System.Drawing.Size(75, 21);
            this.bt_kar_com_right.TabIndex = 8;
            this.bt_kar_com_right.Text = "Вправо";
            this.bt_kar_com_right.UseVisualStyleBackColor = true;
            this.bt_kar_com_right.Click += new System.EventHandler(this.bt_kar_com_right_Click);
            // 
            // bt_kar_com_left
            // 
            this.bt_kar_com_left.Location = new System.Drawing.Point(216, 72);
            this.bt_kar_com_left.Name = "bt_kar_com_left";
            this.bt_kar_com_left.Size = new System.Drawing.Size(75, 21);
            this.bt_kar_com_left.TabIndex = 7;
            this.bt_kar_com_left.Text = "Влево";
            this.bt_kar_com_left.UseVisualStyleBackColor = true;
            this.bt_kar_com_left.Click += new System.EventHandler(this.bt_kar_com_left_Click);
            // 
            // bt_kar_com_clear_error
            // 
            this.bt_kar_com_clear_error.Location = new System.Drawing.Point(10, 166);
            this.bt_kar_com_clear_error.Name = "bt_kar_com_clear_error";
            this.bt_kar_com_clear_error.Size = new System.Drawing.Size(90, 21);
            this.bt_kar_com_clear_error.TabIndex = 10;
            this.bt_kar_com_clear_error.Text = "Сброс ошибки";
            this.bt_kar_com_clear_error.UseVisualStyleBackColor = true;
            this.bt_kar_com_clear_error.Click += new System.EventHandler(this.bt_kar_com_clear_error_Click);
            // 
            // bt_kar_com_stop
            // 
            this.bt_kar_com_stop.Location = new System.Drawing.Point(216, 106);
            this.bt_kar_com_stop.Name = "bt_kar_com_stop";
            this.bt_kar_com_stop.Size = new System.Drawing.Size(75, 21);
            this.bt_kar_com_stop.TabIndex = 9;
            this.bt_kar_com_stop.Text = "Стоп";
            this.bt_kar_com_stop.UseVisualStyleBackColor = true;
            this.bt_kar_com_stop.Click += new System.EventHandler(this.bt_kar_com_stop_Click);
            // 
            // cb_konc_right
            // 
            this.cb_konc_right.AutoSize = true;
            this.cb_konc_right.Location = new System.Drawing.Point(397, 72);
            this.cb_konc_right.Name = "cb_konc_right";
            this.cb_konc_right.Size = new System.Drawing.Size(63, 17);
            this.cb_konc_right.TabIndex = 12;
            this.cb_konc_right.Text = "Справа";
            this.cb_konc_right.UseVisualStyleBackColor = true;
            // 
            // cb_konc_left
            // 
            this.cb_konc_left.AutoSize = true;
            this.cb_konc_left.Location = new System.Drawing.Point(397, 110);
            this.cb_konc_left.Name = "cb_konc_left";
            this.cb_konc_left.Size = new System.Drawing.Size(57, 17);
            this.cb_konc_left.TabIndex = 13;
            this.cb_konc_left.Text = "Слева";
            this.cb_konc_left.UseVisualStyleBackColor = true;
            // 
            // cb_kar_error
            // 
            this.cb_kar_error.AutoSize = true;
            this.cb_kar_error.Location = new System.Drawing.Point(397, 133);
            this.cb_kar_error.Name = "cb_kar_error";
            this.cb_kar_error.Size = new System.Drawing.Size(66, 17);
            this.cb_kar_error.TabIndex = 14;
            this.cb_kar_error.Text = "Ошибка";
            this.cb_kar_error.UseVisualStyleBackColor = true;
            // 
            // cb_kar_goto_zero_busy
            // 
            this.cb_kar_goto_zero_busy.AutoSize = true;
            this.cb_kar_goto_zero_busy.Location = new System.Drawing.Point(396, 34);
            this.cb_kar_goto_zero_busy.Name = "cb_kar_goto_zero_busy";
            this.cb_kar_goto_zero_busy.Size = new System.Drawing.Size(67, 17);
            this.cb_kar_goto_zero_busy.TabIndex = 15;
            this.cb_kar_goto_zero_busy.Text = "Поиск 0";
            this.cb_kar_goto_zero_busy.UseVisualStyleBackColor = true;
            // 
            // tb_kar_righet_speed
            // 
            this.tb_kar_righet_speed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kar_righet_speed.LabelText = "Скорость вправо (мм/с)";
            this.tb_kar_righet_speed.Location = new System.Drawing.Point(10, 110);
            this.tb_kar_righet_speed.Name = "tb_kar_righet_speed";
            this.tb_kar_righet_speed.Size = new System.Drawing.Size(200, 13);
            this.tb_kar_righet_speed.TabIndex = 4;
            this.tb_kar_righet_speed.Text = "0";
            this.tb_kar_righet_speed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_kar_righet_speed_MouseDoubleClick);
            // 
            // tb_kar_left_speed
            // 
            this.tb_kar_left_speed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kar_left_speed.LabelText = "Скорость влево (мм/с)";
            this.tb_kar_left_speed.Location = new System.Drawing.Point(10, 91);
            this.tb_kar_left_speed.Name = "tb_kar_left_speed";
            this.tb_kar_left_speed.Size = new System.Drawing.Size(200, 13);
            this.tb_kar_left_speed.TabIndex = 3;
            this.tb_kar_left_speed.Text = "0";
            this.tb_kar_left_speed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_kar_left_speed_MouseDoubleClick);
            // 
            // tb_kar_step_width
            // 
            this.tb_kar_step_width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kar_step_width.LabelText = "Расстояние (мм)";
            this.tb_kar_step_width.Location = new System.Drawing.Point(10, 72);
            this.tb_kar_step_width.Name = "tb_kar_step_width";
            this.tb_kar_step_width.Size = new System.Drawing.Size(200, 13);
            this.tb_kar_step_width.TabIndex = 2;
            this.tb_kar_step_width.Text = "0";
            this.tb_kar_step_width.DoubleClick += new System.EventHandler(this.tb_kar_step_width_DoubleClick);
            // 
            // tb_kar_position
            // 
            this.tb_kar_position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kar_position.LabelText = "Тек . позиция (мм)";
            this.tb_kar_position.Location = new System.Drawing.Point(10, 53);
            this.tb_kar_position.Name = "tb_kar_position";
            this.tb_kar_position.Size = new System.Drawing.Size(200, 13);
            this.tb_kar_position.TabIndex = 1;
            this.tb_kar_position.Text = "0";
            // 
            // tb_karetka_position
            // 
            this.tb_karetka_position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_karetka_position.LabelText = "Позиция (мм)";
            this.tb_karetka_position.Location = new System.Drawing.Point(10, 34);
            this.tb_karetka_position.Name = "tb_karetka_position";
            this.tb_karetka_position.Size = new System.Drawing.Size(200, 13);
            this.tb_karetka_position.TabIndex = 0;
            this.tb_karetka_position.Text = "0";
            this.tb_karetka_position.DoubleClick += new System.EventHandler(this.tb_karetka_position_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_bool);
            this.Controls.Add(this.tb_dint);
            this.Controls.Add(this.tb_real);
            this.Controls.Add(this.btCtl);
            this.Controls.Add(this.tb_ctl);
            this.Controls.Add(this.tb_inc);
            this.Controls.Add(this.lconnect);
            this.Controls.Add(this.ipTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lconnect;
        private System.Windows.Forms.TextBox tb_inc;
        private System.Windows.Forms.TextBox tb_ctl;
        private System.Windows.Forms.Button btCtl;
        private System.Windows.Forms.TextBox tb_real;
        private System.Windows.Forms.TextBox tb_dint;
        private System.Windows.Forms.TextBox tb_bool;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBoxWithLabel tb_karetka_position;
        private TextBoxWithLabel tb_kar_righet_speed;
        private TextBoxWithLabel tb_kar_left_speed;
        private TextBoxWithLabel tb_kar_step_width;
        private TextBoxWithLabel tb_kar_position;
        private System.Windows.Forms.CheckBox cb_kar_error;
        private System.Windows.Forms.CheckBox cb_konc_left;
        private System.Windows.Forms.CheckBox cb_konc_right;
        private System.Windows.Forms.Button bt_kar_com_clear_error;
        private System.Windows.Forms.Button bt_kar_com_stop;
        private System.Windows.Forms.Button bt_kar_com_right;
        private System.Windows.Forms.Button bt_kar_com_left;
        private System.Windows.Forms.Button bt_kar_goto_zero;
        private System.Windows.Forms.Button bt_kar_start;
        private System.Windows.Forms.CheckBox cb_kar_goto_zero_busy;
    }
}

