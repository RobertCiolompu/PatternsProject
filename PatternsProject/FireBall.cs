using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProject
{
    class FireBall
    {
        public int GetDamage(int min = 1, int max = 2500)  //metoda damage
        {
            Random rand = new Random();
            int damageresult = rand.Next(min, max);

            return damageresult;
        }

        public string GetEffect(string effect)
        {
            Console.WriteLine("Cerc de foc : Incinerate");
            return effect;
        }

        public string GetCooldown(string second)
        {
            Console.WriteLine("Cooldown time 2 sec");
            return second;
        }

        public string GetDefinition(string deff)
        {
            Console.WriteLine("Draws fire toward the enemy, dealing (64.1% of Spell power) Fire damage.");
            return deff;
        }

        public string GetCastTime(string cast)
        {
            return cast;
        }
    }
}
