//Writ a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in the internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int transVariable = 0;
        bool loop = true;

        Console.Write("Please, type the first number and press Enter: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second number and press Enter: ");
        secondNumber = int.Parse(Console.ReadLine());

        while (loop)
        {
            if (firstNumber < secondNumber)
            {
                transVariable = firstNumber;
                firstNumber = secondNumber;
                secondNumber = transVariable;
            }
            firstNumber = firstNumber % secondNumber;
            if (firstNumber == 0)
            {
                loop = false;
            }
        }

        Console.WriteLine("The greatest common divisor of the two numbers is {0}", secondNumber);
    }
}
