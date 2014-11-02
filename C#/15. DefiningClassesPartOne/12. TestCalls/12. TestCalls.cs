//1. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//2. Create an instance of the GSM class.
//3. Add few calls.
//4. Display the information about the calls.
//5. Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//6. Remove the longest call from the history and calculate the total price again.
//7. Finally clear the call history and print it.

using System;
using System.Collections.Generic;

class GSMCallHistoryTest
{
    public static void Main()
    {
        //Creating the instance of GSM.
        Battery litiumBattery = new Battery("Normal", 123, 20.5, BatteryType.LiIon);
        Display big = new Display(8.4, 3000);
        GSM myPhone = new GSM("W595", "Sony - Erikson", 678, "Cecilia", litiumBattery, big);

        //Adding few calls.
        Call[] calls = new Call[4];
        calls[0] = new Call(DateTime.Today, DateTime.Now, "0888123456", 123);
        calls[1] = new Call(DateTime.Today, DateTime.Now, "0877123456", 45);
        calls[2] = new Call(DateTime.Today, DateTime.Now, "0899123456", 540);
        calls[3] = new Call(DateTime.Today, DateTime.Now, "0789123456", 18);
        for (int i = 0; i < calls.Length; i++)
        {
            myPhone.AddHistory(calls[i]);
        }

        //Display calls information.
        foreach (var item in myPhone.callHistory)
        {
            Console.WriteLine("Date and time: {0}, Dialed phone: {1}, Duration: {2} seconds", item.Time, item.DialedPhone, item.Duration);
            Console.WriteLine();
        }

        //Print total price.
        Console.WriteLine();
        Console.WriteLine("The total price of the calls is {0:f2}", myPhone.CalculateTotalPrice(0.37));

        //Remove longest call and calculate price again.
        int longestCallIndex = 0;
        double longestDuration = 0.0;
        for (int i = 0; i < myPhone.callHistory.Count; i++)
        {
            if (myPhone.callHistory[i].Duration > longestDuration)
            {
                longestCallIndex = i;
                longestDuration = myPhone.callHistory[i].Duration;
            }
        }
        myPhone.DeleteHistory(longestCallIndex);
        Console.WriteLine();
        Console.WriteLine("The total price of the calls is {0:f2}", myPhone.CalculateTotalPrice(0.37));

        //Clear history and print it.
        myPhone.ClearHistory();
        Console.WriteLine();
        if (myPhone.callHistory.Count > 0)
        {
            foreach (var item in myPhone.callHistory)
            {
                Console.WriteLine("Date and time: {0}, Dialed phone: {1}, Duration: {2} seconds", item.Time, item.DialedPhone, item.Duration);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Empty");
        }

    }
}

class Call
{
    private DateTime date;
    private DateTime time;
    private string dialedPhone;
    private int duration;

    public DateTime Date
    {
        get { return this.date; }
        set
        {
            this.date = value.Date;
        }
    }

    public DateTime Time {
        get { return this.time; }
        set { this.time = value; }
    }

    public string DialedPhone {
        get { return this.dialedPhone; }
        set { this.dialedPhone = value; }
    }

    public int Duration {
        get { return this.duration; }
        set { this.duration = value; }
    }

    public Call(DateTime date, DateTime time, string dialedPhone, int duration)
    {
        this.date = date.Date;
        this.time = time;
        this.dialedPhone = dialedPhone;
        this.duration = duration;
    }
}

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;
    private static GSM iPhone4S;
    public List<Call> callHistory = new List<Call>();

    public double CalculateTotalPrice(double price)
    {
        int limit = this.callHistory.Count;
        double totalPrice = 0.0;
        for (int counter = 0; counter < limit; counter++)
        {
            totalPrice += (((double)this.callHistory[counter].Duration) / 60.0) * price;
        }

        return totalPrice;
    }

    public void AddHistory(Call call)
    {
        this.callHistory.Add(call);
    }

    public void DeleteHistory(int index)
    {
        this.callHistory.RemoveAt(index);
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public List<Call> CallHistory { get; set; }

    public static GSM IPhone4S
    {
        get
        {
            GSM IPhone4S = new GSM("IPhone 4S", "Apple", 1999.99, "Steve Jobs");
            return IPhone4S;
        }
        set
        {
            GSM.iPhone4S = value;
        }
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Equals(null))
            {
                throw new FormatException("The model cannot be null");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Equals(null))
            {
                throw new FormatException("The manufacturer cannot be null");
            }

            this.manufacturer = value;
        }
    }

    public double Price { get; set; }

    public string Owner { get; set; }

    public Battery Battery { get; set; }

    public Display Display { get; set; }

    public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public GSM(string model, string manufacturer, double price, string owner, Battery battery)
        : this(null, null, 0.0, null, null, null)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
    }

    public GSM(string model, string manufacturer, double price, string owner)
        : this(null, null, 0.0, null, null, null)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }

    public GSM(string model, string manufacturer, double price)
        : this(null, null, 0.0, null, null, null)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
    }

    public GSM(string model, string manufacturer)
        : this(null, null, 0.0, null, null, null)
    {
        this.model = model;
        this.manufacturer = manufacturer;
    }

    public override string ToString()
    {
        string price = string.Format("Price: {0}", this.price);

        string owner = null;
        if (this.owner.Equals(null))
        {
            owner = "Owner: none";
        }
        else
        {
            owner = string.Format("Owner: {0}", this.owner);
        }

        string battery = null;
        if (this.battery == null)
        {
            battery = "Battery: none";
        }
        else
        {
            battery = string.Format("Battery: {0}", this.battery.Model);
        }

        string display = null;
        if (this.display == null)
        {
            display = "Display: none";
        }
        else
        {
            display = string.Format("Display size: {0} - number of colors: {1}", this.display.Size, this.display.NumberOfColors);
        }
        string result = string.Format("Model: {0}; Manufacturer: {1}; {2}; {3}; {4}; {5}", this.model, this.manufacturer, price, owner, battery, display);
        return result;
    }
}

class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    private BatteryType batteryType;

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Equals(null))
            {
                throw new FormatException("The model of the battery can't be null");
            }

            this.model = value;
        }
    }

    public double HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value <= 0)
            {
                throw new FormatException("The hoursIdle can't be negative");
            }

            this.hoursIdle = value;
        }
    }

    public double HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value <= 0)
            {
                throw new FormatException("The hoursTalk can't be negative");
            }

            this.hoursTalk = value;
        }
    }

    public BatteryType BatteryType
    {
        get { return this.batteryType; }
        set { this.batteryType = value; }
    }

    public Battery(string model)
        : this(null, 0.0, 0.0, BatteryType.None)
    {
        this.model = model;
    }

    public Battery(string model, double hoursIdle)
        : this(null, 0.0, 0.0, BatteryType.None)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
    }

    public Battery(string model, double hoursIdle, double hoursTalk)
        : this(null, 0.0, 0.0, BatteryType.None)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryType = batteryType;
    }
}

class Display
{
    private double size;
    private int numberOfColors;

    public double Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public int NumberOfColors
    {
        get { return this.numberOfColors; }
        set { this.numberOfColors = value; }
    }

    public Display()
        : this(0, 0)
    {
    }

    public Display(double size)
        : this(0, 0)
    {
        this.size = size;
    }

    public Display(int numberOfColors)
        : this(0, 0)
    {
        this.numberOfColors = numberOfColors;
    }

    public Display(double size, int numberOfColors)
    {
        this.size = size;
        this.numberOfColors = numberOfColors;
    }
}

public enum BatteryType
{
    None, LiIon, NiMH, NiCd
}
