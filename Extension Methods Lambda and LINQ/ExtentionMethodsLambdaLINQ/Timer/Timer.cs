using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    //declaration of delegete with 1 parametar
    public delegate void TimerDelegate(int sleep);

    public class Timer
    {
        //method which print date 5 time in each X seconds(given like parametar)
        public static void PrintDate(int sleep)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(sleep);
            }
        }
    }
}
