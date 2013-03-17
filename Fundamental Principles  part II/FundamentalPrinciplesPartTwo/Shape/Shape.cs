using System;

/* Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. */
public abstract class Shape
{
    protected double Width { get; set; }
    protected double Height { get; set; }

    public abstract double CalculateSurface();

    public Shape(double wight, double height)
    {
        this.Width = wight;
        this.Height = height;
    }
}


