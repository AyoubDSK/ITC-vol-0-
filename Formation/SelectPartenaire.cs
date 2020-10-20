using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Formation
{
    public partial class SelectPartenaire : Form
    {
        AddFormation send;
        public SelectPartenaire(AddFormation send)
        {
            ProgramITC.refleshPartenaire += chargeView;
            InitializeComponent();
            chargeView(null, EventArgs.Empty);
            this.send = send;
        }
        void chargeView(object o, EventArgs e)
        {
            DataTable data = new DataTable();
            if (ProgramITC.ConnectionSql != null)
            {
                data = ProgramITC.ConnectionSql.ReturnVal(Partenaire.PartenaireQuery.QueryGetTable());
                dataGridView1.DataSource = data;

             
            }
        }

        private void SelectPartenaire_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {

                //shoce

                int id;
                string x = dataGridView1.Rows[index].Cells.ToString();
                id = Convert.ToInt32(x);

                send.saveformateur(id, EventArgs.Empty);



                //query

            }
            else
            {
                MessageBox.Show("select one of items");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add partenaire 
            Event.ddPartenaire n = new Event.ddPartenaire();
            n.Show();
           
        }
        int index = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }

        }
    }
}
