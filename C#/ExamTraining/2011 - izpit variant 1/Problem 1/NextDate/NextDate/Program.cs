using System;

class NextDate
{
    static void Main()
    {
        string date = null;
        DateTime currentDate;
        DateTime nexDay;

        date = Console.ReadLine();
        date = date + "." + Console.ReadLine();
        date = date + "." + Console.ReadLine();

        currentDate =Convert.ToDateTime(date);
        nexDay = currentDate.AddDays(1);

        Console.WriteLine(nexDay.Day +"." + nexDay.Month + "." + nexDay.Year);
    }
}