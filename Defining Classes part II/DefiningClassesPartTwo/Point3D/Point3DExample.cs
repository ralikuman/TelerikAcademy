using System;
namespace Point3D
{
    class Point3DExample
    {
        static void Main()
        {
            /*наясно съм че "Point3D ex1-ex2-ex3-ex4" не е добро наименование на проект, 
             * правилно е да е "Point3D", добавих единствено това "ex1-ex2-ex3-ex4",
             * за да е прегледно за проверяващия кои задачи обхваща от домашното*/
            
            string fileName = @"../../../paths.txt";
            //string fileName = "c://test//path.txt";  //wrong path

            //ex.1 
            Point3D point = new Point3D(3, 5, 7);
            Console.WriteLine(point.ToString());

            //ex.2 print zero point
            Point3D point1 = Point3D.Zero;
            Console.WriteLine(point1.ToString());

            //ex.3 print distance between two points
            Console.WriteLine("The distance between two pints is: {0:F8}", DistanceIn3DSpace.CalculateDistanceBetweenTwoPoints(point, point1));

            //ex.4 add point in path 
            Path pathOfPoints = new Path();
            pathOfPoints.AddPoint(point);
            pathOfPoints.AddPoint(point1);

            //write paths in file
            PathStorage.SavePathsInFile(pathOfPoints, fileName);

            //load paths from file
            Path pathOfPointsLoad = new Path();
            pathOfPointsLoad = PathStorage.LoadPathsFromFile(fileName);

            Console.WriteLine("Print points from pathOfPointsLoad");
            pathOfPointsLoad.PrintPaths();
        }
    }
}