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
        public SqlConnection con;
        public SqlCommand com;
        public DataSet ds;
        public SqlDataAdapter da;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text.ToString();
            string pass = txt_pass.Text.ToString();
            try
            {
                con = new SqlConnection("Data Source=MC;Initial Catalog=QuanLyCuaHangBanLe;Integrated Security=True");
                con.Open();
                ds = new DataSet();
                string sql = "select * from NHAN_VIEN where MaNV='" + user + "' and MatKhau='" + pass + "'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds,"NHAN_VIEN");
                DataView dv = new DataView(ds.Tables["NHAN_VIEN"]);
                if (ds.Tables["NHAN_VIEN"].Rows.Count > 0)
                {
                    //MessageBox.Show("Dang nhap thanh cong");
                    main m = new main();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai xin vui long thu lai");
                }
                //Dangnhap dn = new Dangnhap();
                con.Close();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Loi dang nhap " + ie);
            }
        }
    }
}
