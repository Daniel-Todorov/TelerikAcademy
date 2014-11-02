//Write a program that reads a string from the
//console and lists all different words in the string
//along with information how many times each 
//word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PrintDifferentWords
{
    static void Main()
    {
        Console.WriteLine("Please, type a string and press Enter: ");
        string text = Console.ReadLine();
        string[] allWords = Regex.Split(text, @"\W\s*", RegexOptions.IgnoreCase);
        List<string> containedWords = new List<string>();
        List<int> matches = new List<int>();

        for (int i = 0; i < allWords.Length; i++)
        {
            if (WordIsNotContained(allWords[i], containedWords))
            {
                containedWords.Add(allWords[i]);
                matches.Add(Regex.Matches(text, @"\b"+allWords[i]+@"\b", RegexOptions.IgnoreCase).Count);
            }
        }

        for (int i = 0; i < containedWords.Count - 1; i++)
        {
            Console.WriteLine("Word {0} repeats {1} times", containedWords[i], matches[i]);
        }
    }

    static bool WordIsNotContained(string word, List<string> list)
    {
        bool isNotContained = true;

        for (int i = 0; i < list.Count; i++)
        {
            if (word.Equals(list[i], StringComparison.OrdinalIgnoreCase))
            {
                isNotContained = false;
                break;
            }
        }

        return isNotContained;
    }
}
