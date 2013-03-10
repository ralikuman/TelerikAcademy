using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class TimerExample
    {
        static void Main()
        {
            /*7.	Using delegates write a class Timer that has can execute certain method at each t seconds.*/
            Console.Write("Enter seconds: ");
            int secondsOfDelay = int.Parse(Console.ReadLine());
            if (secondsOfDelay < 0)
            {
                throw new ArgumentOutOfRangeException(String.Format("Seconds must be positive. Enter value: {0}", secondsOfDelay));
            }
            else
            {
                TimerDelegate test = new TimerDelegate(Timer.PrintDate);
                test(secondsOfDelay);
            }
            Console.WriteLine("Main thread exits.");       
        }
    }
}
