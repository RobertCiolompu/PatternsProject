using System;


namespace PatternsProject
{
    class Frostbolt
    {
        public void GetDamage(int min = 300, int max = 500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetEffect()
        {
            Console.WriteLine("Slowing movement speed.");
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time: 1 sec.");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Launches a bolt of frost at the enemy, causing(51.1 % of Spell power) Frost damage and slowing movement speed by 50 % for 8 sec.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 2 sec.");
        }
    }
}
