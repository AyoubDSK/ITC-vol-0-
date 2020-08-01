using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Skill
{
    public partial class AddSkill : Form
    {
        int o;
        public AddSkill(int i=0)
        {
            InitializeComponent();
            if (i == 0)
            {
                this.o = 0;
            }
            else
                this.o = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 150)
            {
                textBox1.Enabled = false;
            }
        }

        public void save()
        {
            ProgramITC.ConnectionSql.ExcuteCommand(Skill.SkillQuery.QuerySetValue(textBox1.Text));
            ProgramITC.activeSkillShow();
            if (o == 1)
            {
                DataTable data = ProgramITC.ConnectionSql.ReturnVal(Skill.SkillQuery.QueryGetID(textBox1.Text));
                Partenaire.PartenireSystem.IdSkill.Add(Convert.ToInt32( data.Rows[0]["IdSkill"].ToString()));

            }
            else
            {
                if (o == 2)
                {
                    // secand
                    DataTable data = ProgramITC.ConnectionSql.ReturnVal(Skill.SkillQuery.QueryGetID(textBox1.Text));
                    Partenaire.PartenireSystem.IdSkillP.Add(Convert.ToInt32(data.Rows[0]["IdSkill"].ToString()));


                }
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            save();
            Close();

           
        }

        private void AddSkill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            save();
            textBox1.Text = "";
        }
    }
}
