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
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(12, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "192.168.100.2";
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
            this.tb_inc.Location = new System.Drawing.Point(12, 63);
            this.tb_inc.Name = "tb_inc";
            this.tb_inc.Size = new System.Drawing.Size(69, 20);
            this.tb_inc.TabIndex = 3;
            // 
            // tb_ctl
            // 
            this.tb_ctl.Location = new System.Drawing.Point(174, 62);
            this.tb_ctl.Name = "tb_ctl";
            this.tb_ctl.Size = new System.Drawing.Size(61, 20);
            this.tb_ctl.TabIndex = 4;
            this.tb_ctl.Text = "0";
            // 
            // btCtl
            // 
            this.btCtl.Location = new System.Drawing.Point(250, 63);
            this.btCtl.Name = "btCtl";
            this.btCtl.Size = new System.Drawing.Size(75, 23);
            this.btCtl.TabIndex = 5;
            this.btCtl.Text = "button1";
            this.btCtl.UseVisualStyleBackColor = true;
            this.btCtl.Click += new System.EventHandler(this.btCtl_Click);
            // 
            // tb_real
            // 
            this.tb_real.Location = new System.Drawing.Point(12, 89);
            this.tb_real.Name = "tb_real";
            this.tb_real.Size = new System.Drawing.Size(69, 20);
            this.tb_real.TabIndex = 6;
            // 
            // tb_dint
            // 
            this.tb_dint.Location = new System.Drawing.Point(12, 115);
            this.tb_dint.Name = "tb_dint";
            this.tb_dint.Size = new System.Drawing.Size(69, 20);
            this.tb_dint.TabIndex = 7;
            // 
            // tb_bool
            // 
            this.tb_bool.Location = new System.Drawing.Point(12, 141);
            this.tb_bool.Name = "tb_bool";
            this.tb_bool.Size = new System.Drawing.Size(69, 20);
            this.tb_bool.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 141);
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
            this.checkBox1.Location = new System.Drawing.Point(195, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 419);
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
    }
}

