//Write a program that can solve these tasks:
//1. Reverses the digits of a number
//2. Calculates the average of a sequence of integers
//3. Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to 
//choose which task to solve.
//Validate the input data:
//1. The decimal number should be non-negative
//2. The sequence should not be empty
//3. a should not be equal to 0

using System;
using System.Collections.Generic;

class SolveThreeTasks
{
    static int ReverseDigits(int initialNumber)
    {
        List<int> result = new List<int>();
        string transition = initialNumber.ToString();
        for (int i = 0; i < transition.Length; i++)
        {
            result.Add(int.Parse(transition[i].ToString()));
        }
        result.Reverse();
        transition = null;
        for (int i = 0; i < result.Count; i++)
        {
            transition = transition + result[i];
        }

        initialNumber = int.Parse(transition);

        return initialNumber;
    }

    static bool ValidateNumber(int initialNumber)
    {
        bool result = false;
        if (initialNumber > 0)
        {
            result = true;
        }

        return result;
    }

    static double CalculateAvarage(params int[] elements)
    {
        double result = 0.0;
        for (int i = 0; i < elements.Length; i++)
        {
            result = result + elements[i];
        }
        result = result / elements.Length;

        return result;
    }

    static bool ValidateSequence(int[] elements)
    {
        bool result = false;
        if (elements.Length > 0)
        {
            result = true;
        }

        return result;
    }

    static double SolveEquation(double a, double b)
    {
        double result = 0.0;
        result = ((-1) * b) / a;
        return result;
    }

    static bool ValidateEquation(double a)
    {
        bool result = false;
        if (a != 0)
        {
            result = true;
        }

        return result;
    }

    static void Main()
    {
        int number = 0;
        int[] sequence;
        double avarage = 0.0;
        double a = 0.0;
        double b = 0.0;
        double x = 0.0;

        Console.WriteLine("To reverse the digits of a positive integer number, please press Shift + R.");
        Console.WriteLine("To find the avarage of a sequence of integers, please press Shift + A.");
        Console.WriteLine("To solve a linear equation, please press Shift + S.");

        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();

        if (key.Key == ConsoleKey.R)
        {
            Console.Write("Please, type a number to be reversed and press Enter: ");
            number = int.Parse(Console.ReadLine());
            while (ValidateNumber(number) == false)
            {
                Console.Write("The number should be positive! Please try again: ");
                number = int.Parse(Console.ReadLine());
            }

            number = ReverseDigits(number);
            Console.Write("After the reversing, the number is: ");
            Console.WriteLine(number);
        }

        if (key.Key == ConsoleKey.A)
        {
            sequence = Utilities.GenerateIntegerArray();
            while (ValidateSequence(sequence) == false)
            {
                Console.Write("The sequence should Not be empty! Try again!");
                sequence = Utilities.GenerateIntegerArray();
            }

            avarage =  CalculateAvarage(sequence);
            Console.Write("The avarage of the elements in the sequence is: ");
            Console.WriteLine(avarage);
        }

        if (key.Key == ConsoleKey.S)
        {
            Console.WriteLine("Please, type the coeficients 'a' and 'b' of the equation a*x + b = 0!");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (ValidateEquation(a) == false)
            {
                Console.WriteLine("The coefficient 'a' should not be equal to ZERO! Try again!");
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            x = SolveEquation(a,b);
            Console.Write("x = ");
            Console.WriteLine(x);
        }
    }
}
