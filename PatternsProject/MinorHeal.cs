using System;


namespace PatternsProject
{
    class MinorHeal
    {
        public void GetMinorHeal(int min = 6000, int max = 15000)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 5 min");
        }

        public void GetDefinition()
        {
            Console.WriteLine("An efficient spell that heals an ally for (175 % of Spell power).");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: Instant");
        }
    }
}
