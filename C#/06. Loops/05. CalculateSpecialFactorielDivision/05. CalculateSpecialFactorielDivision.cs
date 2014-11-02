//Write a program that calculates N!*K!/(K-N)! for given N and K (1<N<K).

using System;

class CalculateFactorielDivision
{
    static void Main()
    {
        ulong N = 0;
        ulong K = 0;
        ulong production = 1;
        ulong division = 1;

        Console.Write("Please, type N (N > 1) and press Enter: ");
        N = ulong.Parse(Console.ReadLine());
        Console.Write("Please, type K (K > N) and press Enter: ");
        K = ulong.Parse(Console.ReadLine());

        //N!*K!/(K-N)! = (K!/(K-N)!)*N! - the first part now looks just like problem 04.
        //So we first calculate the division and then the production of the result with N!
        for (ulong a = 1; a <= K; a++)
        {
            if (a > K - N)
            {
                division = division * a;
            }
        }

        //Now that we have the division calculated, we must find it's production with N!. TO make the code more understandable we'll use the variable called production instead.
        production = division;
        for (ulong b = 1; b <= N; b++)
        {
            production = production * b;
        }

        Console.WriteLine("N!*K!/(K-N)! = {0}", production);
    }
}
