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

namespace ITC__vol_0_
{
    public partial class MembreUI : UserControl
    {

       public void reflesh(object o,EventArgs e)
        {
            data = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTable());

            dataGridView1.DataSource = data;
        }
        DataTable data = new DataTable();
        int index_selected=-1;
        public MembreUI()
        {
            InitializeComponent();
        

            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // ConnectionSql d = new ConnectionSql("localhost", "3306", "12345", "root", "itcommunity");
            //  d.Connecte();

            //data= d.ReturnVal("SELECT * FROM Membre;");

            //dataGridView1.DataSource = data;
            reflesh(null, EventArgs.Empty);
          ProgramITC.refleshMembre += reflesh;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                index_selected = e.RowIndex;
                //label1.Text = Convert.ToString(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMembre a = new AddMembre();
            a.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
                 .OfType<DataGridViewRow>()
                 .Where(row => !row.IsNewRow)
                 .ToArray();
            int[] array = new int[selectedRows.Length];

            for (int i = 0; i < selectedRows.Length; i++)
            {
                DataGridViewRow data = selectedRows[i];
                array[i] = Convert.ToInt32(data.Cells["Id"].Value.ToString());
                ProgramITC.ConnectionSql.ExcuteCommand(MembreClass.QueryDelete(array[i]));

            }
            reflesh(null,EventArgs.Empty);
            dataGridView1.ClearSelection();

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
                array[i] = Convert.ToInt32(data.Cells["Id"].Value.ToString());

            }
            // foreach (var row in selectedRows)
            //    dataGridView1.Rows.Remove(row);
            AddTeamMembre teamMembre = new AddTeamMembre(array);
            teamMembre.Show();
            dataGridView1.ClearSelection();

        }

        private void Membre_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index_selected = e.RowIndex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index_selected >= 0)
            {
                string Firstname = dataGridView1.Rows[index_selected].Cells["FirstName"].Value.ToString();
                string Lastname = dataGridView1.Rows[index_selected].Cells["LastName"].Value.ToString();
                int id = Convert.ToInt32(dataGridView1.Rows[index_selected].Cells["Id"].Value.ToString());
                AddPhone n = new AddPhone(Firstname, Lastname, id);
                n.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index_selected >= 0)
            {

                string Firstname = dataGridView1.Rows[index_selected].Cells["FirstName"].Value.ToString();
                string Lastname = dataGridView1.Rows[index_selected].Cells["LastName"].Value.ToString();
                int id =Convert.ToInt32( dataGridView1.Rows[index_selected].Cells["Id"].Value.ToString());
                Membre_File.AddEmail n = new Membre_File.AddEmail(Firstname, Lastname, id);
                n.Show();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code kbiir
        }
    }
}
