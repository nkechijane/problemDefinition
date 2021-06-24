using System;

namespace ProblemDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            WiredPhone WiredPhone1 = new WiredPhone();
            WiredPhone1.ConnectToPower();
            WiredPhone1.MakeCalls();
            WiredPhone1.ReceiveCalls();

            MobilePhone firstMobilePhone = new MobilePhone();
            firstMobilePhone.SendText();
            firstMobilePhone.ReceiveText();
            firstMobilePhone.MakeCalls();
            firstMobilePhone.ReceiveCalls();

            SmartPhone smartPhone1 = new SmartPhone();
            smartPhone1.ReceiveCalls();
            smartPhone1.Email();
            smartPhone1.MultimediaFunctions();
            smartPhone1.BrowseInternet();


        }

    }
}
