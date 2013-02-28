using System;
using System.Text;
using System.ComponentModel;

/*1.    battery characteristics (model, hours idle and hours talk) */
/*3.	Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.*/

public class Battery
{
    //Field declarations
    //private string modelOfBaterry;
    private BatteryType batteryModel;
    private int hoursIdle;
    private int hoursTalk;


    //ex.5 properties to encapsulate the data fields
    public BatteryType BatteryModel
    {
        get { return this.batteryModel; }
        set
        {
            this.batteryModel = value;
        }
    }

    public int HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The hours Idle have to greatter than 0");
            }
            this.hoursIdle = value;
        }
    }

    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The hours Idle have to greatter than 0");
            }
            this.hoursTalk = value;
        }
    }

    //ex. 2  - define constructors
    public Battery()
        : this(0, 0, 0)
    { }

    public Battery(int hoursIdle)
        : this(hoursIdle, 0, 0)
    { }

    public Battery(int hoursIdle, int hoursTalk)
        : this(hoursIdle, hoursTalk, 0)
    { }

    public Battery(int hoursIdle, int hoursTalk, BatteryType batteryType)
    {
        //this.modelOfBaterry = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryModel = batteryType;
    }

    //ex.4 override method ToString()
    public override string ToString()
    {
        return string.Format("Battery information:" + "\n" + "Battery is {0} type, there is {1} hours Idle and  {2} hours Talk", this.batteryModel, this.hoursIdle, this.hoursTalk);
    }
}

//ex.3 add enumeration for battery type
public enum BatteryType
{
    [Description("Li-Ion battery")]
    LiIon,
    [Description("Nickel–metal hydride battery")]
    NiMH,
    [Description("Nickel–cadmium battery")]
    NiCd,
    [Description("Lithium polymer battery")]
    LiPo
}