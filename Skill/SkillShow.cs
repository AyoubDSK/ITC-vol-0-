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
    public partial class AddSkill : Form
    {

        public void reflesh(object o , EventArgs e
            )
        {
            DataTable data = ProgramITC.ConnectionSql.ReturnVal(Skill.SkillQuery.QueryGetTable());
            dataGridView1.DataSource = data;
        }
        public AddSkill()
        {
            InitializeComponent();

            ProgramITC.refleshSkillShow += reflesh;
        }

        private void AddSkill_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
