//Write a program that reads an integer number and
//calculates and prints its square root. If the 
//number is invalid or negative, print "Invalid 
//number". In all cases finally print "Good bye". Use 
//try-catch-finally.

using System;

class CalculateSqrt
{
    static void Main()
    {
        double number = 0;
        double squareRoot = 0;

        try
        {
            Console.Write("Please, type the number whose square root you want to find and press Enter: ");
            number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new FormatException();
            }
            squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}