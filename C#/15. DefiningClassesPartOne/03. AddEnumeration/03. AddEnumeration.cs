//Add an enumeration BatteryType (Li-Ion, NiMH,
//NiCd,...) and use it as a new field for the batteries.

using System;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;

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
}

class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    private BatteryType batteryType;

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