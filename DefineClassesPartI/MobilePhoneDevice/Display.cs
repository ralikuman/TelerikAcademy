using System;

//display characteristics (size and number of colors)
public class Display
{
    //Field declarations

    private float size; // 2.5 inch diagonal
    private string numberOfColors; //16M, 65K and etc.


    //ex.5 properties to encapsulate the data fields

    public float Size
    {
        get { return this.size; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The price have to greatter than 0");
            }
            this.size = value;
        }
    }

    public string NumberOfColors
    {
        get { return this.numberOfColors; }
        set { this.numberOfColors = value; }
    }

    //ex. 2  - define constructors
    public Display()
        : this(0, "unknown")
    { }

    public Display(float size)
        : this(size, "unknown")
    { }

    public Display(string numberOfColors)
        : this(0, numberOfColors)
    { }

    public Display(float size, string numberOfColors)
    {
        this.size = size;
        this.numberOfColors = numberOfColors;
    }

    //ex.4 override method ToString()
    public override string ToString()
    {
        return string.Format("Display information:" + "\n" + "Display has size {0} inch and number of colors is {1}", this.size, this.numberOfColors);
    }
}
