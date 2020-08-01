using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_.Partenaire
{
    class PartenaireQuery
    {
        public static string QueryGetPartenaire(int id)
        {
            return "select * from partenaire where IdPartenaire = " + id + ";";
        }
       public static string QueryGetTable()
        {
           return " select * from partenaire;";
               
        }
        public static string QueryGetTableFL()
        {
            return "select IdPatenaire,Firstname,Lastname  from partenaire;";
        }

        public static string QueryGetId(string Email)
        {
            return "select IdPartenaire from partenaire;";
        }

        public static string QueryAddPartenaire(string Firstname,string Lastname,string Email)
        {
            return "insert into Partenaire(Firstname,Lastname,email) values ('" + Firstname + "','" + Lastname + "','" + Email + "');";
        }
    }
}
