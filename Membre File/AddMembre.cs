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
    public partial class AddMembre : Form
    {
        public AddMembre()
        {
            InitializeComponent();
        }

        private void addMembre(string FirstName,string LastName,string Dep,string grad,string Email)
        {
            ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryAdd(FirstName, LastName, Dep, Email));
        }

        private bool testing(char x)
        {

            switch (x)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                    case '8':
                case '9':
                    case '0' : return false;
                    break;

                default: return true;


            }
        }

        private bool test()
        {
            textBox1.BackColor = Color.White;
            this.FirstName.BackColor = Color.White;
            this.LastName.BackColor = Color.White;
            
            string FirstName, LastName, Dep, Email;

            FirstName = this.FirstName.Text;
            LastName = this.LastName.Text;
            Dep = this.Dep.Text;

            Email = this.Email.Text;
            bool dd = true;
            if(textBox1.Text == "membre" || textBox1.Text == "president" || textBox1.Text == "vice president" || textBox1.Text == "leader team")
            {
                dd = true;
            }
            else
            {
                textBox1.BackColor = Color.Red; gradd.BackColor = Color.Red;
                gradd.Text += " write lik that";
                dd = false;
            }


            if(FirstName != "" && LastName !="" && Dep != "")
            {
                bool x = true, y=true;
                for(int j = 0; j < FirstName.Length; j++)
                {
                    if (!testing(FirstName[j]))
                    {
                        x = testing(FirstName[j]);
                        j = FirstName.Length;

                        
                    }
                }
                if(!x) this.FirstName.BackColor = Color.Red;
                for (int j = 0; j < LastName.Length; j++)
                {
                    if (!testing(LastName[j]))
                    {
                        y = testing(FirstName[j]); j = LastName.Length;
                    }
                }

                if(!y) this.LastName.BackColor = Color.Red; 


                return x && y &&dd;

            }
            else { return false; }


            return true;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, Dep,grad, Email;

            FirstName = this.FirstName.Text;
            LastName = this.LastName.Text;
            Dep = this.Dep.Text;
            grad = this.gradd.Text;

            Email = this.Email.Text;
            if (test())
            {
                addMembre(FirstName, LastName, Dep,grad, Email);

                this.FirstName.Text = "";
                this.LastName.Text = "";
                this.Dep.Text = "";
                this.Email.Text = "";
                this.gradd.Text = ""; 
            }

        }

        private bool testColor()
        {
            return FirstName.BackColor != Color.Red && LastName.BackColor != Color.Red;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
            NextButton_Click(this,EventArgs.Empty);

            ProgramITC.activeMembreReflesh();
            if(testColor())
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
