using System;
using System.Collections;
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
    public partial class AddTeam : Form
    {
        DataTable x;
        int type;
        void adding()
        {
            DataTable data = new DataTable();

            data = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTable());
            x = data;
           
            for (int i = 0; i <data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
               
                comboBox1.Items.Add(Convert.ToString(row["Firstname"].ToString()+ "    " + row["Lastname"].ToString()));
              
            }

        }
        public AddTeam(int type, string team="")
        {
            InitializeComponent();
            adding();
            this.type = type;
            if(type == 3)
            {
                textBox1.Text = team;
                textBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == 3)
            {
                if (comboBox1.SelectedIndex >= 0) {
                    //int id = Convert.ToInt32(x.Rows[comboBox1.SelectedIndex].Cells["Id"].Value.ToString());
                    DataRow row = x.Rows[comboBox1.SelectedIndex];

                    int id = Convert.ToInt32(row["Id"].ToString());
                    ProgramITC.ConnectionSql.ExcuteCommand(Team.returnQueryChangeLeaderTeam(textBox1.Text, id)); // hona

                    ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryAddTeam(id, textBox1.Text));
                   ProgramITC.activeTeamUI();
                        }
            }
            else
            {

                if (textBox1.Text != "" && comboBox1.SelectedIndex >= 0)
                {
                    DataRow row = x.Rows[comboBox1.SelectedIndex];

                    int id = Convert.ToInt32(row["Id"].ToString());
                    //  int id = Convert.ToInt32(x.Rows[comboBox1.SelectedIndex].Cells["Id"].Value.ToString());
                      ProgramITC.ConnectionSql.ExcuteCommand(Team.returnQueryAdd(textBox1.Text, id));
                    ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryAddTeam(id, textBox1.Text));
                    ProgramITC.activeTeamUI();
                    ProgramITC.activeAddTeamMembre();
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.BackColor = Color.Red;
                    }
                    if (comboBox1.SelectedIndex <= 0)
                    {
                        comboBox1.BackColor = Color.Red;
                    }
                }
                if (type == 0)
                {
                    ProgramITC.activeTeamUI();
                    ProgramITC.activeAddTeamMembre();

                }
                else
                {
                    ProgramITC.activeAddTeamMembre();
                }
                Close();
            }
            Close();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
