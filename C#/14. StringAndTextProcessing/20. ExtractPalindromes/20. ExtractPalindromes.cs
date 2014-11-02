//Write a program that extracts from a given text all
//palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;

class ExtractPalindromes
{
    static void Main()
    {
        string text = "la la lalala ABBA, sha la la la la - lamal, tc tc tc bahti - exe.";
        char[] separators = { ' ', ',', '.', '!', '?', '"', ':', ';','-' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].CompareTo(Reverse(words[i])) == 0)
            {
                palindromes.Add(words[i]);
            }
        }

        Console.WriteLine("The palindrmes in the text are: ");
        foreach (var item in palindromes)
        {
            Console.WriteLine(item);
        }
    }

    static string Reverse(string word)
    {
        string reversed = null;
        for (int i = 0; i < word.Length; i++)
        {
            reversed = reversed + word[word.Length - 1 - i];
        }

        return reversed;
    }
}
