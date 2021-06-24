using ProblemDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    public abstract class Phones : ITelephones
    {
        public string Manufacturer { get => Manufacturer; }       
        public Type Keypad { get; }
        public void MakeCalls()
        {
            Console.WriteLine($"making calls to different lines and locations \n");
        }
        public void ReceiveCalls() 
        {
            Console.WriteLine($"Receiving calls from different lines and locations \n");
        }


    }
}
