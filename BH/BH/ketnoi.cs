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
using System.Runtime.InteropServices;

namespace BH
{

    class ketnoi
    {
        
        public string constring()
        {
            return "Data Source = MC; Initial Catalog = QuanLyCuaHangBanLe; Integrated Security = True";
        }
        public void insert(string query)
        {
            SqlConnection con = new SqlConnection(constring());
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void In_data()
        {
            SqlConnection con = new SqlConnection(constring());
        }
        
    }
}
