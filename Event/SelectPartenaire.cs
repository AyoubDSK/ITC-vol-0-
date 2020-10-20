using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Event
{
    public partial class SelectPartenaire : Form
    {
        string name="";
        public SelectPartenaire(string nm)
        {
            InitializeComponent();
            DataTable data = ProgramITC.ConnectionSql.ReturnVal(Partenaire.PartenaireQuery.QueryGetTable());
            dataGridView1.DataSource = data;
            name = nm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = " baliz .. reflesh !! ";
            ddPartenaire dd = new ddPartenaire();
            dd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(label2.Text.Length != 0)
            {
                label2.Text = "";
            }
            DataTable data = ProgramITC.ConnectionSql.ReturnVal(Partenaire.PartenaireQuery.QueryGetTable());
            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            var selectedRows = dataGridView1.SelectedRows
              .OfType<DataGridViewRow>()
              .Where(row => !row.IsNewRow)
              .ToArray();
            int[] array = new int[selectedRows.Length];

            for (int i = 0; i < selectedRows.Length; i++)
            {
                DataGridViewRow data = selectedRows[i];
                array[i] = Convert.ToInt32(data.Cells["IdPartenaire"].Value.ToString());

            }

            for(int i = 0; i < array.Length; i++)
            {
                ProgramITC.ConnectionSql.ExcuteCommand(Event.EventQuery.QueryAddPArtenaire(name, array[i]));
            }

            label2.Text = "Done !!!";

            dataGridView1.Refresh();
            ProgramITC.activeEvent3();

        }

        private void SelectPartenaire_Load(object sender, EventArgs e)
        {

        }
    }
}
