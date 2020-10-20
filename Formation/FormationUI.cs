using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ITC__vol_0_.Formation
{
    public partial class FormationUI : UserControl
    {
        DataTable d;
     //   DataTable desc;
        void inich()
        {
            DataTable r = new DataTable();
            r.Columns.Add("Id");
            r.Columns.Add("Formation");
            r.Columns.Add("Former Id");
            r.Columns.Add("Firstname");
            r.Columns.Add("Lastname");
            r.Columns.Add("Type(M/P)");
            d = r;

        }
        void ini(object o , EventArgs e)
        {
            reflesh(null,EventArgs.Empty);
           
        }
        public FormationUI()
        {
            InitializeComponent();
            inich();
            ini(null, EventArgs.Empty);
        }

        void reflesh(object o , EventArgs e)
        {
            // code sql;

            DataTable dat, dat2;
            dat = ProgramITC.ConnectionSql.ReturnVal(FormationQuery.QueryGetFormaMembre());
            dat2 = ProgramITC.ConnectionSql.ReturnVal(FormationQuery.QueryGetFormaPart());

            for (int i = 0; i < dat.Rows.Count; i++)
            {
                DataRow x = d.NewRow();
                x["IdFormation"] = dat.Rows[i]["IdFormation"].ToString();
                x["Formation"] = dat.Rows[i]["formationName"].ToString();
                x["Former Id"] = dat.Rows[i]["IdFormerMembre"].ToString();
                x["Firstname"] = dat.Rows[i]["Firstname"].ToString();
                x["Lastname"] = dat.Rows[i]["Lastename"].ToString();
                x["Type(M/P)"] = "Membre";
                d.Rows.Add(x);

            }
            for (int i = 0; i < dat2.Rows.Count; i++)
            {
                DataRow x = d.NewRow();
                x["IdFormation"] = dat2.Rows[i]["IdFormation"].ToString();
                x["Formation"] = dat2.Rows[i]["formationName"].ToString();
                x["Former Id"] = dat2.Rows[i]["IdFormerPartenaire"].ToString();
                x["Firstname"] = dat2.Rows[i]["Firstname"].ToString();
                x["Lastname"] = dat2.Rows[i]["Lastename"].ToString();
                x["Type(M/P)"] = "Partenaire";
                d.Rows.Add(x);
            }



        }
        private void FormationUI_Load(object sender, EventArgs e)
        {
            // get

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // info 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add

            AddFormation s = new AddFormation();
            s.Show();
        }

        string  chargeindex(int i)
        {
            int id;
            id =Convert.ToInt32( dataGridView1.Rows[i].Cells["Id"].Value.ToString());
            string des ;
              DataTable s=  ProgramITC.ConnectionSql.ReturnVal(FormationQuery.QueryGetDesc(id));
            des = s.Rows[0]["formationDescription"].ToString();
            return des;
        }
        int index =-1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex>=0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                index = e.RowIndex;
                NameForma.Text = dataGridView1.Rows[e.RowIndex].Cells["Formation"].Value.ToString();
                Firstname.Text = dataGridView1.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                Lastname.Text = dataGridView1.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
                Type.Text = dataGridView1.Rows[e.RowIndex].Cells["Type(M/P)"].Value.ToString();
                Describe.Text = chargeindex(e.RowIndex);
              
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["Id"].Value.ToString());
                ProgramITC.ConnectionSql.ExcuteCommand(FormationQuery.QueryDeleteFormation(id));
                reflesh(null, EventArgs.Empty);
            }
        }
    }
}
