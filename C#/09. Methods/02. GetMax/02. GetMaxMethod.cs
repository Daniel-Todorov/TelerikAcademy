//Write a method GetMax() with two parameters that 
//returns the bigger of two integers. Write a program 
//that reads 3 integers from the console and prints 
//the biggest of them using the method GetMax().

using System;

class GetMaxMethod
{
    static int GetMax(int firstInt, int secondInt)
    {
        if (firstInt >= secondInt)
        {
            return firstInt;
        }
        else
        {
            return secondInt;
        }
    }

    static void Main()
    {
        int firstInt = 0;
        int secondInt = 0;
        int thirdInt = 0;

        Console.Write("Please, type the first integer number and press Enter: ");
        firstInt = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second integer number and press Enter: ");
        secondInt = int.Parse(Console.ReadLine());
        Console.Write("Please, type the third integer number and press Enter: ");
        thirdInt = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("The biggest of the three integer numbers is {0}!", GetMax(GetMax(firstInt, secondInt), thirdInt));
    }
}
