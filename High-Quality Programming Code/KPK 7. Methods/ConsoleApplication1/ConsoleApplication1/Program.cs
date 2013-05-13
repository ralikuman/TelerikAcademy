using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 6; i++)
            {
                Console.Write(i.ToString() + " | ");
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(pr(poleto[i, j]) + " ");
                }
                Console.WriteLine("| ");
            }
        }
    }
}
