//You are given a text. Write a program that
//changes the text in all regions surrounded by the 
//tags <upcase> and </upcase> to uppercase. The 
//tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</
//upcase>. We don't have <upcase>anything</upcase>
//else.
//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have
//ANYTHING else.

using System;

using System.Text;
using System.Text.RegularExpressions;

class RegionOfTextToUpperCase
{
    static StringBuilder ProcessTextA(string[] textToSplit)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < textToSplit.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Append(textToSplit[i]);
            }
            else
            {
                result.Append(textToSplit[i].ToUpper());
            }
        }

        return result;
    }

    static StringBuilder ProcessTextB(string[] textToSplit)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < textToSplit.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Append(textToSplit[i].ToUpper());
            }
            else
            {
                result.Append(textToSplit[i]);
            }
        }

        return result;
    }

    static void Main()
    {
        string userInput = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string[] splitting;
        string[] separators = { "<upcase>", "</upcase>" };
        StringBuilder tagsToCapital = new StringBuilder();
        splitting = userInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (!userInput.StartsWith("<upcase>"))
        {
            tagsToCapital = ProcessTextA(splitting);
        }
        else
        {
            tagsToCapital = ProcessTextB(splitting);
        }

        Console.WriteLine(tagsToCapital);
    }
}
