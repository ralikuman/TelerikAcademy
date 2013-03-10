using System;
using System.Collections.Generic;

/*4.	Create a class Path to hold a sequence of points in the 3D space.
 * Create a static class PathStorage with static methods to save and load paths from a text file.
 * Use a file format of your choice.*/

namespace Point3D
{
   public class Path 
    {
       private List<Point3D> pathOfPoints = new List<Point3D>();

       public List<Point3D> PathOfPoints
       {
           get 
           {
               return this.pathOfPoints;
           }
       }

       //method to add new point in list of points
       public void AddPoint(Point3D point)
       {
           pathOfPoints.Add(point);
       }

       public void PrintPaths()
       {
           foreach (var item in pathOfPoints)
           {
               Console.WriteLine("({0},{1},{2})", item.X, item.Y,item.Z);     
           }
       }
    }
}
