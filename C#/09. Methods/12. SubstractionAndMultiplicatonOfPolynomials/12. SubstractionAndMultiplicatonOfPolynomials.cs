//Extend the program to support also subtraction
//and multiplication of polynomials.

using System;
using System.Collections.Generic;

class AdditionOfPolynomials
{
    static int[] AddPolynomials(int[] firstPoly, int[] secondPoly)
    {
        int[] result;

        if (firstPoly.Length > secondPoly.Length)
        {
            result = new int[firstPoly.Length];
            for (int i = 0; i < secondPoly.Length; i++)
            {
                result[i] = firstPoly[i] + secondPoly[i];
            }
            for (int i = secondPoly.Length; i < firstPoly.Length; i++)
            {
                result[i] = firstPoly[i];
            }
        }
        else
        {
            result = new int[secondPoly.Length];
            for (int i = 0; i < firstPoly.Length; i++)
            {
                result[i] = firstPoly[i] + secondPoly[i];
            }
            for (int i = firstPoly.Length; i < secondPoly.Length; i++)
            {
                result[i] = secondPoly[i];
            }
        }

        return result;
    }

    static int[] SubstractPolynomials(int[] firstPoly, int[] secondPoly)
    {
        int[] result;

        if (firstPoly.Length > secondPoly.Length)
        {
            result = new int[firstPoly.Length];
            for (int i = 0; i < secondPoly.Length; i++)
            {
                result[i] = firstPoly[i] - secondPoly[i];
            }
            for (int i = secondPoly.Length; i < firstPoly.Length; i++)
            {
                result[i] = firstPoly[i];
            }
        }
        else
        {
            result = new int[secondPoly.Length];
            for (int i = 0; i < firstPoly.Length; i++)
            {
                result[i] = firstPoly[i] - secondPoly[i];
            }
            for (int i = firstPoly.Length; i < secondPoly.Length; i++)
            {
                result[i] = secondPoly[i] * (-1);
            }
        }

        return result;
    }

    static int[] MultiplyPolunomials(int[] firstPoly, int[] secondPoly)
    {
        int[] result = new int[firstPoly.Length + secondPoly.Length - 1];

        for (int a = 0; a < firstPoly.Length; a++)
        {
            for (int b = 0; b < secondPoly.Length; b++)
            {
                result[b + a] = result[b + a] + (firstPoly[a] * secondPoly[b]);
            }
        }

        return result;
    }

    static void Main()
    {
        int[] firstPolynomial;
        int powerOfFirstPolynomial = 0;
        int[] secondPolynomial;
        int powerOfSecondPolynomial = 0;
        int[] result;

        Console.Write("Please, type the power of the first polynomial and press Enter: ");
        powerOfFirstPolynomial = int.Parse(Console.ReadLine());
        firstPolynomial = new int[powerOfFirstPolynomial + 1];
        Console.WriteLine("Please, type the coeficents of the first polynomial and press Enter: ");
        for (int i = firstPolynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("Coeficient of X at power {0} -> ", i);
            firstPolynomial[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        Console.Write("Please, type the power of the second polynomial and press Enter: ");
        powerOfSecondPolynomial = int.Parse(Console.ReadLine());
        secondPolynomial = new int[powerOfSecondPolynomial + 1];
        Console.WriteLine("Please, type the coeficents of the second polynomial and press Enter: ");
        for (int i = secondPolynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("Coeficient of X at power {0} -> ", i);
            secondPolynomial[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        result = AddPolynomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The addition of the first and the second polynomial is: ");
        for (int i = result.Length - 1; i > 0; i--)
        {
            Console.Write("({0}) * X at power {1} + ", result[i], i);
        }
        Console.Write("({0})", result[0]);
        Console.WriteLine();
        Console.WriteLine();

        result = SubstractPolynomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The substraction of the first and the second polynomial is: ");
        for (int i = result.Length - 1; i > 0; i--)
        {
            Console.Write("({0}) * X at power {1} + ", result[i], i);
        }
        Console.Write("({0})", result[0]);
        Console.WriteLine();
        Console.WriteLine();

        result = MultiplyPolunomials(firstPolynomial, secondPolynomial);
        Console.WriteLine("The multiplication of the first and the second polynomial is: ");
        for (int i = result.Length - 1; i > 0; i--)
        {
            Console.Write("({0}) * X at power {1} + ", result[i], i);
        }
        Console.Write("({0})", result[0]);
        Console.WriteLine();
        Console.WriteLine();
    }
}