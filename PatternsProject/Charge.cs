using System;


namespace PatternsProject
{
    class Charge
    {
        public void GetDamage(int min = 500, int max = 1000)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Charge to an enemy.");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Charge to an enemy, dealing(11.466 % of Attack power) Physical damage, rooting it for 1 sec");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 3 sec");
        }
    }
}
