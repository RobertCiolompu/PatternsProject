using System;


namespace PatternsProject
{
    class ThrowWeapon
    {
        public void GetDamage(int min = 1, int max = 500)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetCooldown()
        {
            Console.WriteLine("Cooldown time 2 sec");
        }

        public void GetDefinition()
        {
            Console.WriteLine("Hurl a thrown weapon at the target.");
        }

        public void GetCastTime()
        {
            Console.WriteLine("Cast time: 0.5 sec");
        }
    }
}
