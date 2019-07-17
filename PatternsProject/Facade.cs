using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternUsage
{
    class Facade
    {
        private SubSystem1 _one;
        private SubSystem2 _two;
        private SubSystem3 _three;
        private SubSystem4 _four;

        public Facade()
        {
            _one = new SubSystem1();
            _two = new SubSystem2();
            _three = new SubSystem3();
            _four = new SubSystem4();
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
