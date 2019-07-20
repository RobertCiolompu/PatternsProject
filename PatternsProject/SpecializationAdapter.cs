using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject
{
    class SpecializationAdapter : Specialization, IPaladinSpecialization, IWarriorSpecialization, IMageSpecialization
    {
        //Adapter pattern - grants access for object named client in Program.cs to method specialRequest defined in Adaptee.cs

        public void retrievePaladinInfo()
        {
            getPaladinInformation();
        } 

        public void retrieveWarriorInfo()
        {
            getWarriorInformation();
        }

        public void retrieveMageInfo()
        {
            getMageInformation();
        }
    }
}
