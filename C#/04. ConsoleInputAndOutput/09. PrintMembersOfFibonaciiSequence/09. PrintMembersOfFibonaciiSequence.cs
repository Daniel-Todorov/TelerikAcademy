//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

using System;

class PrintMembersOfFibonaciiSequence
{
    static void Main()
    {
        decimal a = 0;
        decimal b = 1;
        decimal c = 0;

        for (int i = 1; i < 101; i++)
        {
            Console.WriteLine("{0}", c);
            c = a + b;
            a = b;
            b = c;
        }
    }
}
