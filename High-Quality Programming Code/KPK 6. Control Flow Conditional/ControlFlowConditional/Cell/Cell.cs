// <copyright file="Cell.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Cell
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class Cell check is cell is visited
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// Declared constants
        /// </summary>
        public const int MIN_X = 0;
        public const int MAX_X = 800;

        public const int MIN_Y = 100;
        public const int MAX_Y = 1000;

        /// <summary>
        /// Implement logic of program
        /// </summary>
        public static void Main()
        {
            // Exercise 2 part 2
            int x = 60;
            int y = 90;

            bool isXInRange = (MIN_X <= x) && (x <= MAX_X);
            bool isYInRange = (MIN_Y <= y) && (y <= MAX_Y);    
            bool shouldVisitCell = true;

            if (isXInRange && isYInRange && shouldVisitCell)
            {
                VisitCell();
                Console.WriteLine("Successfully visited cell");
            }
            else
            {
                Console.WriteLine("Not visited cell");
            }
        }

        /// <summary>
        /// Void method with implement logic when cell is visited successfully
        /// </summary>
        public static void VisitCell()
        {
            // TODO: VisitCell()
        }
    }
}
