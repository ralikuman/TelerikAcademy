using System;

namespace Point3D
{
    /*3.	Write a static class with a static method to calculate the distance between two points in the 3D space.*/
    public static class DistanceIn3DSpace
    {
        /*In 3D
            Define your two points. Point 1 at (x1, y1, z1) and Point 2 at (x2, y2, z2).
            xd = x2-x1
            yd = y2-y1
            zd = z2-z1
            Distance = SquareRoot(xd*xd + yd*yd + zd*zd) */

        public static double CalculateDistanceBetweenTwoPoints(Point3D point1, Point3D point2)
        {
            double distance;
            int xd = (point2.X - point1.X);
            int yd = (point2.Y - point1.Y);
            int zd = (point2.Z - point1.Z);
            return distance = Math.Sqrt((double)(xd * xd + yd * yd + zd * zd));
        }
    }
}