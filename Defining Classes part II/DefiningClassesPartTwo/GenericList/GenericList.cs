using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

/*5.	Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, 
 * inserting element at given position, clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.*/

/*6.	Implement auto-grow functionality: when the internal array is full, 
 * create a new array of double size and move all elements to it.*/

/*7.	Create generic methods Min<T>() and Max<T>() for finding the minimal 
 * and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.*/


namespace GenericList
{
    public class GenericList<T>
       where T : new()
    {
        //fields
        private T[] myArray;
        private int arraySize;
        private int count = 0;

        //properties
        public int ArraySize
        {
            get
            {
                return this.arraySize;
            }
            set
            {
                if (value > 0)
                {
                    this.arraySize = value;
                }
                else
                {
                    throw new Exception("Invalid size of array {0}");
                }
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //constructor 
        public GenericList(int size)
        {
            this.arraySize = size;
            myArray = new T[size];
        }

        //METHODS
        //adding element
        public void Add(T element)
        {
            if (count >= myArray.Length)
            {
                this.AutoGrowArray();
                //throw new IndexOutOfRangeException(String.Format( "The size is {0} and you can not add more elements!", myArray.Length));
            }
            this.myArray[count] = element;
            count++;
        }

        //accessing element by index 

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > arraySize)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
                }
                T result = myArray[index];
                return result;
            }
        }

        //removing element by index
        public void DeleteByIndex(int index)
        {
            if (index >= arraySize)
            {
                throw new IndexOutOfRangeException(String.Format("Index is not correct {0}", index));
            }
            else if (index >= 0 || index <= arraySize - 1)
            {
                this.arraySize--;
                Array.Copy(this.myArray, index + 1, this.myArray, index, this.arraySize - index);
                this.myArray[this.arraySize] = default(T);
                this.arraySize++;
            }
        }

        // inserting element at given position
        public void InsertAtPosition(int index, T value)
        {
            if (index >= arraySize)
            {
                AutoGrowArray();
                //throw new IndexOutOfRangeException(String.Format("Index is not correct {0}", index));
            }

            if (index >= 0 || index <= arraySize - 1)
            {
                try
                {
                    myArray[index] = value;
                }
                catch
                {
                    throw new IndexOutOfRangeException(String.Format("Index is not correct {0}", index));
                }
            }
        }

        //clearing the list
        public void Clear()
        {
            count = 0;
            myArray = new T[arraySize];
        }

        //finding element by its value
        //return -1 if the is no value 
        //if found value return the index
        public int FindElementByValue(T elementValue)
        {
            int searchIndex = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (elementValue.Equals(myArray[i]))
                {
                    return searchIndex = i;
                }
            }
            return searchIndex;
        }

        //ToString()
        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            foreach (var item in myArray)
            {
                print.Append(item);
                print.Append(" ");
            }
            return print.ToString(); ;
        }

        //ex.6 auto-grow
        private void AutoGrowArray()
        {
            T[] tempArray = new T[this.ArraySize * 2];
            for (int i = 0; i < myArray.Length; i++)
            {
                tempArray[i] = this.myArray[i];
            }
            this.myArray = tempArray;
            this.ArraySize = this.ArraySize * 2;
        }
    }
}