using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    class SmartPhone : Phones
    {
        private int IMEI
        {
            get => IMEI;
        }
        public void Email() 
        {
            Console.WriteLine($"Receives and Send Emails \n");
        }
        public void BrowseInternet() 
        {
            Console.WriteLine($"Surfing the internet for informations," +
                " \n including downloading and uploading of contents \n");

        }

        public void MultimediaFunctions() 
        {
            Console.WriteLine($"Has Multimedia functions" + " \n Snap pictures and records videos, " +
                "\n and also share resources with other \n media devices including \n other social media platforms \n");
        }
    }
}
