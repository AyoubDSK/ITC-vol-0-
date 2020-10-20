using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ITC__vol_0_.Event
{
    public partial class ddPartenaire : Form
    {
        private const int V = 1;

        public ddPartenaire()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private bool testing(char x)
        {

            if (x == '1' || x == '2' || x == '3' || x == '4' || x == '5' || x == '6' || x == '7' || x == '8' || x == '9' || x == '0')
            {
                return false;
            }
            else
                return true;
        }

        public bool test()
        {
            bool x = true, y = true;
            if (textBox1.Text.Length <= 0)
            {
                textBox1.BackColor = Color.Red;

                x = false;
            }
            else
            {
                if (textBox2.Text.Length <= 0)
                {
                    textBox2.BackColor = Color.Red;
                    return false;

                }
                else
                {
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (!testing(textBox1.Text[i]))
                        {
                            x = false; i = textBox1.Text.Length;
                            textBox1.BackColor = Color.Red;

                            break;

                        }
                    }
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (!testing(textBox2.Text[i]))
                        {
                            y = false; i = textBox2.Text.Length;
                            textBox2.BackColor = Color.Red;

                            break;

                        }
                    }
                }

            }
            return x && y;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Skill.AddSkill add = new Skill.AddSkill(1);
            //  AddSkill add = new AddSkill(V);
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test())
            {


                string query = Partenaire.PartenaireQuery.QueryAddPartenaire(textBox1.Text, textBox2.Text, textBox3.Text);
                ProgramITC.ConnectionSql.ExcuteCommand(query);
                string idpQuery = Partenaire.PartenaireQuery.QueryGetId(textBox3.Text);
                DataTable x = ProgramITC.ConnectionSql.ReturnVal(idpQuery);
                int id = Convert.ToInt32(x.Rows[0]["IdPartenaire"].ToString());
                int Id2 = -1;
                if (Partenaire.PartenireSystem.IdSkill != null)
                {
                    for (int i = 0; i < Partenaire.PartenireSystem.IdSkill.Count; i++)
                        //  string query1 = Skill.SkillQuery.QueryAddPArtenaireSkill(id, Partenaire.PartenireSystem.IdSkill[i]);
                        Id2 = Partenaire.PartenireSystem.Idskill(i);

                    string q = Skill.SkillQuery.QueryAddPArtenaireSkill(id, Id2);


                }
                ProgramITC.ActivePArtenaire();

            }
        }

        private void ddPartenaire_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
