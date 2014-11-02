//Write a program that reads a list of words,
//separated by spaces and prints the list in an
//alphabetical order.

using System;
using System.Text;

class PrintWordsInAlphabeticalOrder
{
    static void Main()
    {
        Console.WriteLine("Please, type a list of words, separated by spaces and press Enter: ");
        string text = Console.ReadLine();
        text = SortWords(text);

        Console.WriteLine("The ordered list of words is: {0}", text);
    }

    private static string SortWords(string text)
    {
        string[] words = text.Split(' ');
        Array.Sort(words);
        StringBuilder orderedText = new StringBuilder();
        for (int i = 0; i < words.Length - 1; i++)
        {
            orderedText.Append(words[i]);
            orderedText.Append(" ");
        }
        orderedText.Append(words[words.Length - 1]);

        return orderedText.ToString();
    }
}
