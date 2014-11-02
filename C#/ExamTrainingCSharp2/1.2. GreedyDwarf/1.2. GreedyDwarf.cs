using System;

class GreedyDwarf
{
    static void Main()
    {
        string[] separator = { ", " };
        string[] valley = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int numberOfPatterns = int.Parse(Console.ReadLine());
        string[][] paterns = new string[numberOfPatterns][];
        for (int a = 0; a < paterns.GetLength(0); a++)
        {
            paterns[a] = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        int maxSum = 0;
        int sum = 0;
        for (int b = 0; b < paterns.GetLength(0); b++)
        {
            sum = GetCoins(valley, paterns[b]);

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        Console.WriteLine(maxSum);
    }

    static int GetCoins(string[] valley, string[] patern)
    {
        string[] valleyCopy = new string[valley.Length];
        valley.CopyTo(valleyCopy, 0);
        int sum = int.Parse(valley[0]);
        int index = 0;
        valleyCopy[index] = "9999";
        while (true)
        {
            for (int a = 0; a < patern.Length; a++)
            {
                index = index + int.Parse(patern[a]);
                if (index >= valleyCopy.Length || index < 0)
                {
                    return sum;
                }
                else if (int.Parse(valleyCopy[index]) > -1001 && int.Parse(valleyCopy[index]) < 1001)
                {
                    sum = sum + int.Parse(valleyCopy[index]);
                    valleyCopy[index] = "9999";
                }
                else
                {
                    return sum;
                }
            }
        }
    }

}
