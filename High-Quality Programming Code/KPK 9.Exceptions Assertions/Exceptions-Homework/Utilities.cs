using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Utilities
{
    public static T[] Subsequence<T>(T[] array, int startIndex, int count)
    {
        if (array == null)
        {
            throw new ArgumentNullException("array", "Array can not be null.");
        }

        if (startIndex > array.Length)
        {
            throw new ArgumentOutOfRangeException("startIndex", "Start index can not be bigger than array`s length.");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "Count can not be less than zero.");
        }

        if (count > (array.Length - startIndex))
        {
            throw new ArgumentOutOfRangeException("count", "Count can not be bigger than array`s length.");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(array[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string stringText, int count)
    {
        if (count > stringText.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Count can not be bigger than stringText`s length.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = stringText.Length - count; i < stringText.Length; i++)
        {
            result.Append(stringText[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 2)
        {
            throw new ArgumentException(string.Format("Number must be bigger than 2. Your input is {0}", number));
        }

        bool isPrime = true;
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }
}
