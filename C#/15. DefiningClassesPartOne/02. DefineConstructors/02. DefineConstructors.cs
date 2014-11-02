//Define several constructors for the defined classes
//that take different sets of arguments (the full 
//information for the class or part of it). Assume that 
//model and manufacturer are mandatory (the others 
//are optional). All unknown data fill with null.

using System;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;

    //There can be one hell of a different contructors here.
    //I am pretty sure these are not all possible ones, but I hope I've shown I get the main idea.
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

    //Defining different constructors. 
    //Note that it we can't have two constructors which take one double value coz then the program won't know if we mean hoursIdle or hoursTalk.
    public Battery(string model)
        : this(null, 0.0, 0.0)
    {
        this.model = model;
    }

    public Battery(string model, double hoursIdle)
        : this(null, 0.0, 0.0)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
    }

    public Battery(string model, double hoursIdle, double hoursTalk)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
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
