// <copyright file="Methods.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Methods
{
    using System;

    /// <summary>
    /// Class for examples
    /// </summary>
    public class Methods
    {
        /// <summary>
        /// Test different methods 
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Calculate triangle area: ");
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            // Console.WriteLine(CalculateTriangleArea(3, -9, 5));
            Console.WriteLine();

            Console.WriteLine("Show the name of digit: ");
            int number = 7;
            Console.WriteLine("digit {0} => name {1}", number, GiveNameOfDigit(number));
            Console.WriteLine();

            Console.WriteLine("Find max number in sequence:");
            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(FindMaxNumber(5, 8, 9));
            Console.WriteLine();

            Console.WriteLine("Print number: ");
            PrintFormattedNumber(1.3, 'f');
            PrintFormattedNumber(0.75, '%');
            PrintFormattedNumber(2.30, 'r');
            //PrintFormattedNumber(2.30, 's');
            Console.WriteLine();

            Console.WriteLine("Calculate distance:");
            bool horizontal = CheckIsHorizonral(-1, 2.5);
            bool vertical = CheckIsVertical(3, 3);
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal => {0}", horizontal);
            Console.WriteLine("Vertical => {0}", vertical);
            Console.WriteLine();

            Console.WriteLine("Student example: ");
            
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1983";
            
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1988";
            
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        /// <summary>
        /// Calculate triangle area calculate by Heron`s formula.
        /// </summary>
        /// <param name="siteA">Site "a" of triangle.</param>
        /// <param name="siteB">Site "b" of triangle.</param>
        /// <param name="siteC">Site "c" of triangle.</param>
        /// <returns>Value of triangle area.</returns>
        public static double CalculateTriangleArea(double siteA, double siteB, double siteC)
        {
            if (siteA <= 0 || siteB <= 0 || siteC <= 0)
            {
                throw new ArgumentException(String.Format("Sites have to be positive! You input: {0}, {1}, {2}", siteA, siteB, siteC));
            }
           
            double semiPerimeter = (siteA + siteB + siteC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - siteA) * (semiPerimeter - siteB) * (semiPerimeter - siteC));
            
            return area;
        }

        /// <summary>
        /// Return name of digit or invalid number.
        /// </summary>
        /// <param name="number">Digit which name is searching.</param>
        /// <returns>String value of name of digit.</returns>
        public static string GiveNameOfDigit(int number)
        {
            string nameOfDigit = string.Empty;
            
            switch (number)
            {
                case 0:
                    nameOfDigit = "zero";
                    break;
                case 1:
                    nameOfDigit = "one";
                    break;
                case 2:
                    nameOfDigit = "two";
                    break;
                case 3:
                    nameOfDigit = "three";
                    break;
                case 4:
                    nameOfDigit = "four";
                    break;
                case 5:
                    nameOfDigit = "five";
                    break;
                case 6:
                    nameOfDigit = "six";
                    break;
                case 7:
                    nameOfDigit = "seven";
                    break;
                case 8:
                    nameOfDigit = "eight";
                    break;
                case 9:
                    nameOfDigit = "nine";
                    break;
                default:
                    nameOfDigit = "Invalid number";
                    break;
            }

            return nameOfDigit;
        }

        /// <summary>
        /// Find max number from given sequence of elements
        /// </summary>
        /// <param name="elements">sequence of numbers</param>
        /// <returns>max number</returns>
        public static int FindMaxNumber(params int[] elements)
        {
            int elementsLength = elements.Length;

            if (elements == null || elementsLength == 0)
            {
                throw new ArgumentException("Sequence of elements can not be empty!");
            }

            int maxNumber = int.MinValue;
            for (int i = 1; i < elementsLength; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        /// <summary>
        /// Print on console number which is in specific format
        /// </summary>
        /// <param name="number">value of number</param>
        /// <param name="format">character for formatting</param>
        public static void PrintFormattedNumber(object number, char format)
        {
            switch (format)
            {
                case 'f':
                    Console.WriteLine("{0:f2}", number);
                    break;
                case 'r':
                    Console.WriteLine("{0,8}", number);
                    break;
                case '%':
                    Console.WriteLine("{0:p0}", number);
                    break;
                default:
                    throw new ArgumentException("Input character for formating number is not correct!");
            }
        }

        /// <summary>
        /// Calculate distance between two points.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <returns>Distance between 2 points.</returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = 0;
            double distanceOfX = (x2 - x1) * (x2 - x1);
            double distanceOfY = (y2 - y1) * (y2 - y1);
            distance = Math.Sqrt(distanceOfX + distanceOfY);

            return distance;
        }

        /// <summary>
        /// Check is line a horizontal.
        /// </summary>
        /// <param name="y1">Y coordinate of first point.</param>
        /// <param name="y2">Y coordinate of second point.</param>
        /// <returns>True if is horizontal or false.</returns>
        public static bool CheckIsHorizonral(double y1, double y2)
        {
            bool isHorizontal = (y1 == y2);
            
            return isHorizontal; 
        }

        /// <summary>
        /// Check is line a vertical.
        /// </summary>
        /// <param name="x1">X coordinate of first point.</param>
        /// <param name="x2">X coordinate of second point.</param>
        /// <returns>True if is vertical or false.</returns>
        public static bool CheckIsVertical(double x1, double x2)
        {
            bool isVertical = (x1 == x2);
            
            return isVertical;
        }
    }
}
