using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_.Event
{
  public static class EventQuery
    {

        public static string QueryChangejob(int id, string ev, string job){
            return " update Organ set job ='" + job + "' where organId=" + id + " and Eventname='" + ev + "';";
        }
        public static string QueryAddPArtenaire(string eventname, int PArtId)
        {
            return " insert into EventPartenaire(Eventname,IdPartenaire) values ('" + eventname + "','" + PArtId
               + "');";
        }
        public static string QueryAddOrgan(int id,string job,string Event)
        {
            return "insert into organ(organId,Eventname,job) values (" + id + ",'" + Event + "','" + job + "');";

        }
        public static string QueryAddEvent(string name,string desc,int id)
        {
            return " insert into Event(EventName,describetion,EventChargeId) values ('"+name+"','"+desc +"'," + id +");";
        }

       public static string returnQueryGetTable()
        {
            return "select EventName from Event;";
        }

        public static string retunQueryGetDescreb(string Eventname)
        {
            return "select describetion from Event where EventName='" + Eventname + "';";
        }
       
        public static string returnQueryGetTableOrgan(string name)
        {
            // query abmrique
            return " select Id,Firstname,Lastname,job from membre inner join organ where organ.Eventname = '" + name + "';"; 
            // code double 
        }

      
        public static string returnQueryGetTablePar(string name)
        {
            return "select IdPrtenaire,Firstname,Lastname from Partenaire inner join EventPartenaire where EventPartenaire = '" + name + "';" ;// code double 
            //
        }
        // " select Id,Firstname,Lastname,job from membre inner join organ where organ.Eventname = '"+name + "';";
        // "select IdPrtenaire,Firstname,Lastname,from Partenaire inner join EventPartenaire where EventPartenaire = '"+name+"';";

       
    }
}
