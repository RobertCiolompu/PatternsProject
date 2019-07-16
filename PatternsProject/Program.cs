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
            IAdapter client = new Adapter();
            client.request();

            Console.ReadKey();
        }
    }
}
