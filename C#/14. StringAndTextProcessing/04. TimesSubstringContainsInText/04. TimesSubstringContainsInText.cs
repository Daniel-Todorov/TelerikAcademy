//Write a program that finds how many times a
//substring is contained in a given text (perform 
//case insensitive search).
//Example: The target substring is "in". The text is 
//as follows:
//We are living in an yellow submarine. We don't
//have anything else. Inside the submarine is very
//tight. So we are drinking all the day. We will
//move out of it in 5 days.
//The result is: 9.

using System;
using System.Text.RegularExpressions;

class TimesSubstringContainsInText
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        int counter = 0;

        //Remove the commenting slashes if you want to try your own string and substring.

        //Console.Write("Please, type the text to be checked and press Enter: ");
        //input = Console.ReadLine();
        //Console.Write("Please, type the substring to be checked and press Enter: ");
        //substring = Console.ReadLine();

        foreach (Match item in Regex.Matches(input, substring, RegexOptions.IgnoreCase))
        {
            counter++;
        }
        Console.WriteLine("The text contains substring '{0}' {1} times.", substring, counter);
    }
}