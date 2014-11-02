using System;

class Program
{
    static void Main()
    {
        long R = 0;
        long C = 0;
        long[] initialLine = new long[4];
        long counter = 0;

        for (long a = 0; a < 4; a++)
        {
            initialLine[a] = long.Parse(Console.ReadLine());
        }

        R = long.Parse(Console.ReadLine());
        C = long.Parse(Console.ReadLine());

        long[] secondaryLine = new long[R * C];

        for (int b = 0; b < 4; b++)
        {
            secondaryLine[b] = initialLine[b];
        }

        for (int c = 4; c < secondaryLine.Length; c++)
        {
            secondaryLine[c] = secondaryLine[c - 1] + secondaryLine[c - 2] + secondaryLine[c - 3] + secondaryLine[c - 4];
        }

        for (int d = 0; d < R; d++)
        {
            for (int e = 0; e < C; e++)
            {
                Console.Write("{0} ", secondaryLine[counter]);
                counter++;
            }
            Console.WriteLine("");
        }
    }
}
