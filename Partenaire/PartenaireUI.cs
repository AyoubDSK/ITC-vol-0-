using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Partenaire
{
    public partial class PartenaireUI : UserControl
    {


        int i =-1;
        
        void chargeView(object o , EventArgs e)
        {
            DataTable data = new DataTable()   ;
            if (ProgramITC.ConnectionSql != null)
            {
                data = ProgramITC.ConnectionSql.ReturnVal(Partenaire.PartenaireQuery.QueryGetTable());
                dataGridView1.DataSource = data;

                Firstname.Text = "";
                Lastname.Text = "";
                Email.Text = "";
            }
        }
        

        void chargeinfo(object o , EventArgs e)
        {

            if (i >= 0 && dataGridView1.Rows.Count> i)
            {
                int index = i;

                int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["IdPartenaire"].Value.ToString());

                DataTable dd = ProgramITC.ConnectionSql.ReturnVal(Partenaire.PartenaireQuery.QueryGetPartenaire(id));
                try
                {
                    Firstname.Text = dd.Rows[0]["Firstname"].ToString();
                    Lastname.Text = dd.Rows[0]["Lastname"].ToString();
                    Email.Text = dd.Rows[0]["Email"].ToString();
                  
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
            }
        }

       
        public PartenaireUI()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = true;
            ProgramITC.refleshPartenaire += chargeView;
            chargeView(null,EventArgs.Empty);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                //code for show partenaire info ,,, after selecte
                chargeinfo(null, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("select Partenaire la bghit za3ma !!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          //      i = e.ColumnIndex;
            //    label7.Text = Convert.ToString(i);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ddPartenaire dd = new ddPartenaire();

            //C:\Users\hp\source\repos\ITC (vol 0)\Partenaire\AddPartenaire.cs
            Event.ddPartenaire dd = new Event.ddPartenaire();
            dd.Show();
        }

        private void PartenaireUI_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Skill.SkillChose x = new Skill.SkillChose(3);
            // add in data base
            x.Show();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(i >= 0)
            {
                int d =Convert.ToInt32( dataGridView1.Rows[i].Cells["IdPartenaire"].Value.ToString());
                ProgramITC.ConnectionSql.ExcuteCommand("delete from Partenaire where IdPartenaire=" +d+ ";");
                chargeView(null,EventArgs.Empty);
                i = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                label7.Text = Convert.ToString(e.RowIndex);
                i = e.RowIndex;
            }
        }
    }
}
