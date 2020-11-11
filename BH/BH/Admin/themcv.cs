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
    public partial class themcv : Form
    {
        ketnoi kn = new ketnoi();
        public themcv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.insert("INSERT INTO CHUC_VU VALUES('" + textBox1.Text + "','" + textBox2.Text + "')");

            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from CHUC_VU",connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            
        }

        private void themcv_Load(object sender, EventArgs e)
        {
            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from CHUC_VU", connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kn.insert("delete from CHUC_VU where MaCV ='"+ textBox1.Text + "'");
            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from CHUC_VU", connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaCV"].FormattedValue.ToString();
                textBox1.Enabled = false;
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TenCV"].FormattedValue.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kn.insert("update CHUC_VU  set TenCV ='"+textBox2.Text+"'  where MaCV ='" + textBox1.Text + "'");
            using (SqlConnection connet_sql = new SqlConnection("Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True"))
            {
                connet_sql.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from CHUC_VU", connet_sql);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                dataGridView1.DataSource = tb;
            }
        }

        private void themcv_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
    }
}
