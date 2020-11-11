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

namespace BH.Kho
{
    public partial class sanpham : UserControl
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlConnection con;
        public sanpham()
        {
            InitializeComponent();
        }

        private void sanpham_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=MC;Initial Catalog=QuanLyCuaHangBanLe;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into NHOM_SAN_PHAM VALUES (",con);
        }
    }
}
