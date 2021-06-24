using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    interface ITelephones
    {
        public string Manufacturer { get; }
        public Type Keypad { get; }
        public void MakeCalls();
        public void ReceiveCalls();             

    }
}
