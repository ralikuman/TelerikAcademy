namespace CohesionAndCoupling
{
    using System;

    public static class TwoDimentionUtils
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static double CalculateDiagonal2D(double firstSite, double secondSite)
        {
            double distance = CalculateDistance2D(0, 0, firstSite, secondSite);
            return distance;
        }
    }
}
