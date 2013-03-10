using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ExtensionIEnumerable
{
    /*2.	Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
* sum, product, min, max, average.*/

    /* convert ro decimal in first 3 methods and return decimal value*/

    public static decimal Sum<T>(this IEnumerable<T> enumeration)
    {
        if (enumeration.Count() <= 0)
        {
            throw new ArgumentException(String.Format("Empthy enumeration"));
        }
        else
        {
            decimal sum = 0M;
            foreach (var item in enumeration)
            {
                sum = sum + Convert.ToDecimal(item);
            }
            return sum;
        }
    }

    public static decimal Average<T>(this IEnumerable<T> enumeration)
    {
        if (enumeration.Count() <= 0)
        {
            throw new ArgumentException(String.Format("Empthy enumeration"));
        }
        else
        {
            decimal sum = 0M;
            decimal average = 0M;
            int count = 0;
            foreach (var item in enumeration)
            {
                sum = sum + Convert.ToDecimal(item);
                count++;
            }
            average = sum / count;
            return average;
        }
    }

    public static decimal Product<T>(this IEnumerable<T> enumeration)
    {
        if (enumeration.Count() <= 0)
        {
            throw new ArgumentException(String.Format("Empthy enumeration"));
        }
        else
        {
            decimal product = 1M;
            foreach (var item in enumeration)
            {
                product = product * Convert.ToDecimal(item);
            }
            return product;
        }
    }

    public static T Min<T>(this IEnumerable<T> enumeration)
        where T : IComparable<T>
    {
        if (enumeration.Count() <= 0)
        {
            throw new ArgumentException(String.Format("Empthy enumeration"));
        }
        else
        {
            dynamic minValue = enumeration.First();
            foreach (var item in enumeration)
            {
                if (minValue.CompareTo(item) > 0)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
    }

    public static T Max<T>(this IEnumerable<T> enumeration)
        where T : IComparable<T>
    {
        if (enumeration.Count() <= 0)
        {
            throw new ArgumentException(String.Format("Empthy enumeration"));
        }
        else
        {
            dynamic maxValue = enumeration.First();
            foreach (var item in enumeration)
            {
                if (maxValue.CompareTo(item) < 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
    }
}

