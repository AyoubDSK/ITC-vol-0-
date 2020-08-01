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
    public partial class AddEvent : Form
    {
        DataTable Data;

        public void charge()
        {

            DataTable ne = new DataTable();

            Data = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTable());
            ne = Data;
            for(int i=0; i< Data.Rows.Count; i++) { 
                DataRow row = ne.Rows[i];

                // label2.Text += Convert.ToString(row["Id"].ToString()) + "  " + row["FirstName"].ToString() + "  " + row["LastName"].ToString() + "  \n   ";
                string x = Convert.ToString(row["Id"].ToString()) + "  " + row["FirstName"].ToString() + "  " + row["LastName"].ToString();
                comboBox1.Items.Add(x);

            }
        }
        public AddEvent()
        {
            InitializeComponent();
            charge();
            label4.Text = "150 char (0)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.BackColor == Color.Red)
            {
                textBox2.BackColor = Color.White;
            }
            if( textBox2.Text.Length == 150)
            {
                textBox2.Enabled = false;

            }
            else
            {
                label4.Text = "150 char  (" + textBox2.Text.Length + ")"; 
            }
        }

        public int getid(int index)
        {
         return Convert.ToInt32(   Data.Rows[index]["Id"].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text.Length <= 150 && comboBox1.SelectedIndex >= 0
                )
            {
                // valide
                ProgramITC.ConnectionSql.ExcuteCommand(Event.EventQuery.QueryAddEvent(textBox1.Text, textBox2.Text, getid(comboBox1.SelectedIndex)));
                ProgramITC.activeEvent1();Close();
                
            }
            else
            {
                if(textBox2.Text.Length > 150)
                {
                    textBox2.BackColor = Color.Red;
                }
                if(textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Red;
                }
                if(comboBox1.SelectedIndex < 0)
                {
                    label5.Text += "! select Item !";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.BackColor == Color.Red)
            {
                textBox1.BackColor = Color.White;
            }
        }
    }
}
