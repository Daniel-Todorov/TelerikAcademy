//Write a program that extracts from a given text all
//sentences containing given word.
//Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have
//anything else. Inside the submarine is very tight.
//So we are drinking all the day. We will move out
//of it in 5 days.
//The expected result is:
//We are living in a yellow submarine.
//We will move out of it in 5 days.
//Consider that the sentences are separated by "."
//and the words - by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentencesContainingWord
{
    static void Main()
    {
        string inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string containedWord = "in";
        string[] sentenceSeparator = {"."};
        string[] sentences = inputText.Split(sentenceSeparator, StringSplitOptions.RemoveEmptyEntries);
        string[] words;
        List<string> result = new List<string>();

        for (int i = 0; i < sentences.Length; i++)
        {
            words = Regex.Split(sentences[i], @"\W",RegexOptions.IgnoreCase);
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].CompareTo(containedWord) == 0)
                {
                    result.Add(sentences[i]);
                    break;
                }
            }
        }

        Console.WriteLine("The sentences which contain the word '{0}' are: ", containedWord);
        foreach (var item in result)
        {
            Console.WriteLine(item.Trim(' '));
        }
    }
}