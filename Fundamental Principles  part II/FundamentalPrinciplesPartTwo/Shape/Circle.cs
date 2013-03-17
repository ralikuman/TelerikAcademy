using System;

class Circle:Shape
{
    /*Define class Circle and suitable constructor so that on initialization height must be kept equal to width 
     * and implement the CalculateSurface() method. */
    public Circle(double radius)
        : base(radius, radius)
    {        
    }

    public override double CalculateSurface()
    {
        return Math.PI * this.Width * this.Width;
    }
}
