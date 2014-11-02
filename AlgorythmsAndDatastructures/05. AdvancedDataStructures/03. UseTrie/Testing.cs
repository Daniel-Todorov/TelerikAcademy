//Write a program that finds a set of words (e.g. 1000 
//words) in a large text (e.g. 100 MB text file). Print 
//how many times each word occurs in the text.
//Hint: you may find a C# trie in Internet.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class Testing
{
    public static void Main()
    {
        string inputText;
        StreamReader reader = new StreamReader("test.txt");

        using (reader)
        {
            inputText = reader.ReadToEnd().ToLower();
        }

        var matches = Regex.Matches(inputText, @"[a-zA-Z]+");
        HashSet<string> uniqueWords = new HashSet<string>();
        var trie = new Trie();

        for (int i = 0; i < matches.Count; i++)
        {
            uniqueWords.Add(matches[i].ToString());
            trie.Add(matches[i].ToString());
        }

        foreach (var word in uniqueWords)
        {
            Console.WriteLine("{0} -> {1} times", word, trie.GetWordOccurance(word));
        }
    }
}