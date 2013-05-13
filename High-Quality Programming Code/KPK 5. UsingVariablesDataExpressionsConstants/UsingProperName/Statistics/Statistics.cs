// <copyright file="Statistics.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Statistics
{
    using System;
    using System.Linq;

    /// <summary>
    /// Print on console maximal, minimal and average data from given array of statistics data
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Print result on console
        /// </summary>
        public static void Main()
        {
            double[] statisticsDataMarch = { 56.9, 45.8, 23.4, 12.5, 3, 68.9, -78.9 };
            PrintStatistics(statisticsDataMarch);

            double[] statisticsDataApril = { 56.9, 45.8, 23.4, 12.5, 3, 68.9, 0.90 };
            PrintStatistics(statisticsDataApril);
        }

        /// <summary>
        /// Print on console result of statistics data
        /// </summary>
        /// <param name="statisticsData">give as parameter statisticsData</param>
        public static void PrintStatistics(double[] statisticsData)
        {
            Console.WriteLine("---Statistics Results---");
            Console.WriteLine("Maximal data: {0:F5}", CalculateMaximalData(statisticsData));
            Console.WriteLine("Minimal data: {0:F5}", CalculateMinimalData(statisticsData));
            Console.WriteLine("Average data: {0:F5}", CalculateAverageData(statisticsData));
            Console.WriteLine();
        }

        /// <summary>
        /// Calculate maximal value(data) from given array of statistics data
        /// </summary>
        /// <param name="statisticsData">give as parameter statisticsData</param>
        /// <returns>double maximal data from statistics data</returns>
        public static double CalculateMaximalData(double[] statisticsData)
        {
            int countOfStatisticData = statisticsData.Length;
            double maximalData = double.MinValue;

            for (int currentIndex = 0; currentIndex < countOfStatisticData; currentIndex++)
            {
                if (statisticsData[currentIndex] > maximalData)
                {
                    maximalData = statisticsData[currentIndex];
                }
            }

            return maximalData;
        }

        /// <summary>
        /// Calculate minimal value(data) from given array of statistics data
        /// </summary>
        /// <param name="statisticsData">give as parameter statistics data</param>
        /// <returns>double minimal data from statistics data</returns>
        public static double CalculateMinimalData(double[] statisticsData)
        {
            double minimalData = double.MaxValue;
            int countOfStatisticData = statisticsData.Length;

            for (int currentIndex = 0; currentIndex < countOfStatisticData; currentIndex++)
            {
                if (statisticsData[currentIndex] < minimalData)
                {
                    minimalData = statisticsData[currentIndex];
                }
            }

            return minimalData;
        }

        /// <summary>
        /// Calculate average value(data) from given array of statistics data
        /// </summary>
        /// <param name="statisticsData">give as parameter statistics data</param>
        /// <returns>double average data from statistics data</returns>
        public static double CalculateAverageData(double[] statisticsData)
        {
            int countOfStatisticData = statisticsData.Length;
            double sumOfData = 0;

            for (int currentIndex = 0; currentIndex < countOfStatisticData; currentIndex++)
            {
                sumOfData += statisticsData[currentIndex];
            }

            double averageData = 0;
            averageData = sumOfData / countOfStatisticData;

            return averageData;
        }
    }
}
