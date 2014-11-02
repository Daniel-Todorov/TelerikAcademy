//Write a program that reads two integer numbers 
//N and K and an array of N elements from the 
//console. Find in the array those K elements that 
//have maximal sum.

using System;

class MaximalSumFinder
{
    static void Main()
    {
        int N = 0;
        int K = 0;
        int[] userArray;
        int sum = 0;
        int maxsum = 0;
        int maxposition = 0;

        Console.Write("Plase, type the number N and press Enter: ");
        N = int.Parse(Console.ReadLine());
        userArray = new int[N];

        for (int a = 0; a < N; a++)
        {
            Console.WriteLine("Position {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
        }

        Console.Write("Plase, type the number K (K<N) and press Enter: ");
        K = int.Parse(Console.ReadLine());

        for (int a = 0; a < N - K + 1; a++)
        {
            for (int b = 0; b < K; b++)
            {
                sum = sum + userArray[a + b];
            }
            if (sum > maxsum)
            {
                maxsum = sum;
                maxposition = a;
                sum = 0;
            }
            else
            {
                sum = 0;
            }
        }

        for (int a = 0; a < K; a++)
        {
            Console.Write("{0} ", userArray[maxposition + a]);
        }
    }
}
