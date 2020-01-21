using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFT_Jatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text.Length < 3)
            {
                tb_name.ForeColor = Color.Red;
            }
            else
            {
                tb_name.ForeColor = Color.Black;
            }
        }
    }
}
