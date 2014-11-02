//Write a program to calculate n! for each n in the
//range [1..100]. Hint: Implement first a method
//that multiplies a number represented as array of 
//digits by given integer number.

using System;
using System.Collections.Generic;

class CalculateFactoriels
{
    static List<int> MultiplyArrayByNumber(List<int> array, int number)
    {
        List<int> result = new List<int>();
        int currentResult = 0;

        for (int i = 0; i < array.Count; i++)
        {
            currentResult = (array[array.Count - 1 - i] * number) + currentResult;
            result.Add(currentResult % 10);
            currentResult = currentResult / 10;
            while (currentResult != 0 && i == array.Count - 1)
            {
                result.Add(currentResult % 10);
                currentResult = currentResult / 10;
            }
        }

        result.Reverse();
        return result;
    }

    static void Main()
    {
        int N = 0;
        List<int> factoriel = new List<int>();

        Console.Write("Please, type the number N and press Enter: ");
        N = int.Parse(Console.ReadLine());
        factoriel.Add(1);

        for (int i = 1; i <= N; i++)
        {
            factoriel = MultiplyArrayByNumber(factoriel, i);
        }

        Console.Write("The factorial of {0}! is: ", N);
        foreach (var item in factoriel)
        {
            Console.Write("{0}", item);
        }
        Console.WriteLine();
    }
}
