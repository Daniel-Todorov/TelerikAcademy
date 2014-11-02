using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class FeaturingGrisko
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<int[]> transed = new List<int[]>();
        ulong differentWordsCounter = 0;
        string word = null;

        int N = input.Length;
        int K = 0;
        int counter = 0;
        List<int> results = new List<int>();
        bool isPermutation = true;

        K = N;

        for (int a = 0; a < K; a++)
        {
            results.Add(1);
        }

        while (counter < Math.Pow((double)N, (double)K))
        {
            for (int a = K - 1; a > 0; a--)
            {
                if (results[a] > N)
                {
                    results[a] = 1;
                    results[a - 1]++;
                }
            }

            for (int b = 0; b < K; b++)
            {
                for (int c = b + 1; c < K; c++)
                {
                    if (results[b] == results[c])
                    {
                        isPermutation = false;
                    }
                }
            }

            if (isPermutation == true)
            {
                word = TurnToString(results, input);
                if (CheckIfDifferent(word))
                {
                    differentWordsCounter++;
                }
            }

            results[results.Count - 1]++;
            counter++;
            isPermutation = true;
        }

        Console.WriteLine(differentWordsCounter);
    }

    static bool CheckIfDifferent(string text)
    {
        bool isDifferent = true;
        StringBuilder changedText = new StringBuilder();
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (!text[i].ToString().Equals(text[i + 1].ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                changedText.Append(text[i]);
            }
        }
        changedText.Append(text[text.Length - 1]);
        if (text.Length != changedText.Length)
        {
            isDifferent = false;
        }

        return isDifferent;
    }

    static string TurnToString(List<int> code, string text)
    {
        StringBuilder result = new StringBuilder(text.Length);
        for (int i = 0; i < code.Count; i++)
        {
            result.Append(text[code[i] - 1]);
        }

        return result.ToString();
    }
}
