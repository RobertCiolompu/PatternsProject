using System;


namespace PatternsProject
{
    class IceRain
    {
        public void GetDamage(int min = 500, int max = 2500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Deals 5 Frost damage every 0.5 seconds.");
            Console.WriteLine("Movement speed slowed by 50 %.");
            Console.WriteLine("1 second remaining");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Deals 5 Frost damage every 0.5 sec to all enemies standing within the /nradius of an ice patch on the ground.This effect will persist as long as the target remains in this area.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 8 sec");
        }
    }
}
