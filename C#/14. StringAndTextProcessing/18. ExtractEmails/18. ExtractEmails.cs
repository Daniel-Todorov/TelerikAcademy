//Write a program for extracting all
//email addresses from given text.
//All substrings that match the format 
//<identifier>@<host>…<domain> should be 
//recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Hi, I want to ive my three emails: az@abv.bg, sam@hotmail.com and tapo@gov.uk.tv.";
        var match = Regex.Matches(text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

        Console.WriteLine("The email adresses in the text are: ");
        foreach (var item in match)
        {
            Console.WriteLine(item);
        }
        
    }
}