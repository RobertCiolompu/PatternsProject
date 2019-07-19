using System;


namespace PatternsProject
{
    class MajorHeal
    {
        public void GetMajorHeal(int min = 3000, int max = 405500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 10 min");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Calls upon Holy magic to heal an ally.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: Instant");
        }
    }
}
