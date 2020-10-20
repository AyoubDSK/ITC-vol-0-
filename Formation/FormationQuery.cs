using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;


namespace ITC__vol_0_.Formation
{
   public static class FormationQuery
    {

        public static string QueryAddFormation(string formation,string desc ,int i,string type, string tm)
        {
            if (type == "membre")
                return "insert into Formation(formationName,formationDescription,IdFormerMembre,timedate) values ('"+formation +"','"+desc +"',"+i+",'"+tm+"');";
            else
                return "insert into Formation(formationName,formationDescription,IdFormerPartenaire,timedate) values ('" + formation + "','" + desc + "'," + i + ",'" + tm + "');";
        
        }

        public static string QueryGetFormaMembre()
        {
            return "select IdFormation,formationName,IdFormerMembre,Firstname,Lastname,temp from Formation inner join Membre where IdFormerMembre=Membre.Id;";
        }
        public static string QueryGetFormaPart()
        {

            return "select IdFormation,formationName,IdFormerPartenaire,Firstname,Lastname,temp from Formation inner join Partenaire where IdFormerPartenaire = Partenaire.IdPartenaire;";
        }

        public static string QueryGetDesc(int id)
        {
            return "selectformationDescription from Formation where IdFormation = " + id + ";";
        }

        public static string QueryDeleteFormation(int id)
        {
            return "delete from Formation where IdFormation =" + id + ";";
        }

    }
}
