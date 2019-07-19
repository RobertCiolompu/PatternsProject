using System;

namespace PatternsProject
{
    class FirstTalentSet
    {
        private Attack _attack;
        private Boost _boost;
        private Heal _heal;
        private BrutalAttack _brutalAttack;
        private Windwhirl _windwhirl;
        private Frostbolt _frostbolt;
        private IceRain _iceRain;
        public FirstTalentSet()
        {
            _attack = new Attack();
            _boost = new Boost();
            _heal = new Heal();
            _brutalAttack = new BrutalAttack();
            _windwhirl = new Windwhirl();
            _frostbolt = new Frostbolt();
            _iceRain = new IceRain();
        }


        public void GetRetribution()
        {
            Console.WriteLine("Method Attack");
            _attack.GetDamageAttack();
            _attack.GetAttackDefinition();
            _attack.GetAttackCastTime();

            Console.WriteLine("Method Boost");
            _boost.GetBoostDefinition();
            _boost.GetBoostCastTime();

            Console.WriteLine("Method Heal");
            _heal.GetHolly();
            _heal.GetDefinition();
            _heal.GetEffect();
            _heal.GetCooldown();
            _heal.GetCastTime();
        }

        public void GetArms()
        {
            Console.WriteLine("Method Attack");
            _attack.GetDamageAttack();
            _attack.GetAttackDefinition();
            _attack.GetAttackCastTime();

            Console.WriteLine("Method BrutalAttack");
            _brutalAttack.GetDamageAttack();
            _brutalAttack.GetAttackDefinition();
            _brutalAttack.GetAttackCastTime();
            
            Console.WriteLine("Method Windwhirl");
            _windwhirl.GetDamage();
            _windwhirl.GetDefinition();
            _windwhirl.GetEffect();
            _windwhirl.GetCooldown();
            _windwhirl.GetCastTime();
        }
        public void GetFrost()
        {
            Console.WriteLine("Method FrostBolt");
            _frostbolt.GetDamage();
            _frostbolt.GetDefinition();
            _frostbolt.GetEffect();
            _frostbolt.GetCooldown();
            _frostbolt.GetCastTime();

            Console.WriteLine("Method Ice Rain");
            _iceRain.GetDamage();
            _iceRain.GetDefinition();
            _iceRain.GetEffect();
            _iceRain.GetCooldown();
            _iceRain.GetCastTime();

            Console.WriteLine("Method Boost");
            _boost.GetBoostDefinition();
            _boost.GetBoostCastTime();
        }
    }
}
