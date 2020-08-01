using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC__vol_0_.Skill
{
    public partial class SkillChose : Form
    {
        int x=0;
        int idPart;
        public SkillChose(int x,int id)
        {
            InitializeComponent();
            this.x = x;

            this.idPart = id;
        }
        public SkillChose(int x)
        {
            InitializeComponent();
            // x== 0 partenaire skill
            // x==1 membre skill
            // x==3 patenaire update
            this.x = x;
            Partenaire.PartenireSystem.Zero();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
               .OfType<DataGridViewRow>()
               .Where(row => !row.IsNewRow)
               .ToArray();
            int[] array = new int[selectedRows.Length];

            if(x == 0)
            {
                // change skill id foe partenaire skill system
                for(int i=0;i<array.Length;i++)
                Partenaire.PartenireSystem.IdSkill.Add(array[i]);
            }
            else
            {
                if(x == 1){
                    // change skill id for skill membre system

                }
                else
                {
                    if(x== 3)
                    {
                        // add to partenaire
                        for (int i = 0; i < array.Length; i++)
                        {string Query =
                            Skill.SkillQuery.QueryAddPArtenaireSkill(idPart, array[i]);

                            ProgramITC.ConnectionSql.ExcuteCommand(Query);
                        }


                    }
                }
            }
            
        }
    }
}
