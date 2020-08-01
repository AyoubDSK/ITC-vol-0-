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
    public partial class AddTeamMembre : Form
    {

        int[] Ids;

      void  reflesh(object n , EventArgs e)
        
        {
            DataTable dat = new DataTable();
            dat = ProgramITC.ConnectionSql.ReturnVal(Team.QueryGetTeam());

            //   for (int i = 0; i < dat.Rows.Count; i++)

            for (int i = 0; i < dat.Rows.Count; i++)
            {
                DataRow data = dat.Rows[i];
                comboBox1.Items.Add(data["TeamName"].ToString());
            }
            if (dat.Rows.Count == 0)
            {

            }

        }
        
        public AddTeamMembre(int[] Ids)
        {
            InitializeComponent();
           
            this.Ids = Ids;
            if(Ids.Length > 0)
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = "NO ONE ";
            }

            DataTable ne = new DataTable();
          
            for (int i = 0; i < Ids.Length; i=i+1)
            {
                ne = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTableWithId(Ids[i]));
                DataRow row = ne.Rows[0
                    ];

                label2.Text += Convert.ToString(row["Id"].ToString() ) +"  "+ row["FirstName"].ToString() + "  "+ row["LastName"].ToString() +"  \n   " ;

              
            }
            reflesh(null,EventArgs.Empty);


            ProgramITC.refleshAddTeamMembre += reflesh;
        
        }

        private void AddTeamMembre_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTeam team = new AddTeam(2);
            team.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                for(int i=0;i<Ids.Length;i++)
                ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryAddTeam(Ids[i], comboBox1.SelectedItem.ToString()));
                ProgramITC.activeMembreReflesh();
            }


            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
