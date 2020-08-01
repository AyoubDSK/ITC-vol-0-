using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Membre_File
{
    public partial class AddEmail : Form
    {

        public string firstname, lastname;
        int id;
        public AddEmail(string Firstname,string Lastname,int Id)
        {
            this.lastname = Lastname;
            this.firstname = Firstname;
            this.id = Id;
            InitializeComponent();
            label1.Text = Firstname;
            label2.Text = lastname;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QuryAddEmail(id, textBox1.Text));
                ProgramITC.activeMembreReflesh();
            }catch(Exception eeee)
            {
                MessageBox.Show(eeee.Message);
            }
        }
    }
}
