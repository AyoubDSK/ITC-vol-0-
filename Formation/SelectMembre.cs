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
    public partial class SelectMembre : Form
    {
        AddFormation send;
        public SelectMembre(AddFormation send)
        {
            this.send = send;
            InitializeComponent();
            chrageitems(null, EventArgs.Empty);
        }

        void chrageitems(object o , EventArgs e)
        {
            DataTable dat = new DataTable();
            dat = ProgramITC.ConnectionSql.ReturnVal(MembreClass.QueryGetTable());
            dataGridView1.DataSource = dat;
        }

        int index = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMembre d = new AddMembre();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                // Query plz

                int id;
                string x = dataGridView1.Rows[index].Cells.ToString();
                id = Convert.ToInt32(x);

                send.saveformateur(id, EventArgs.Empty);


            }
            else
            {
                MessageBox.Show("select membre baliz");
            }
        }
    }
}
