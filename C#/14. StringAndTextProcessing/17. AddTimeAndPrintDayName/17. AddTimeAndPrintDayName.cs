//Write a program that reads a date and
//time given in the format: day.month.year
//hour:minute:second and prints the date and
//time after 6 hours and 30 minutes (in the same
//format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Text;

class AddTimeAndPrintDayName
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        givenDate = givenDate.AddHours(6);
        givenDate = givenDate.AddMinutes(30);
        Console.WriteLine("{0} {1}", givenDate.ToString("dddd", new CultureInfo("bg-BG")), givenDate);
    }


}
