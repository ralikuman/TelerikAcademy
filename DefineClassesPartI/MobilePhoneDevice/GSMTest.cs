using System;
using System.Globalization;
using System.Threading;

/*7.	Write a class GSMTest to test the GSM class:
            1.	Create an array of few instances of the GSM class.
            2.	Display the information about the GSMs in the array.
            3.	Display the information about the static property IPhone4S.
*/
namespace MobilePhoneDevice
{
    class GSMTest
    {
        static void Main()
        {
            //the data is fake
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            GSM[] gsms = new GSM[3];

            Display display1 = new Display(4F, "16M");
            Battery battery1 = new Battery(450, 30, BatteryType.NiCd);
            gsms[0] = new GSM("Nokia 808", "Nokia Corporation", 345.00M, "Petar Petrov", battery1, display1);

            Display display2 = new Display(2.5F, "256K");
            Battery battery2 = new Battery(950, 35, BatteryType.LiIon);
            gsms[1] = new GSM("Samsung Ace", "Samsung Group", 545.00M, "Ivan Ivanov", battery2, display2);

            Display display3 = new Display(5.1F, "16M");
            Battery battery3 = new Battery(700, 25, BatteryType.NiMH);
            gsms[2] = new GSM("Motorola", "Motorola Solutions, Inc.", 45.00M, "Vasil Vasilev", battery3, display3);

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }

            //Display the information about the static property IPhone4S.
            GSM.IPhone4S.Owner = "Alis";
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
