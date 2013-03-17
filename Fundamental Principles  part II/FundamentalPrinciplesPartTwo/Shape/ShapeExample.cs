using System;

class ShapeExample
{
    /*1.	Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
        * Define two new classes Triangle and Rectangle that implement the virtual method and 
        * return the surface of the figure (height*width for rectangle and height*width/2 for triangle). 
        * Define class Circle and suitable constructor so that 
        * on initialization height must be kept equal to width and implement the CalculateSurface() method. 
        * Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.*/

    static void Main()
    {
        Shape rectangle = new Rectangle(4.0, 5.5);
        Console.WriteLine("Surface of rectangle is: {0}", rectangle.CalculateSurface());

        Shape triangle = new Triangle(4.0, 5.5);
        Console.WriteLine("Surface of triangle is: {0}", triangle.CalculateSurface());

        Shape circle = new Circle(4.5);
        Console.WriteLine("Surface of circle is: {0:F6}", circle.CalculateSurface());

        Console.WriteLine();
        Console.WriteLine("---different shapes---");
        Shape[] shapes = {rectangle, 
                            triangle, 
                            circle,
                            new Circle(6.3),
                            new Triangle(4.6, 7.3)         
                };

        foreach (var shape in shapes)
        {
            Console.WriteLine("Surface of {0} is {1}", shape.GetType(), shape.CalculateSurface());
        }
    }
}

