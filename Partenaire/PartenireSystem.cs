using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_.Partenaire
{
   public static  class PartenireSystem
    {
     public  static List<int> IdSkill;

        public static List<int> IdSkillP;

        public static int IdSkill2(int i)
        {
            return IdSkillP[i];
        }

        public static int Idskill(int i)
        {
            return IdSkill[i];
        }
        public static void Zero()
        {
            IdSkill = new List<int>();
        }
    }
}
