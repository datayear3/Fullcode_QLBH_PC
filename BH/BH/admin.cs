using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BH.Admin;

namespace BH
{
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themcv cv = new themcv();
            cv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themnv TNV = new themnv();
            TNV.ShowDialog();
        }
    }
}
