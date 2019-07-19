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

        protected void getPaladinInformation()
        {
            Console.WriteLine("Retribution Specialization:");
            firstTalentSet.GetRetribution();
            Console.WriteLine("\nHoly Specialization:");
            secondTalentSet.GetHoly();
            
        }

        protected void getWarriorInformation()
        {
            Console.WriteLine("Arms Specialization:");
            firstTalentSet.GetArms();
            Console.WriteLine("\nFury Specialization:");
            secondTalentSet.GetFury();
            
        }

        protected void getMageInformation()
        {
            Console.WriteLine("Frost Specialization:");
            firstTalentSet.GetFrost();
            Console.WriteLine("\nFire Specialization:");
            secondTalentSet.GetFire();
            
        }
    }
}
