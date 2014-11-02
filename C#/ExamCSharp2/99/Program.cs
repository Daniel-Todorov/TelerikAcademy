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

        string prePreviousWord = null;
        string previousWord = null;
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
                        break;
                    }
                }
            }

            if (isPermutation == true)
            {
                word = TurnToString(results, input);
                if (!word.Equals(previousWord))
                {
                    if (CheckIfDifferent(word))
                    {
                        differentWordsCounter++;
                        prePreviousWord = previousWord;
                        previousWord = word;
                        
                    }
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
        Match match = Regex.Match(text, "aa|bb|cc|dd|ee|ff|gg|hh|ii|jj|kk|ll|mm|nn|oo|pp|qq|rr|ss|tt|uu|vv|ww|xx|yy|zz");
        if (match.Length > 0)
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
