using System;


namespace PatternsProject
{
    class FireBall
    {
        public void GetDamage(int min = 2250, int max = 10000)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Throws a fiery ball to an enemy");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time 4 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Throws a fiery ball that causes (59% of Spell power) Fire damage.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 1 sec");
        }
    }
}
