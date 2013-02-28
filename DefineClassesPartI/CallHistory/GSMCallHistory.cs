using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*12.	Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        1.	Create an instance of the GSM class.
        2.	Add few calls.
        3.	Display the information about the calls.
        4.	Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        5.	Remove the longest call from the history and calculate the total price again.
        6.	Finally clear the call history and print it.
*/

namespace CallHistoryOfDevice
{
    class GSMCallHistory
    {
        static void Main()
        {
            // Create an instance of the GSM class
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");
            Display display = new Display(2.5F, "256K");
            Battery battery = new Battery(950, 35, BatteryType.LiIon);
            GSM gsmTest = new GSM("Samsung Ace", "Samsung Group", 545.00M, "Ivan Ivanov", battery, display);

            //Add few calls
            DateTime date = DateTime.Now;
            gsmTest.AddCallInHistory(date, "0889909988", 65);
            gsmTest.AddCallInHistory(date.AddHours(1), "0889969988", 25);
            gsmTest.AddCallInHistory(date.AddHours(2), "0883909988", 3600);
            gsmTest.AddCallInHistory(date.AddHours(6.5), "0889969988", 1000);

            //Display the information about the calls.
            Console.WriteLine("Print the call hisory of phone {0}", gsmTest.ModelOfGSM);
            Console.WriteLine(gsmTest.PrintCallHistory());

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history
            //use readonly modificator about pricePerminute
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total price of calls is: {0}", gsmTest.CalcucateTotalPrice(0.37M));

            Console.ForegroundColor = ConsoleColor.Gray;
            //Remove the longest call from the history and calculate the total price again.
            gsmTest.RemoveCallByLongestDuration();
            Console.WriteLine(gsmTest.PrintCallHistory());

            //Finally clear the call history and print it.
            gsmTest.ClearCallHistory();
            Console.WriteLine(gsmTest.PrintCallHistory());
        }
    }
}
