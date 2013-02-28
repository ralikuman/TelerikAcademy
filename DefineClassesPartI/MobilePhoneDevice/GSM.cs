using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

/* 1.	Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
 * battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
 * Define 3 separate classes (class GSM holding instances of the classes Battery and Display).*/

/*2.	Define several constructors for the defined classes that take different sets of arguments 
 * (the full information for the class or part of it). Assume that model and manufacturer are mandatory 
 * (the others are optional). All unknown data fill with null.*/

/*4.	Add a method in the GSM class for displaying all information about it. Try to override ToString().*/

/*5.	Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
 * Ensure all fields hold correct data at any given time.*/

/*6.	Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.*/

/*9.	Add a property CallHistory in the GSM class to hold a list of the performed calls. 
 * Try to use the system class List<Call>.*/

/*10.	Add methods in the GSM class for adding and deleting calls from the calls history. 
 * Add a method to clear the call history.*/

/*11.	Add a method that calculates the total price of the calls in the call history. 
 * Assume the price per minute is fixed and is provided as a parameter.*/

public class GSM
{
    //ex. 1 - define a class 
    //Field declarations in class GSM
    private string modelOfGSM;
    private string manufacturer;
    private decimal price;
    private string owner;
    private Battery battery = new Battery();
    private Display display = new Display();

    //ex.6 static field and a property IPhone4S
    private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 999.00M, "Unknown", new Battery(300, 7, BatteryType.LiPo), new Display(3.5F));

    public static GSM IPhone4S
    {
        get { return iPhone4S; }
    }

    //ex9. CallHistory 
    private List<Call> callHistory = new List<Call>();
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }


    //ex.5 properties to encapsulate the data fields
    public string ModelOfGSM
    {
        get { return this.modelOfGSM; }
        set
        {
            if (value.Length <= 0)
            {
                throw new ArgumentException("You have to enter model of GSM, the field can not be empty!");
            }
            this.modelOfGSM = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Length <= 0)
            {
                throw new ArgumentException("You have to enter manufactor of GSM, the field can not be empty!");
            }
            this.modelOfGSM = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price have to greatter than 0");
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (value.Length <= 0)
            {
                throw new ArgumentException("The name of owner have to greatter than zero!");
            }
            foreach (char ch in value)
            {
                if (!IsLetterAllowedInNames(ch))
                {
                    throw new ArgumentException("Invalid name! Use only letters, space and hyphen");
                }
            }
            this.owner = value;
        }
    }

    //ex. 2  - define constructors
    //constructor with mantory arguments
    public GSM(string modelOfGSM, string manufacturer)
        : this(modelOfGSM, manufacturer, 0.0M, null, null, null)
    { }

    public GSM(string modelOfGSM, string manufacturer, decimal price)
        : this(modelOfGSM, manufacturer, price, null, null, null)
    { }

    public GSM(string modelOfGSM, string manufacturer, decimal price, string owner)
        : this(modelOfGSM, manufacturer, price, owner, null, null)
    { }

    public GSM(string modelOfGSM, string manufacturer, decimal price, string owner, Battery battery)
        : this(modelOfGSM, manufacturer, price, owner, battery, null)
    { }

    //constructor with all arguments
    public GSM(string modelOfGSM, string manufacturer, decimal price, string owner, Battery battery, Display display)
    {
        this.modelOfGSM = modelOfGSM;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    //ex.4 override method ToString()
    public override string ToString()
    {
        return string.Format("GSM Information " + "\n" + "Owner {0}" + "\n"
            + "The GSM is model \"{1}\"  and made by \"{2}\"." + "\n" + "The mobile device costs {3:C2}"
            + "\n" + "{4}" + "{5}"
            , this.owner, this.modelOfGSM, this.manufacturer, this.price, this.battery.ToString(), this.display.ToString());
    }

    //method to check owner 
    private bool IsLetterAllowedInNames(char ch)
    {
        bool isAllowed =
            char.IsLetter(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }

    //ex.10 adding, deleting, clear call history

    public void AddCallInHistory(DateTime date, string dialedPhoneNumber, int durationSeconds)
    {
        Call newCall = new Call(date, dialedPhoneNumber, durationSeconds);
        callHistory.Add(newCall);
    }

    public void RemoveCallByNumber(string enterNumber)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].DialedPhoneNum == enterNumber)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void RemoveCallByDate(DateTime enterDate)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Date == enterDate)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void RemoveCallByLongestDuration()
    {
        int longestDuration = 0;
        int index = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration > longestDuration)
            {
                longestDuration = callHistory[i].Duration;
                index = i;
            }

        }

        callHistory.RemoveAt(index);


        //for (int i = 0; i < callHistory.Count; i++)
        //{
        //    if (callHistory[i].Date == enterDate)
        //    {
        //        callHistory.RemoveAt(i);
        //        i--;
        //    }
        //}
    }

    public void ClearCallHistory()
    {
        callHistory.Clear();
    }

    //ex.11 calculates the total price of the calls
    // private const decimal pricePerMinute = 0.37M;

    private readonly decimal pricePerMinute;

    public decimal CalcucateTotalPrice(decimal pricePerMinute)
    {
        int sumOfDurations = 0;  // sum of duration in seconds
        int sumOfDurationInMunutes = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            sumOfDurations += callHistory[i].Duration;
        }

        sumOfDurationInMunutes = sumOfDurations / 60; //convert second in minutes
        decimal totalPrice = sumOfDurationInMunutes * pricePerMinute;
        return totalPrice;
    }


    public string PrintCallHistory()
    {
        StringBuilder result = new StringBuilder();
        foreach (Call call in callHistory)
        {
            result.AppendFormat("\nDate: {0}\t Dialed Number: {1}\t Duration (in seconds): {2}\n",
                call.Date, call.DialedPhoneNum, call.Duration);
        }
        return result.ToString();
    }


}
