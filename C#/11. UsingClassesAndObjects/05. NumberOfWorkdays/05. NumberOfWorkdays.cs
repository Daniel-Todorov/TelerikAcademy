//Write a mehtod that calculates the number of
//workdays between today and a given date, passed as 
//parameter. Consider that workdays are all days from
//Monday to Friday except a fixed list of public
//holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class NumberOfWorkdays
{
    public enum Workdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime givenDate;
        int year = 0;
        int month = 0;
        int day = 0;
        int numberOfWorkdays = 0;
        List<DateTime> holidays = new List<DateTime>();
        holidays.Add(new DateTime(2013, 1, 1));
        holidays.Add(new DateTime(2013, 3, 3));
        holidays.Add(new DateTime(2013, 5, 24));
        holidays.Add(new DateTime(2013, 9, 6));
        holidays.Add(new DateTime(2013, 9, 22));
        holidays.Add(new DateTime(2013, 12, 24));
        holidays.Add(new DateTime(2013, 12, 25));
        holidays.Add(new DateTime(2013, 12, 26));
        bool isWorkday = true;

        Console.Write("Please, type the year of the given date and press Enter: ");
        year = int.Parse(Console.ReadLine());
        Console.Write("Please, type the month of the given date and press Enter: ");
        month = int.Parse(Console.ReadLine());
        Console.Write("Please, type the day of the given date and press Enter: ");
        day = int.Parse(Console.ReadLine());
        givenDate = new DateTime(year, month, day);

        while (today < givenDate)
        {
            for (int i = 0; i < holidays.Count; i++)
            {
                if (today.Day == holidays[i].Day && today.Month == holidays[i].Month)
                {
                    isWorkday = false;
                }
            }

            if (isWorkday && (today.DayOfWeek.CompareTo(System.DayOfWeek.Monday) == 0 || today.DayOfWeek.CompareTo(System.DayOfWeek.Tuesday) == 0 || today.DayOfWeek.CompareTo(System.DayOfWeek.Wednesday) == 0 || today.DayOfWeek.CompareTo(System.DayOfWeek.Thursday) == 0 || today.DayOfWeek.CompareTo(System.DayOfWeek.Friday) == 0))
            {
                numberOfWorkdays++;
            }

            isWorkday = true;
            today = today.AddDays(1);
        }

        Console.WriteLine("The number of the workdays in the period is {0}.", numberOfWorkdays);
        Console.WriteLine("NOTE! Take in mind that due to the variations around Easter, it is not added to the list of holidays.");
    }
}