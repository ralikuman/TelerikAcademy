using System;

public class Triangle : Shape
{
    /*height*width/2 for triangle*/
    public Triangle(double width, double height)
        : base(width, height)
    {
    }

    public override double CalculateSurface()
    {
        return (this.Height * Width) / 2;
    }
}
