using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_.Skill
{
   public static class SkillQuery
    {

        public static string QueryGetTable()
        {
            return "select * form Skill;"
;        }

        public static string QuerySetValue(string describtion)
        {
            return " insert into Skill(description) values('" + describtion + "');";
        }

        public static string QueryGetID(string descrition)
        {
            return "select IdSkill from Skill where describtion='" + descrition + "' ;";
        }

        static public string QueryAddPArtenaireSkill(int IdPartenaire,int idSkill)
        {
            return "insert into PartenaireSkill(IdSkill,IdPartenaire) values (" + idSkill + "," + IdPartenaire + ");";
        }
    }
}
