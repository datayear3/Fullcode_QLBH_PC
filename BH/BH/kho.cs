using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BH.Kho;

namespace BH
{
    public partial class kho : UserControl
    {
        public kho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            themsanpham sp = new themsanpham();
            sp.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            nhomsp nsp = new nhomsp();
            nsp.ShowDialog();
        }
    }
}
