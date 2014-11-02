//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class CalculateFactorielDivision
{
    static void Main()
    {
        ulong N = 0;
        ulong K = 0;
        ulong division = 1;

        Console.Write("Please, type N (N > K > 1) and press Enter: ");
        N = ulong.Parse(Console.ReadLine());
        Console.Write("Please, type K (N > K > 1) and press Enter: ");
        K = ulong.Parse(Console.ReadLine());

        for (ulong a = 1; a <= N; a++)
        {
            if (a > K)
            {
                division = division * a;
            }
        }

        Console.WriteLine("N!/K! = {0}", division);
    }
}
