using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void Main()
    {
        int[] testArray = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", testArray));
        SelectionSort(testArray);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", testArray)); // -1, 0, 2, 3, 4, 15, 17, 33

        SelectionSort(new int[0]); //Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(testArray, -1000));
        Console.WriteLine(BinarySearch(testArray, 0));
        Console.WriteLine(BinarySearch(testArray, 17));
        Console.WriteLine(BinarySearch(testArray, 10));
        Console.WriteLine(BinarySearch(testArray, 1000));

        Console.WriteLine(FindMinElementIndex(testArray, 1, 1));
        Console.WriteLine(BinarySearch(testArray, 2, 1, 3)); 
    }

    public static void SelectionSort<T>(T[] array) where T : IComparable<T>
    {
        Debug.Assert(array != null, "Array is null, can not sort null array in this task.");
        
        for (int index = 0; index < array.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(array, index, array.Length - 1);
            Swap(ref array[index], ref array[minElementIndex]);
        }

        for (int index = 0; index < array.Length - 1; index++)
        {
            Debug.Assert(array[index].CompareTo(array[index + 1]) <= 0, "Array is not sort successfully.");
        }
    }

    public static int BinarySearch<T>(T[] array, T value) where T : IComparable<T>
    {
        Debug.Assert(array != null, "Array is null, can not sort null array in this task.");

        for (int index = 0; index < array.Length - 1; index++)
        {
            Debug.Assert(array[index].CompareTo(array[index + 1]) <= 0, "Array is not sort.");
        }

        int indexOfValue = BinarySearch(array, value, 0, array.Length - 1);
        return indexOfValue;
    }

    private static int BinarySearch<T>(T[] array, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(array != null, "Array is null, can not sort null array in this task.");
        for (int index = 0; index < array.Length - 1; index++)
        {
            Debug.Assert(array[index].CompareTo(array[index + 1]) <= 0, "Array is not sort.");
        }
        
        Debug.Assert(startIndex >= 0, "Start index of array have to be positive");
        Debug.Assert(startIndex <= array.Length - 1, "Start index of array have to be smaller thah length");
        Debug.Assert(endIndex >= startIndex, "End index of array have to be bigger or equal to start index");
        Debug.Assert(endIndex <= array.Length - 1, "End index of array have to smaller than length");

        for (int index = 0; index < array.Length - 1; index++)
        {
            Debug.Assert(array[index].CompareTo(array[index + 1]) <= 0, "Array is not sort. First have to sort array");
        }

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (array[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (array[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] array, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(array != null, "Array is null, can not sort null array in this task.");
        Debug.Assert(startIndex >= 0, "Start index of array have to be positive");
        Debug.Assert(startIndex <= array.Length - 1, "Start index of array have to be smaller thah length");
        Debug.Assert(endIndex >= startIndex, "End index of array have to be bigger or equal to start index");
        Debug.Assert(endIndex <= array.Length - 1, "End index of array have to smaller than length");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (array[i].CompareTo(array[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }
}
