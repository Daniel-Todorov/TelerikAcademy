//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. 
//Rewrite the same with LINQ.

using System;
using System.Linq;
using System.Collections.Generic;

class PrintDivisibles
{
    static void Main()
    {
        int[] arrayOfIntegers = new int[10] { 1, 7, 11, 14, 21, 32, 42, 56, 84, 90 };

        var lambda = Array.FindAll(arrayOfIntegers, result => result % 3 == 0 && result % 7 == 0);
        foreach (var item in lambda)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------------");

        var linq = from result in arrayOfIntegers
                   where result % 3 == 0 && result % 7 == 0
                   select result;
        foreach (var item in linq)
        {
            Console.WriteLine(item);
        }
    }
}
