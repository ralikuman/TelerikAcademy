namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine("--- File utils ---");
            Console.WriteLine(FileUtility.GetFileExtension("example"));
            Console.WriteLine(FileUtility.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.new.pdf"));
            Console.WriteLine();
            
            Console.WriteLine("--- Geometry utils ---");

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                TwoDimentionUtils.CalculateDistance2D(1, -2, 3, 4));

            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                ThreeDimentionUtils.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            RectangularParallelepiped parallepiped = new RectangularParallelepiped(3, 4, 5);
            Console.WriteLine(
                "Volume of rectangular parallelepiped = {0:f2}",
                parallepiped.CalculateVolume());
            Console.WriteLine(
                "Diagonal XYZ of rectangular parallelepiped = {0:f2}",
                parallepiped.CalculateDiagonalXYZ());
            Console.WriteLine(
                "Diagonal XY of rectangular parallelepiped = {0:f2}",
                parallepiped.CalculateDiagonalXY());
            Console.WriteLine(
                "Diagonal XZ of rectangular parallelepiped = {0:f2}",
                parallepiped.CalculateDiagonalXZ());
            Console.WriteLine(
                "Diagonal YZ of rectangular parallelepiped = {0:f2}",
                parallepiped.CalculateDiagonalYZ());
        }
    }
}
