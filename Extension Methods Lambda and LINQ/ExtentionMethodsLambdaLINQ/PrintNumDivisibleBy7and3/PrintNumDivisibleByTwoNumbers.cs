using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumDivisibleByTwoNumbers
{
    static void Main()
    {
        /*6.	Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
         * Use the built-in extension methods and lambda expressions. 
         * Rewrite the same with LINQ.*/

        int[] numbers = { 4, 6, 7, 21, 67, 63, 89, 441, 147 };
        var result = numbers.Where(num => (num % 7) == 0 && (num % 3) == 0).ToArray();

        Console.WriteLine("Numbers from array");
        Print(numbers);

        Console.WriteLine("Numbers which are divisible by 7 and 3 (with lambda)");
        Print(result);

        Console.WriteLine("Numbers which are divisible by 7 and 3 (with LINQ)");
        int[] resultLint = FindNumberDivisible(numbers);
        Print(resultLint);
    }

    public static int[] FindNumberDivisible(int[] arrayOfNumbers)
    {
        int firstDiv = 7;
        int secondDiv = 3;
        var result = from number in arrayOfNumbers
                     where ((number % firstDiv) == 0 && (number % secondDiv) == 0)
                     select number;
        return result.ToArray();
    }

    public static void Print(int[] num)
    {
        foreach (var number in num)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}

