using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject
{
    class Specialization
    {
        FirstTalentSet firstTalentSet = new FirstTalentSet();
        SecondTalentSet secondTalentSet = new SecondTalentSet();

        public void getMethod()
        {
            Console.WriteLine("SpecialRequest");
        }

        public void getWarriorTalents()
        {

        }

        public void getMageTalents()
        {

        }
    }
}
