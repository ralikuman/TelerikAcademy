// <copyright file="SizeExample.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace RefactorWithProperName
{
    using System;
    using System.Linq;

    public class SizeExample
    {
        public static void Main(string[] args)
        {
            Size mySize = new Size(10, 29);
            double myFigyreAngle = 70.0;

            Size rotateSize = GetRotatedSize(mySize, myFigyreAngle);
            Console.WriteLine("Width: {0:F5}, Height: {1:F5}", rotateSize.Width, rotateSize.Height);
        }

        public static Size GetRotatedSize(Size size, double angleOfTheRotatedFigure)
        {
            double cosine = Math.Abs(Math.Cos(angleOfTheRotatedFigure));
            double sinus = Math.Abs(Math.Sin(angleOfTheRotatedFigure));

            double newWidth = (cosine * size.Width) + (sinus * size.Height);
            double newHeight = (sinus * size.Width) + (cosine * size.Height);

            Size newSize = new Size(newWidth, newHeight);
            return newSize;
        }
    }
}
