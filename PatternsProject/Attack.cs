using System;


namespace PatternsProject
{
    class Attack
    {
        public void GetDamageAttack(int min = 1, int max = 100)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetAttackDefinition()
        {
            Console.WriteLine("Starts combat by attacking a target with a melee weapon.(Low Damage)");
        }

        public void GetAttackCastTime()
        {
            Console.WriteLine("Cast time: Instant");
        }

    }
}

