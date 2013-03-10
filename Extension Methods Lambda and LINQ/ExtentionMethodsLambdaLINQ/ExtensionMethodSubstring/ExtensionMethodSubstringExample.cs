using System;
using System.Text;

class ExtensionMethodSubstringExample
{
    static void Main()
    {
        /*1.	Implement an extension method Substring(int index, int length) 
         * for the class StringBuilder that returns new StringBuilder and has the same functionality
         * as Substring in the class String.*/

        StringBuilder test = new StringBuilder();
        test.Append("test");

        //correct cases
        Console.WriteLine("start index: 0 , lenght: 3, result: {0}", test.Substring(0, 3));
        Console.WriteLine("start index: 0 , lenght: 4, result: {0}", test.Substring(0, 4));
        Console.WriteLine("start index: 3 , lenght: 1, result: {0}", test.Substring(3, 1));
        Console.WriteLine("start index: 2 , lenght: 2, result: {0}", test.Substring(2, 2));

        //incorrect cases which generate exception
        //Console.WriteLine("start index: 3 , lenght: 2, result: {0}", test.Substring(3, 2)); //error
        //Console.WriteLine("start index: -4 , lenght: 4, result: {0}", test.Substring(-4, 4)); //error
        //Console.WriteLine("start index: 4 , lenght: -1, result: {0}", test.Substring(4,-1)); //error
        //Console.WriteLine("start index: 4 , lenght: -1, result: {0}", test.Substring(3, -1)); //error
    }
}

