namespace CohesionAndCoupling
{
    using System;

    public class RectangularParallelepiped
    {
        public RectangularParallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
        
        public double Width { get; private set; }

        public double Height { get; private set; }

        public double Depth { get; private set; }

        public double CalculateDiagonalXYZ()
        {
            double distance = ThreeDimentionUtils.CalculateDiagonal3D(this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = TwoDimentionUtils.CalculateDiagonal2D(this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = TwoDimentionUtils.CalculateDiagonal2D(this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = TwoDimentionUtils.CalculateDiagonal2D(this.Height, this.Depth);
            return distance;
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }
    }
}
