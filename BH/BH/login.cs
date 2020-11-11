using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BH
{
    public partial class login : Form
    {
        Lopdungchung lopchung = new Lopdungchung();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            try
            {

                string sql = "select count(*) from NHAN_VIEN where MaNV = '" + user.ToUpper() + "'and MatKhau = '" + pass.ToUpper() + "'";
                int kq = (int)lopchung.ExcuteScalar(sql);
                if (kq >= 1)
                {
                    Frm_Main m = new Frm_Main();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    dem++;
                    MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                    if (dem == 3)
                    {
                        MessageBox.Show("Bạn đã nhập sai 3 lần");
                        Application.Exit();
                    }
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show("Loi dang nhap " + ie);
            }
        }
    }
}
