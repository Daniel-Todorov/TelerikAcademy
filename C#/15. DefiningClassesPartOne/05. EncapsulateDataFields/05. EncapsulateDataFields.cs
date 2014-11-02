//Use properties to encapsulate the data fields
//inside the GSM, Battery and Display classes.
//Ensure all fields hold correct data at any given
//time.

using System;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;

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
        string result = string.Format("Model: {0}; Manufacturer: {1}; Price: {2}; Owner: {3}; Battery model: {4} - hours idle: {5} - hours talk: {6} -type: {7}; Display  size: {8} - number of colors: {9}", this.model, this.manufacturer, this.price, this.battery.Model, this.battery.HoursIdle, this.battery.HoursTalk, this.battery.BatteryType, this.display.Size, this.display.NumberOfColors);
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

    public double Size { get; set; }

    public int NumberOfColors { get; set; }

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
