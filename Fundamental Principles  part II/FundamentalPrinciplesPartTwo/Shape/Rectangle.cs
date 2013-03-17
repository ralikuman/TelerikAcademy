public class Rectangle : Shape
{
    /*height*width for rectangle */
    public Rectangle(double width, double height) 
        :base(width, height)
    {   
    }

    public override double CalculateSurface()
    {
        return this.Height * Width;
    }
}
