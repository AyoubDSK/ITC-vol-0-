using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_
{
    public partial class ErorForm : Form
    {
        public ErorForm(string x)
        {
            InitializeComponent();

            label1.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
