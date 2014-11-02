//Write a method that adds two positive integer 
//numbers represented as arrays of digits (each 
//array element arr[i] contains a digit; the last digit 
//is kept in arr[0]). Each of the numbers that will be 
//added could have up to 10 000 digits.

//This can actually work with more that 10 000 digits!
using System;
using System.Collections.Generic;

class AddSuperBigIntegers
{
    static List<int> Add(int[] firstArr, int[] secondArr)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < firstArr.Length; i++)
        {
            result.Add(firstArr[i]);
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            if (i >= firstArr.Length)
            {
                result.Add(secondArr[i]);
            }
            else
            {
                result[i] = result[i] + secondArr[i];
                if (result[i] > 9 && i < result.Count - 1)
                {
                    result[i + 1] = result[i + 1] + (result[i] / 10);
                    result[i] = result[i] % 10;
                }
                else if (result[i] > 9 && i >= result.Count - 1)
                {
                    result.Add(result[i] / 10);
                    result[i] = result[i] % 10;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        int[] firstNumber;
        int firstNumberLength = 0;
        int[] secondNumber;
        int secondNumberLength = 0;
        List<int> result;

        Console.Write("Please, type the number of digits of the first integer number and press Enter: ");
        firstNumberLength = int.Parse(Console.ReadLine());
        firstNumber = new int[firstNumberLength];
        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            Console.Write("Digit - > ");
            firstNumber[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, type the number of digits of the second integer number and press Enter: ");
        secondNumberLength = int.Parse(Console.ReadLine());
        secondNumber = new int[secondNumberLength];
        for (int i = secondNumber.Length - 1; i >= 0; i--)
        {
            Console.Write("Digit - > ");
            secondNumber[i] = int.Parse(Console.ReadLine());
        }

        result = Add(firstNumber, secondNumber);
        result.Reverse();

        Console.WriteLine();
        Console.Write("The sum of the two integer numbers is: ");
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
