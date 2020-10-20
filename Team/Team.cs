using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITC__vol_0_
{
    static public class Team
    {

        public static string  QueryGetTeam()
        {
            return " select Team.Teamname,Firstname,Lastname from Team inner join Membre where TeamleaderId= Id ;";
        }
      public static string returnQueryAdd(string TeamName,int Id)
        {
            return " insert into Team(TeamName,TeamLeaderId) value ('"+TeamName + "',"+Id +");";
        }

        public static string returnQueryDelete(string Teamname)
        {
            return "delete form Team where Teamname = '" + Teamname + "';";
        }

        public static string returnQueryChangeLeaderTeam(string Teamname,int Id)
        {
            return "update Team set TeamleaderId = " + Id + " where Teamname = '" + Teamname +"';";
        }


    }
}