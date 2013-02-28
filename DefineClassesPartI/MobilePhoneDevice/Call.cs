using System;

/*8.	Create a class Call to hold a call performed through a GSM. 
 * It should contain date, time, dialed phone number and duration (in seconds).*/

public class Call
{
    //fields
    private DateTime date;
    private string dialedPhoneNum;
    private int duration;

    //properties
    public DateTime Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    public string DialedPhoneNum
    {
        get { return this.dialedPhoneNum; }
        set { this.dialedPhoneNum = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }

    //constructor
    public Call(DateTime date, string dialedPhoneNumber, int duration)
    {
        this.date = date;
        this.dialedPhoneNum = dialedPhoneNumber;
        this.duration = duration;
    }
}

