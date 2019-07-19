using System;


namespace PatternsProject
{
    class Incinerate
    {
        public void GetDamage(int min = 200, int max = 1500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Generates 2 Soul Shard Fragments and an additional 1 on critical strikes");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Draws fire toward the enemy, dealing (64.1% of Spell power) Fire damage.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 2 sec");
        }
    }
}
