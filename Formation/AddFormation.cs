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
    public partial class AddFormation : Form
    {
        public AddFormation()
        {
            InitializeComponent();
        }


        int idPM =-1;// id of former

        bool test()
        {
          string form=  textBox1.Text;//Fomation
          string desc=  textBox2.Text;//describtion
            //3 ,4 ,5 for date
            bool ok = true;

            //<code> 

            int y =0, m=0, d=0, h=0, min=0;
            try
            {
                y = Convert.ToInt32(year.Text);
                
            
            }
            catch (Exception exx)
            {
                year.BackColor =  Color.Red; ok=false;
            }
            try
            {
                m = Convert.ToInt32(mounth.Text);


            }
            catch (Exception exx)
            {
                mounth.BackColor = Color.Red; ok=false;
            }
            try
            {
                d = Convert.ToInt32(day.Text);


            }
            catch (Exception exx)
            {
                day.BackColor = Color.Red; ok=false;
            }
            try
            {
                h = Convert.ToInt32(Hr.Text);


            }
            catch (Exception exx)
            {
                Hr.BackColor = Color.Red; ok=false;
            }
            try
            {
                min = Convert.ToInt32(Min.Text);


            }
            catch (Exception exx)
            {
                Min.BackColor = Color.Red; ok=false;
            }

            if (ok == false)
            {
                return false;
            }
            else
            {

            fd = new DateTime(y, m, d, h, min, 00);

                // <code/>

                return ok;
            }

        }

        DateTime fd;

        private void button4_Click(object sender, EventArgs e)
        {
            // clic ok 
            if(test())
            {
                string dd= fd.Year +"-"+ fd.Month+"-"+fd.Day+" "+fd.Hour+":"+fd.Minute+":00";
                string form = textBox1.Text;//Fomation
                string desc = textBox2.Text;//describtion
                
                if(idPM!=-1 && types!= null)
                {
                  
                        ProgramITC.ConnectionSql.ExcuteCommand(FormationQuery.QueryAddFormation(form, desc, idPM, types, dd));
                  
                }

            }
           


            // save data


        }



        private void button2_Click(object sender, EventArgs e)
        {
            // press key membre adding 
            types = "membre";

            SelectMembre select = new SelectMembre(this);
            select.Show();

        }



        string types = null;// part or membre


        private void button3_Click(object sender, EventArgs e)
        {
            types = "part";

            SelectPartenaire select = new SelectPartenaire(this);
            select.Show();


            // clic key partenaire
        }

        public void saveformateur(object o, EventArgs e)
        {

            int id = Convert.ToInt32(o);


            idPM = id;

        
          
            
        }
    }
}
