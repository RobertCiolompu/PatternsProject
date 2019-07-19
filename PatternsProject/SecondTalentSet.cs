using System;

namespace PatternsProject
{
    class SecondTalentSet
    {
        private Attack _attack;
        private MinorHeal _minorheal;
        private MajorHeal _majorheal;
        private ThrowWeapon _throweapon;
        private Charge _charge;
        private FireBall _fireball;
        private Incinerate _incinerate;


        public SecondTalentSet()
        {
            _attack = new Attack();
            _minorheal = new MinorHeal();
            _majorheal = new MajorHeal();
            _throweapon = new ThrowWeapon();
            _charge = new Charge();
            _fireball = new FireBall();
            _incinerate = new Incinerate();
        }
        public void GetHoly()
        {
            Console.WriteLine("Method Minor Heal");
            _minorheal.GetMinorHeal();
            _minorheal.GetDefinition();
            _minorheal.GetCooldown();
            _minorheal.GetCastTime();

            Console.WriteLine("Method Major Heal");
            _majorheal.GetMajorHeal();
            _minorheal.GetDefinition();
            _minorheal.GetCooldown();
            _minorheal.GetCastTime();
        }
        public void GetFury()
        {
            Console.WriteLine("Method Attack");
            _attack.GetDamageAttack();
            _attack.GetAttackDefinition();
            _attack.GetAttackCastTime();

            Console.WriteLine("Method ThrowWeapon");
            _throweapon.GetDamage();
            _throweapon.GetDefinition();
            _throweapon.GetCooldown();
            _throweapon.GetCastTime();

            Console.WriteLine("Method Charge");
            _charge.GetDamage();
            _charge.GetDefinition();
            _charge.GetEffect();
            _charge.GetCooldown();
            _charge.GetCastTime();
        }
        public void GetFire()
        {
            Console.WriteLine("Method Fireball");
            _fireball.GetDamage();
            _fireball.GetDefinition();
            _fireball.GetEffect();
            _fireball.GetCooldown();
            _fireball.GetCastTime();

            Console.WriteLine("Method Incinerate");
            _incinerate.GetDamage();
            _incinerate.GetDefinition();
            _incinerate.GetEffect();
            _incinerate.GetCooldown();
            _incinerate.GetCastTime();
        }
    }
}
