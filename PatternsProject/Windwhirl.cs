using System;


namespace PatternsProject
{
    class Windwhirl
    {
        public void GetDamage(int min = 1, int max = 2500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Cerc de foc : Incinerate");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Draws fire toward the enemy, dealing (64.1% of Spell power) Fire damage.");
        }

        public void GetCastTime()
        {
        }
    }
}
