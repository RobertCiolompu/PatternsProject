using System;


namespace PatternsProject
{
    class BrutalAttack
    {
        public void GetDamageAttack(int min = 50, int max = 200)
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);
        }

        public void GetAttackDefinition()
        {
            Console.WriteLine("Starts combat by attacking a target with a melee weapon(High Damage)");
        }

        public void GetAttackCastTime()
        {
            Console.WriteLine("Cast time: Instant");
        }
    }
}
