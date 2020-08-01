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
    public partial class AddPhone : Form
    {
        int Id;
        public AddPhone(string x,string y, int Id)
        {
            InitializeComponent();
            label1.Text = x;
            label2.Text = y;
            this.Id = Id;
        }

        private void AddPhone_Load(object sender, EventArgs e)
        {

        }

        private bool test(string x)
        {

            for(int i = 0; i < x.Length; i++)
            {
                try
                {
                    int n = Convert.ToInt32(x[i]);
                  
                }
                catch(Exception e)
                {
                    textBox1.BackColor = Color.Red;
                    i = x.Length;
                    return false;
                }


            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test(textBox1.Text) && textBox1.Text.Length >0)
            {
                ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryAddPhone(this.Id, textBox1.Text));
                ProgramITC.activeMembreReflesh();
                
            }

            ProgramITC.activeMembreReflesh();
            Close();

        }
    }
}
