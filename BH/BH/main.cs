using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bt_home.BackColor = System.Drawing.Color.Red;
            trangchu1.Visible = true;
            banhang1.Visible = false;
            thongke1.Visible = false;
            kho1.Visible = false;
            admin1.Visible = false;
        }

        private void bt_home_MouseHover(object sender, EventArgs e)
        {
            //bt_home.BackColor = System.Drawing.Color.Red;
        }

        private void trangchu1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = false;
            banhang1.Visible = true;
            thongke1.Visible = false;
            kho1.Visible = false;
            admin1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = false;
            banhang1.Visible = false;
            thongke1.Visible = true;
            kho1.Visible = false;
            admin1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = false;
            banhang1.Visible = false;
            thongke1.Visible = false;
            kho1.Visible = true;
            admin1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trangchu1.Visible =false;
            banhang1.Visible = false;
            thongke1.Visible = false;
            kho1.Visible = false;
            admin1.Visible = true;
        }
    }
}
