//We are given a string containing a list of
//forbidden words and a text containing some of 
//these words. Write a program that replaces the 
//forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP
//compiler today. It is based on .NET Framework 4.0
//and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//The expected result:
//********* announced its next generation ***
//compiler today. It is based on .NET Framework 4.0
//and is implemented as a dynamic language in ***.

using System;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main()
    {
        string forbidenList = "PHP, CLR, Microsoft";
        string[] forbiddenWords = Regex.Split(forbidenList, @"\W+");

        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("The text before creplacement: {0}", text);
        
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            string replacement = new string('*', forbiddenWords[i].Length);
            text = text.Replace(forbiddenWords[i], replacement);
        }

        Console.WriteLine("The text after repalcement: {0}", text);
    }
}
