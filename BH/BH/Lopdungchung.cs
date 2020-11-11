using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH
{
    class Lopdungchung
    {
        SqlConnection conn;
        BH.frm_hoadon frmhd;
        string chuoiketnoi = @"Data Source=MC;Initial Catalog=QuanLyCuaHangBanLe;Integrated Security=True";
        public Lopdungchung(BH.frm_hoadon f)
        {
            frmhd = f;
        }

        public Lopdungchung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }

        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            return conn;
        }

        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;
        }
        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            object ketqua = comm.ExecuteScalar();
            Dong();
            return ketqua;

        }
        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
