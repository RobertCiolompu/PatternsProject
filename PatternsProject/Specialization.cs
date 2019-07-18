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
        private string retribution = "";
        private string holy = "";
        private string arms = "";
        private string fury = "";
        private string frost = "";
        private string fire = "";
        

        protected void getPaladinInformation()
        {
            firstTalentSet.GetRetribution(retribution);
            secondTalentSet.GetHoly(holy);
            Console.WriteLine("Retribution Specialization:\n{0}\n\nHoly Specialization\n{1}",retribution,holy);
        }

        protected void getWarriorInformation()
        {
            firstTalentSet.GetArms(arms);
            secondTalentSet.GetFury(fury);
            Console.WriteLine("Arms Specialization:\n{0}\n\nFury Specialization\n{1}", arms, fury);
        }

        protected void getMageInformation()
        {
            firstTalentSet.GetFrost(frost);
            secondTalentSet.GetFire(fire);
            Console.WriteLine("Frost Specialization:\n{0}\n\nFire Specialization\n{1}", frost, fire);
        }
    }
}
