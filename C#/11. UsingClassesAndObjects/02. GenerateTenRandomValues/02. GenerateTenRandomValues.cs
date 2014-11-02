//Write a program that generates and prints to the
//console 10 random values in the range [100, 200].

using System;

class GenerateTenRandomValues
{
    static void Main()
    {
        Random generator = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Random value {0}: {1}", i, generator.Next(100, 201));
        }
    }
}
