using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_tínhđiểmtb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntinhtrungbinh_Click(object sender, EventArgs e)
        {
            Double toan, van, tb;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);
            tb = (toan + van) / 2;
            txttb.Text = tb.ToString();
            if (tb < 5)
            { txtxeploai.Text = "yếu"; }
            else if (tb <= 6) { txtxeploai.Text = "TB"; }
            else if (tb < 8) { txtxeploai.Text = "khá"; }
            else
            {
                txtxeploai.Text = "GIỎi";
            }
        }
    }
}

