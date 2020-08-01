using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_
{
    public partial class TeamUI : UserControl
    {

       void  reflesh(object x, EventArgs e)
        {
            DataTable data = new DataTable();
            data = ProgramITC.ConnectionSql.ReturnVal(Team.QueryGetTeam());
            dataGridView1.DataSource = data;
            ProgramITC.activeMembreReflesh();
        }
        public TeamUI()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reflesh(null, EventArgs.Empty);
            ProgramITC.refleshTeamUI += reflesh;

        }

        private void TeamUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeam team = new AddTeam(1);
            team.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = index_selected;
            string tam = dataGridView1.Rows[id].Cells["Teamname"].Value.ToString();
            AddTeam add = new AddTeam(3, tam);
            add.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index_selected >= 0)
            {
                DataTable data = new DataTable();

                string teamname = dataGridView1.Rows[index_selected].Cells["Teamname"].Value.ToString();
                data = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTableWithTeamName(teamname));
                dataGridView2.DataSource = data;

            }
        }

        int index_selected;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                index_selected = e.RowIndex;
                //label1.Text = Convert.ToString(e.RowIndex);
            }
        }
    }
}
