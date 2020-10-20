using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ITC__vol_0_
{
    public partial class Global : Form
    {

      //  MembreUI MembreUI = new MembreUI();
       // TeamUI TeamUI = new TeamUI();
       // Partenaire.PartenaireUI PartenaireUI = new Partenaire.PartenaireUI();
        void charge()
        {
            /*
            // membre
            this.MembreUI.Location = new System.Drawing.Point(260, 50);
            this.MembreUI.Name = "MembreUI";
            this.MembreUI.Size = new System.Drawing.Size(469, 376);
            this.MembreUI.TabIndex = 5;
            this.MembreUI.Visible = false;
            // fin membre
            //TeamUI
            this.TeamUI.Location = new System.Drawing.Point(260, 50);
            this.TeamUI.Name = "TeamUI";
            this.TeamUI.Size = new System.Drawing.Size(469, 376);
            this.TeamUI.TabIndex = 6;
            this.TeamUI.Visible = false;
            //fin team
            //Partenaire 
            this.PartenaireUI.Location = new System.Drawing.Point(260, 50);
            this.PartenaireUI.Name = "PartenaireUI";
            this.PartenaireUI.Size = new System.Drawing.Size(469, 376);
            this.PartenaireUI.Visible = false;
            //fin partenaire
            */
        }
        public Global()
        {
            this.Location = new Point(0, 0);
            InitializeComponent();
            FormHising();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHising();
        }

        void FormHising()
        {
            membreUI2.Visible = false;
            eventUI2.Visible = false;
            partenaireUI2.Visible = false;
            teamUI2.Visible = false;
            formationUI1.Visible = false;
        }

        private void membre1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramITC.ConnectionSql.CloseConnection();
            Close();
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // membre button
            FormHising();
            membreUI2.Visible = true;



        }

        private void win1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // team button
            FormHising();
            //            teamUI2.Visibl =true;
            teamUI2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // event button
            FormHising();
            eventUI2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // parteanire button
            FormHising();
            partenaireUI2.Visible = true;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            // formation button
            FormHising();
            formationUI1.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //setting

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormHising();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
