//Write methods to calculate minimum, maximum,
//average, sum and product of given set of integer 
//numbers. Use variable number of arguments.

using System;

class UseVariableNumberOfArguments
{
    static double CalculateMinimum(params int[] elements)
    {
        double result = 0;

        result = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (result > elements[i])
            {
                result = elements[i];
            }
        }

        return result;
    }

    static double CalculateMaximum(params int[] elements)
    {
        double result = 0;

        result = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (result < elements[i])
            {
                result = elements[i];
            }
        }

        return result;
    }

    static double CalculateAvarage(params int[] elements)
    {
        double result = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            result = result + elements[i];
        }
        result = result / elements.Length;

        return result;
    }

    static double CalculateSum(params int[] elements)
    {
        double result = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            result = result + elements[i];
        }

        return result;
    }

    static double CalculateProduct(params int[] elements)
    {
        double result = 1;

        for (int i = 0; i < elements.Length; i++)
        {
            result = result * elements[i];
        }

        return result;
    }

    static void Main()
    {
        double result = 0.0;

        Console.WriteLine("The set we'll use is 3, 6, 1, 9, -1, 7.");
        result = CalculateMinimum(3, 6, 1, 9, -1, 7);
        Console.Write("The minimal value in the set is: ");
        Console.WriteLine(result);

        Console.Write("The maximal value in the set is: ");
        result = CalculateMaximum(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);

        Console.Write("The avarage value of the set is: ");
        result = CalculateAvarage(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);

        Console.Write("The sum of the elements in the set is: ");
        result = CalculateSum(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);

        Console.Write("The product of the elements in the set is: ");
        result = CalculateProduct(3, 6, 1, 9, -1, 7);
        Console.WriteLine(result);
    }
}
