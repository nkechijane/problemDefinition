using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    class WiredPhone : Phones
    {
        public void ConnectToPower() 
        {
            Console.WriteLine($"The wired phone is constantly connected to a power source\n");
        }


    }
}
