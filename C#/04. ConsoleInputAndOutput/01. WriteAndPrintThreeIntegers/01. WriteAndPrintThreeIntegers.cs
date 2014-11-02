//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class WriteAndPrintThreeIntegers
{
    static void Main()
    {
        int firstIntegerNumber;
        int secondintegerNumber;
        int thirdIntegerNumber;
        int sum;

        Console.WriteLine("Please, type the first integer number and press Enter:");
        firstIntegerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the second integer number and press Enter:");
        secondintegerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the third integer number and press Enter:");
        thirdIntegerNumber = int.Parse(Console.ReadLine());

        sum = firstIntegerNumber + secondintegerNumber + thirdIntegerNumber;
        Console.WriteLine("The sum of the three integer numbers is: {0}", sum);
    }
}
