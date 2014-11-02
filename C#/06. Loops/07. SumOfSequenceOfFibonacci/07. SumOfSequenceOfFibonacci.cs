//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...
//Each member of the Fibonacci sequence (except the first two) is  a sum of the previous two members.

using System;

class SumOfSequenceOfFibonacci
{
    static void Main()
    {
        int N = 0;
        int sum = 0;
        int[] sequenceOfFibonacci;

        Console.Write("Please, type the number N and press Enter: ");
        N = int.Parse(Console.ReadLine());
        sequenceOfFibonacci = new int[N];
        sequenceOfFibonacci[0] = 0;
        sequenceOfFibonacci[1] = 1;

        //We fill in an array -> the sequence of Fobonacci
        for (int a = 2; a < N; a++)
        {
                sequenceOfFibonacci[a] = sequenceOfFibonacci[a - 2] + sequenceOfFibonacci[a - 1];
        }

        //We add each member of the sequence to the sum
        foreach (var b in sequenceOfFibonacci)
        {
            sum = sum + b;
        }
        
        Console.WriteLine("The sum of the first {0} numbers in the sequence of Fibonacci is {1}.", N, sum);
    }
}
