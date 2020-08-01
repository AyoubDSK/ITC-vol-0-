using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Event
{
    public partial class AddOrgan : Form
    {
        int index = -1;
        string Event;
        public AddOrgan(string Event)
        {
            InitializeComponent();
            this.Event = Event;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.BackgroundColor == Color.DarkRed)
            {
                dataGridView1.BackgroundColor = Color.White;
            }
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                if(textBox1.Text.Length > 0)
                {
                    // query
                    int id =Convert.ToInt32( dataGridView1.Rows[index].Cells["Id"].Value.ToString());
                  string Q=  EventQuery.QueryAddOrgan(id, textBox1.Text, this.Event);
                    ProgramITC.ConnectionSql.ExcuteCommand(Q);
                    ProgramITC.activeEvent2();
                    

                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
            }
            else
            {
                dataGridView1.BackgroundColor = Color.DarkRed;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.BackColor == Color.Red)
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
