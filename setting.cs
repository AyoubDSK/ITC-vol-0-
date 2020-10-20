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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        string host, user, port, password, database;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.BackColor == Color.Red)
            {
                textBox3.BackColor = Color.White;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.BackColor == Color.Red)
            {
                textBox4.BackColor = Color.White;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.BackColor == Color.Red)
            {
                textBox5.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.BackColor == Color.Red)
            {
                textBox2.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.BackColor == Color.Red)
            {
                textBox1.BackColor = Color.White;
            }
        }

        bool test()
        {
         host=   textBox1.Text;
            user = textBox2.Text;
            port = textBox3.Text;
            password = textBox4.Text;
            database = textBox5.Text;
            bool ok=true;
            if(host.Length >0)
            {
                if (port.Length > 0)
                {
                    if (port.Length > 0)
                    {
                        if(password.Length > 0)
                        {
                            if(database.Length > 0)
                            {

                            }
                            else
                            {
                                if (ok)
                                {
                                    ok = false;
                                    textBox5.BackColor = Color.Red;
                                }
                            }
                        }
                        else
                        {
                            if (ok)
                            {
                                ok = false;
                                textBox4.BackColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        if (ok)
                        {
                            ok = false;
                            textBox3.BackColor = Color.Red;
                        }
                    }
                }
                else
                {
                    if (ok)
                    {
                        ok = false;
                        textBox2.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                if (ok)
                {
                    ok = false;
                    textBox1.BackColor = Color.Red;
                }

            }
            return ok;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (test())
            {
                Settingroot.save(host, user, port, password, database);
            }
        }
   
    }
}
