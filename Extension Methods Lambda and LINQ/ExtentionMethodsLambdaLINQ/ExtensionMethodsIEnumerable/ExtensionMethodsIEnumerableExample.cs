using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsIEnumerable
{
    class ExtensionMethodsIEnumerableExample
    {
        /*2.	Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
         * sum, product, min, max, average.*/
        static void Main()
        {
            List<int> listInt = new List<int> { 1, 2, 3, 4, 5 };
            double[] testDouble = new[] { 4.5, 6.0, 5.7, 34.7 }; //sum = 50.9 

            Console.WriteLine("---list <int>---");
            Console.WriteLine("Sum: {0}", listInt.Sum());
            Console.WriteLine("Average: {0}", listInt.Average());
            Console.WriteLine("Product: {0}", listInt.Product());
            Console.WriteLine("Minimum: {0}", listInt.Min());
            Console.WriteLine("Minimum: {0}", listInt.Max());

            Console.WriteLine("---double---");
            Console.WriteLine("Sum: {0}", testDouble.Sum());
            Console.WriteLine("Average: {0}", testDouble.Average());
            Console.WriteLine("Product: {0}", testDouble.Product());
            Console.WriteLine("Minimum: {0}", testDouble.Min());
            Console.WriteLine("Minimum: {0}", testDouble.Max());

            List<int> testEmpty = new List<int>();
            Console.WriteLine(testEmpty.Sum()); //return error when enumaration is empty, does not work about array(return 0)
        }
    }
}
