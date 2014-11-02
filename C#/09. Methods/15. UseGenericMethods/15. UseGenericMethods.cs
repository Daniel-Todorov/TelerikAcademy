//* Modify your last program and try to make it work
//for any number type, not just integer (e.g. decimal, 
//float, byte, etc.). Use generic method (read in 
//Internet about generic methods in C#).

using System;
using System.Numerics;

class UseGenericMethods
{
    static T CalculateMinimum<T>(params T[] elements) where T : IComparable
    {
        T result;

        result = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (result.CompareTo(elements[i]) > 0)
            {
                result = elements[i];
            }
        }

        return result;
    }

    static T CalculateMaximum<T>(params T[] elements) where T : IComparable
    {
        T result;

        result = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (result.CompareTo(elements[i]) < 0)
            {
                result = elements[i];
            }
        }

        return result;
    }

    static T CalculateAvarage <T>(params T[] elements)
    {
        dynamic result = default(T);

        for (int i = 0; i < elements.Length; i++)
        {
            result = result + elements[i];
        }
        result = result / elements.Length;

        return result;
    }


    static T CalculateSum<T>(params T[] elements)
    {
        dynamic result = default(T);

        for (int i = 0; i < elements.Length; i++)
        {
            result = result + elements[i];
        }

        return result;
    }

    static T CalculateProduct<T>(params T[] elements)
    {
        dynamic result = 1.0;

        for (int i = 0; i < elements.Length; i++)
        {
            result = result * elements[i];
        }

        return result;
    }

    static void Main()
    {
        object result; ;

        Console.WriteLine("The set we'll use is 3, 6, 1, 9, -1, 7.");
        result = CalculateMinimum(3, 6, 1, 9, -1, 7);
        Console.Write("The minimal value in the set is: ");
        Console.WriteLine(result);

        Console.Write("The maximal value in the set is: ");
        result = CalculateMaximum(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);

        Console.Write("The avarage value of the set is: ");
        result = CalculateAvarage(3.0, 6.0, 1.0, 9.0, -1.0, 7.0);
        Console.WriteLine(result);

        Console.Write("The sum of the elements in the set is: ");
        result = CalculateSum(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);

        Console.Write("The product of the elements in the set is: ");
        result = CalculateProduct(3.0, 6.0, 1.0, 9.0, -1.0, 7.0);
        Console.WriteLine(result);
    }
}