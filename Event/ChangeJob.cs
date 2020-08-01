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
    public partial class ChangeJob : Form
    {

        int id;
        string ev;
        public ChangeJob(string F,string L,int id,string ev)
        {
            InitializeComponent();
            IdL.Text += Convert.ToString(id);
            Firstname.Text += F;
            Lastname.Text += L;
            this.id = id;
            this.ev = ev;
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                // run code
                ProgramITC.ConnectionSql.ExcuteCommand(Event.EventQuery.QueryChangejob(this.id,ev,textBox1.Text));

            }
        }

        private void ChangeJob_Load(object sender, EventArgs e)
        {

        }
    }
}
