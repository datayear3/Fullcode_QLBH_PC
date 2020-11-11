namespace BH
{
    partial class main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trangchu1 = new BH.trangchu();
            this.thongke1 = new BH.thongke();
            this.kho1 = new BH.kho();
            this.banhang1 = new BH.banhang();
            this.admin1 = new BH.admin();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.bt_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1041);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::BH.Properties.Resources.icons8_exit_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::BH.Properties.Resources.icons8_data_provider_50;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(27, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 83);
            this.button6.TabIndex = 7;
            this.button6.Text = "KHO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::BH.Properties.Resources.icons8_admin_settings_male_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(27, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 83);
            this.button5.TabIndex = 6;
            this.button5.Text = "    ADMIN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::BH.Properties.Resources.icons8_sell_stock_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(27, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 83);
            this.button4.TabIndex = 5;
            this.button4.Text = "        BÁN HÀNG";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::BH.Properties.Resources.icons8_financial_tasks_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(27, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 83);
            this.button3.TabIndex = 4;
            this.button3.Text = "        THỐNG KÊ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_home
            // 
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Image = global::BH.Properties.Resources.icons8_home_page_50;
            this.bt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_home.Location = new System.Drawing.Point(27, 80);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(270, 83);
            this.bt_home.TabIndex = 2;
            this.bt_home.Text = "        TRANG CHỦ";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.button2_Click);
            this.bt_home.MouseHover += new System.EventHandler(this.bt_home_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1604, 80);
            this.panel2.TabIndex = 1;
            // 
            // trangchu1
            // 
            this.trangchu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trangchu1.Location = new System.Drawing.Point(300, 80);
            this.trangchu1.Name = "trangchu1";
            this.trangchu1.Size = new System.Drawing.Size(1620, 1000);
            this.trangchu1.TabIndex = 6;
            this.trangchu1.Load += new System.EventHandler(this.trangchu1_Load);
            // 
            // thongke1
            // 
            this.thongke1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.thongke1.Location = new System.Drawing.Point(300, 80);
            this.thongke1.Name = "thongke1";
            this.thongke1.Size = new System.Drawing.Size(1620, 1000);
            this.thongke1.TabIndex = 5;
            // 
            // kho1
            // 
            this.kho1.BackColor = System.Drawing.Color.Gray;
            this.kho1.Location = new System.Drawing.Point(300, 80);
            this.kho1.Name = "kho1";
            this.kho1.Size = new System.Drawing.Size(1620, 1000);
            this.kho1.TabIndex = 4;
            // 
            // banhang1
            // 
            this.banhang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.banhang1.Location = new System.Drawing.Point(300, 80);
            this.banhang1.Name = "banhang1";
            this.banhang1.Size = new System.Drawing.Size(1620, 1000);
            this.banhang1.TabIndex = 3;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.Purple;
            this.admin1.Location = new System.Drawing.Point(300, 80);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(1620, 1000);
            this.admin1.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.trangchu1);
            this.Controls.Add(this.thongke1);
            this.Controls.Add(this.kho1);
            this.Controls.Add(this.banhang1);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private admin admin1;
        private banhang banhang1;
        private kho kho1;
        private thongke thongke1;
        private trangchu trangchu1;
    }
}