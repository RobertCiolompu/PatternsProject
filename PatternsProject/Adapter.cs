using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject
{
    class Adapter : IAdapter
    {
        //Adapter pattern - grants access for object named client in Program.cs to method specialRequest defined in Adaptee.cs
        private Adaptee _adaptee = new Adaptee();

        public void request()
        {
            _adaptee.specialRequest();
        } 
    }
}
