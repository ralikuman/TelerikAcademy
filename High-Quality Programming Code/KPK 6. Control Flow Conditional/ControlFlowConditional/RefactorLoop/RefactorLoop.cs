// <copyright file="RefactorLoop.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace RefactorLoop
{
    using System;
    using System.Linq;

    /// <summary>
    /// Refactor loop 
    /// </summary>
    public class RefactorLoop
    {
        public const int EXPECTED_VALUE = 333;
        public const int BREAK_INDEX = 666;

        /// <summary>
        /// Refactor loop
        /// </summary>
        public static void Main()
        {
            int[] array = { 8, 90, 8, 78, 5, 67, 3, 5, 7, 333, 8 };
            int arrayLenght = array.Length;
            int foundIndex = 0;

            for (int index = 0; index < arrayLenght; index++)
            {
                Console.WriteLine(array[index]);
                if (index % 10 == 0)
                {
                    if (array[index] == EXPECTED_VALUE)
                    {
                        foundIndex = BREAK_INDEX;
                        break;
                    }
                }
            }

            if (foundIndex == BREAK_INDEX)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
