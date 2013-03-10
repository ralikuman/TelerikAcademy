using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    /*5.	Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
     * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
     * Implement methods for adding element, accessing element by index, removing element by index, 
     * inserting element at given position, clearing the list, finding element by its value and ToString(). 
     * Check all input parameters to avoid accessing elements at invalid positions.*/
    
    /*6.	Implement auto-grow functionality: when the internal array is full, 
     * create a new array of double size and move all elements to it.*/

    class GenericListExample
    {
        static void Main()
        {
            int size = 5;
            GenericList<int> integerNum = new GenericList<int>(size);

            //adding element
            for (int i = 0; i < integerNum.ArraySize; i++)
            {
                integerNum.Add(i + 5);
            }

            //add size + 1 element to generate error
            //integerNum.Add(135);

            //removing element by index
            integerNum.DeleteByIndex(1);
            Console.WriteLine(integerNum.ToString());

            //insert element
            integerNum.InsertAtPosition(7, 59999);
            Console.WriteLine(integerNum.ToString());

            //clear 
            integerNum.Clear();
            Console.WriteLine(integerNum.ToString());
            integerNum.Add(78);

            //finding element by its value
            integerNum.Add(78);
            integerNum.Add(15);
            integerNum.Add(450);

            Console.WriteLine(integerNum.FindElementByValue(6));
            Console.WriteLine(integerNum.FindElementByValue(78));

            //ToString()
            Console.WriteLine(integerNum.ToString());
        }
    }
}


