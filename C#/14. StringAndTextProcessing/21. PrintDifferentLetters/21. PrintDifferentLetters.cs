//Write a program that reads a string from the
//console and prints all different letters in the string
//along with information how many times each 
//letter is found.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class PrintDifferentLetters
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> containedLetters = new List<string>();
        List<int> matches = new List<int>();

        for (int i = 0; i < alphabet.Length; i++)
        {
            int numberOfMatches = Regex.Matches(text, alphabet[i], RegexOptions.IgnoreCase).Count;
            if (numberOfMatches > 0)
            {
                containedLetters.Add(alphabet[i]);
                matches.Add(numberOfMatches);
            }
        }

        for (int i = 0; i < containedLetters.Count; i++)
        {
            Console.WriteLine("Letter '{0}' -> {1} times", containedLetters[i], matches[i]);
        }
    }
}
