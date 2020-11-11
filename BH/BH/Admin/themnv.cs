using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BH.Admin
{
    public partial class themnv : Form
    {
        ketnoi kn = new ketnoi();
        public themnv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.insert("INSERT INTO NHAN_VIEN VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')");
            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from NHAN_VIEN", connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
        }

        private void themnv_Load(object sender, EventArgs e)
        {
            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from NHAN_VIEN", connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
        }
    }
}
