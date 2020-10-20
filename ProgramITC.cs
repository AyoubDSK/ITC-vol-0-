using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITC__vol_0_
{
    public static class ProgramITC
    {
        public static string host, user, port, pass, database;
        public static ConnectionSql ConnectionSql = new ConnectionSql();
        public static event EventHandler refleshMembre;//after adding membre
        public static event EventHandler refleshAddTeamMembre;// adding team event  

        public static event EventHandler refleshTeamUI;
        public static event EventHandler refleshEvent1;
        public static event EventHandler refleshEvent2;
        public static event EventHandler refleshEvent3;
        public static event EventHandler refleshSkillShow;
        public static event EventHandler refleshPartenaire;
        public static void activeTeamUI()
        {
            EventHandler x
                 = refleshTeamUI;
            if( x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeAddTeamMembre()
        {
            EventHandler x = refleshAddTeamMembre;
            if(x!= null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeMembreReflesh()

        {
            EventHandler x = refleshMembre;
            if (x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeEvent1()
        {

            EventHandler x = refleshEvent1;
            if (x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeEvent2()
        {

            EventHandler x = refleshEvent2;
            if (x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeEvent3()
        {

            EventHandler x = refleshEvent3;
            if (x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void activeSkillShow()
        {
            EventHandler x = refleshSkillShow;
            if(x != null)
            {
                x(null, EventArgs.Empty);
            }
        }
        public static void ActivePArtenaire()
        {
            EventHandler x = refleshPartenaire;
            if(x != null)
            {
                x(null, EventArgs.Empty);
            }
        }



    }
}