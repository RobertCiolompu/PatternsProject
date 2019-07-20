using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the index of the desired specialization:\nPaladin : 1\nWarrior : 2\nMage : 3");

            getSpecializationData();
            
            Console.ReadKey();
        }

        public static void getSpecializationData()
        {
            try
            {
                int selectedIndex = Convert.ToInt32(Console.ReadLine());

                switch (selectedIndex)
                {
                    case 1:
                        IPaladinSpecialization paladin = new SpecializationAdapter();
                        paladin.retrievePaladinInfo();
                        break;
                    case 2:
                        IWarriorSpecialization warrior = new SpecializationAdapter();
                        warrior.retrieveWarriorInfo();
                        break;
                    case 3:
                        IMageSpecialization mage = new SpecializationAdapter();
                        mage.retrieveMageInfo();
                        break;
                    default:
                        Console.WriteLine($"An unexpected value ({selectedIndex}). Please try again.");
                        getSpecializationData();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input not in a valid format. Please try again.");
                getSpecializationData();
            }

        }
    }
}
