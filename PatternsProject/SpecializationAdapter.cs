using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject
{
    class SpecializationAdapter : ISpecialization
    {
        //Adapter pattern - grants access for object named client in Program.cs to method specialRequest defined in Adaptee.cs
        private Specialization _specialization = new Specialization();

        public void getSpecializationInfo()
        {
            _specialization.getMethod();
        } 
    }
}
