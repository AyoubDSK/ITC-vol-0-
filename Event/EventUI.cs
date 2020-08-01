using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Event
{
    public partial class EventUI : UserControl
    {
        int index;
        string EvInd;
   //     DataTable Table;
        public void refleshEvent(object o , EventArgs e)
        {
            DataTable data = new DataTable();
            data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.returnQueryGetTable());
            dataGridView1.DataSource = data;
           

        }
        public void reflechEvent2(object o,EventArgs e)
        {
            refleshdesc();
            if(index >= 0)
            {
                DataTable data = new DataTable();

            string s=    dataGridView1.Rows[index].Cells["EventName"].Value.ToString();

                //    data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.returnQueryGetTableOrgan(s));

                data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.returnQueryGetTableOrgan(s));
                dataGridView2.DataSource = data;
                
            }
        }
       
        public void refleshEvent3(object o , EventArgs e)
        {
            if (index >= 0)
            {
                DataTable data = new DataTable();
                string s = dataGridView1.Rows[index].Cells["EventName"].Value.ToString();
                data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.returnQueryGetTablePar(s));
                dataGridView3.DataSource = data;

            }
        }

       

        public void refleshdesc()
        {
            if (index >= 0)
            {
                DataTable data = new DataTable();
                string name = dataGridView1.Rows[index].Cells["EventName"].Value.ToString();
                data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.retunQueryGetDescreb(name));
                Describe_Text.Text = data.Rows[0]["describetion"].ToString();
            }
        }
        public EventUI()
        {
            InitializeComponent();

            refleshEvent(null,EventArgs.Empty);
            ProgramITC.refleshEvent1 += refleshEvent;
            ProgramITC.refleshEvent2 += reflechEvent2;
            ProgramITC.refleshEvent3 += refleshEvent3;
           

        }

        private void EventUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                index = e.RowIndex;
                string x = dataGridView1.Rows[index].Cells["EventName"].Value.ToString();
                DataTable data = new DataTable();
                data = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.retunQueryGetDescreb(x));
                Describe_Text.Text = data.Rows[0]["describetion"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                reflechEvent2(null,EventArgs.Empty);
                refleshEvent3(null,EventArgs.Empty);
                //describe
                string ind = dataGridView1.Rows[index].Cells["Eventname"].Value.ToString() ;
                EvInd = ind;
                DataTable x = new DataTable();
                x = ProgramITC.ConnectionSql.ReturnVal(Event.EventQuery.retunQueryGetDescreb(ind));

                Describe_Text.Text = x.Rows[0]["describetion"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent add = new AddEvent();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  add organi
            if (index >= 0) {
                string ev = dataGridView1.Rows[index].Cells["Eventname"].Value.ToString();
             AddOrgan add = new AddOrgan(ev);
                add.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //add partenaire to event
            if(index >= 0)
            {
                string ev = dataGridView1.Rows[index].Cells["Eventname"].Value.ToString();
                SelectPartenaire select = new SelectPartenaire(ev);
                select.Show();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(indM >= 0)
            {
                // done

                string f = dataGridView1.Rows[indM].Cells["Firstname"].Value.ToString();
                string l = dataGridView1.Rows[indM].Cells["Lastname"].Value.ToString();
                string ind = dataGridView1.Rows[indM].Cells["Id"].Value.ToString();
                ChangeJob d = new ChangeJob(f,l,Convert.ToInt32(ind),EvInd);
            }
        }

        int indM = -1;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // index

            if (e.RowIndex >= 0)
            {
                indM = e.RowIndex;
            }
        }
    }
}
