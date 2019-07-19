using System;


namespace PatternsProject
{
    class Heal
    {
        public void GetHolly(int min = 150, int max = 2500)
        {
            Random rand = new Random();
            int holyresult= rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Holy Light from Sky");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("An efficient spell, healing a friendly target for (150% of Spell power).");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 5 sec");
        }
    }
}
