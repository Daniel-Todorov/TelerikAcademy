//Write a program that extracts from a given text all
//dates that match the format DD.MM.YYYY. Display
//them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = "Oh my, god, it is 01.02.2013! I wonder what to do now. May be I should way for 02.03.2013 before I make any plans?";
        var matches = Regex.Matches(text, @"\d\d\.\d\d\.\d\d\d\d");
        CultureInfo culture = new CultureInfo("fr-CA");

        Console.WriteLine("The dates are: ");
        foreach (var item in matches)
        {
            Console.WriteLine(DateTime.Parse(item.ToString()).ToString("yyyy-MM-dd", culture));
        }        
    }
}