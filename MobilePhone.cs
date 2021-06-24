using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    public class MobilePhone : Phones
    {
        internal Type Batteries { get; set; }
        public Type Keypad { get; }

        public void SendText() 
        {
            Console.WriteLine($"Send text messages to other mobile phones or services \n");

        }

        public void ReceiveText()
        {
            Console.WriteLine($"Recieve text messages from other mobile phones or services \n");
        }
        

        
    }
}
