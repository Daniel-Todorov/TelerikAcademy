//Define a class that holds information about a
//mobile phone device: model, manufacturer, price, 
//owner, battery characteristics (model, hours 
//idle and hours talk) and display characteristics 
//(size and number of colors). Define 3 separate 
//classes (class GSM holding instances of the classes 
//Battery and Display).

using System;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;
}

class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
}

class Display
{
    private double size;
    private int numberOfColors;
}