using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_
{
    static class MembreClass
    {

        public static string QuryAddEmail(int id,string Email)
        {
            return "update Membre  set Email = '" + Email + "' where Id=" + id + ";";
        }
        public static string QueryAddPhone(int id,string Phone)
        {
            return "update Membre  set Phone ='" + Phone + "' where Id=" + id + ";";
        }
        public static string QueryDelete(int id)
        {
            return " delete from Membre  where Id =" + id + ";";
        }
        public static string QueryAdd(string firstname, string lastname, string dep,string Grad, string email = "")
        {

            return "insert  into  Membre(FirstName,LastName,dep,grad,email) values ('" + firstname + "' , '" + lastname + "','" + dep + "','"+Grad+"',' "+ email + "');";
       
        }

        public static string QueryGetIDFRLS(int i)
        {
            return "select Id,Firstname,Lastname from Membre where Id=" + i + ";";
        }
        public static string QueryGetTable()
        {
            return "select * from Membre;";
        }

        public static string QueryUpdate(int id, string email, string num) // add email numberphone
        {
           return
                "update Membre set email = " + email + " , Phone =" + num + "where Id=" + id;
        }

        public static string QueryUpdate(int id, string num)// add numbure phone
        {
         return   "update Membre set Phone =" + num + "where Id=" + id;
        }

        public static string QueryUpdate(int id, string email, int y = 0) // add email only
        {
           return  "update Membre set email = " + email + "where Id=" + id;
        }

        public static string QueryAddTeam(int Id, string TeamName)
        {
         return    "update Membre set Teamname = '" + TeamName+"'where Id="+Id+" ;";

        }

        public static string QueryGetTableWithId(int id)
        {
         return
                " select * from Membre where Id = " +id +" ;";

        }

        public static string QueryGetTableWithFirstname(string FirstName)
        {
            return "select * from Membre where FirstName = '"+FirstName+"';"  ;
        }

        public static string QueryGetTableWithLastName(string LastName)
        {
            return "select * from Membre where LastName =  '" + LastName + "';";
        }

        public static string QueryGetTableWithDepartment(string dep)
        {
            return " select * from  Membre where dep='" + dep + "';";
        }

        public static string QueryGetTableWithTeamName(string TeamName)
        {
            return " select * from Membre where Teamname='" + TeamName + "';";
        }




        /// <summary>
        /// 
        /// </summary>
        /// Emaillll
        /// <returns></returns>

        public static string QueryGetEmailWithId(int id)
        {
            return
                   " select Email from Membre where Id = " + id + " ;";

        }

        public static string QueryGetEmailWithFirstname(string FirstName)
        {
            return "select Email from Membre where FirstName = '" + FirstName + "';";
        }

        public static string QueryGetEmailWithLastName(string LastName)
        {
            return "select Email from Membre where LastName =  '" + LastName + "';";
        }


        public static string QueryGetEmailWithDepartment(string dep)
        {
            return " select Email from  Membre where dep='" + dep + "';";
        }

        public static string QueryGetEmailWithTeamName(string TeamName)
        {
            return " select Email from Membre where Teamname='" + TeamName + "';";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NumPhone"></param>
        /// <returns></returns>
        public static string QueryGetPhoneWithId(int id)
        {
            return
                   " select Phone from Membre where Id = " + id + " ;";

        }

        public static string QueryGetPhoneWithFirstname(string FirstName)
        {
            return "select Phone from Membre where FirstName = '" + FirstName + "';";
        }

        public static string QueryGetPhoneWithLastName(string LastName)
        {
            return "select Phone from Membre where LastName =  '" + LastName + "';";
        }

        public static string QueryGetPhoneWithDepartment(string dep)
        {
            return " select Phone from  Membre where dep='" + dep + "';";
        }

        public static string QueryGetPhoneWithTeamName(string TeamName)
        {
            return " select Phone from Membre where Teamname='" + TeamName + "';";
        }



    }
}
