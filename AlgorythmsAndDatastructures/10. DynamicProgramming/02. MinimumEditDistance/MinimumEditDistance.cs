//Write a program to calculate the "Minimum Edit 
//Distance" (MED) between two words. MED(x, y) is 
//the minimal sum of costs of edit operations used to 
//transform x to y. 

//NOTE!!! Based on wikipedia's example code => http://en.wikipedia.org/wiki/Levenshtein_distance

namespace _02.MinimumEditDistance
{
    using System;

    class MinimumEditDistance
    {
        private const double DeleteCost = 0.9;
        private const double InsertCost = 0.8;
        private const double ReplaceCost = 1;

        static void Main()
        {

            Console.WriteLine("MED = {0}", GetMED("developer", "enveloped"));
        }

        static double GetMED(string s, string t)
        {
            var d = new double[s.Length + 1, t.Length + 1];

            for (int i = 0; i <= s.Length; i++)
            {
                d[i, 0] = i * DeleteCost;
            }

            for (int j = 0; j <= t.Length; j++)
            {
                d[0, j] = j * InsertCost;
            }

            for (int j = 1; j <= t.Length; j++)

                for (int i = 1; i <= s.Length; i++)
                {

                    if (s[i - 1] == t[j - 1])
                    {
                        d[i, j] = d[i - 1, j - 1];
                    }
                    else
                    {
                        d[i, j] = Math.Min(Math.Min(
                            d[i - 1, j] + DeleteCost,
                            d[i, j - 1] + InsertCost),
                            d[i - 1, j - 1] + ReplaceCost);
                    }
                }

            return d[s.Length, t.Length];
        }
    }
}
