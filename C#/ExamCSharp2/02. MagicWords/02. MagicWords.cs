using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>(n);
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        //tested
        string currentWord = null;
        int newPosition = 0;
        for (int i = 0; i < n; i++)
        {
            currentWord = words[i];
            newPosition = currentWord.Length % (n + 1);
            words.Insert(newPosition, currentWord);
            if (i < newPosition)
            {
                words.RemoveAt(i);
            }
            else if (i >= newPosition)
            {
                words.RemoveAt(i + 1);
            }
        }

        //tested
        StringBuilder printable = new StringBuilder();
        for (int i = 0; i < 1001; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < words[j].Length)
                {
                    printable.Append(words[j][i]);
                }
            }
        }

        Console.WriteLine(printable);
    }
}
