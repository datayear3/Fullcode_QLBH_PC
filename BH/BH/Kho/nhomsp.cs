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
    public partial class nhomsp : Form
    {
        ketnoi kn = new ketnoi();
        public nhomsp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SL = Convert.ToInt32(textBox3.Text);
            kn.insert("INSERT INTO NHOM_SAN_PHAM VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + SL + "')" );
            
        }
    }
}
