//*Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//N = 10 -> N! = 3628800 -> 2
//N = 20 -> N! = 2432902008176640000 -> 4
//Does your program work for N = 50000?
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;

class CountTrailingZeros
{
    static void Main()
    {
        int N = 0;
        int trailingZero = 0;
        double mathPow = 1.0;

        Console.Write("Please, type the number N and press Enter: ");
        N = int.Parse(Console.ReadLine());

        //Well, after some research on the net it seems there is a nice formula that doesn't even require the calculation of N!
        //So I'll just implement it here and the program will work even for 1000000!.

        while (Math.Pow(5.0, mathPow) <= N)
        {
            trailingZero = trailingZero + N / (int)Math.Pow(5.0, mathPow);
            mathPow++;
        }
        Console.WriteLine("The number of trailing zeroes in {0}! is {1}.", N, trailingZero);
    }
}
