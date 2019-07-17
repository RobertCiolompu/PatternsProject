using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternUsage
{
    class Facade
    {
        private Attack _one;
        private Boost _two;
        private Heal _three;
        private MinorHeal _four;

        public Facade()
        {
            _one = new Attack();
            _two = new Boost();
            _three = new Heal();
            _four = new MinorHeal();
        }

        public void methodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.method1();
            _two.method2();
            _four.method4();
            _three.method3();
        }

        public void methodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _one.method1();
            _three.method3();
        }

        public void methodC()
        {
            Console.WriteLine("\nMethodC() ---- ");
            _two.method2();
            _four.method4();
        }
    }
}
