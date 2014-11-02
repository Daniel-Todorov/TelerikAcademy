//Write a program that reads a string from
//the console and replaces all series of 
//consecutive identical letters with a single one.

using System;
using System.Text;
class ReplaceSeriesOfConsecutiveLetters
{
    static void Main()
    {
        Console.WriteLine("Please, type a string and press Enter: ");
        string text = Console.ReadLine();

        StringBuilder changedText = new StringBuilder();
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (!text[i].ToString().Equals(text[i + 1].ToString(),StringComparison.InvariantCultureIgnoreCase))
            {
                changedText.Append(text[i]);
            }
        }
        changedText.Append(text[text.Length - 1]);

        Console.WriteLine("The text without consecutive characters is: {0}", changedText);
    }
}