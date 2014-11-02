//Write an if statement that examines two integer variables and exchanges
//their values if the first one is greater than the second one.

using System;

class CompareVariablesAndExchangeValues
{
    static void Main()
    {
        int firstVariable = 0;
        int secondVariable = 0;
        int transitionalVariable = 0;

        Console.Write("Please, type the first integer variable and press Enter: ");
        firstVariable = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second integer variable and press Enter: ");
        secondVariable = int.Parse(Console.ReadLine());

        if (firstVariable > secondVariable)
        {
            transitionalVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = transitionalVariable;
            Console.WriteLine("The new value of the first variable is {0} and the new value of the second variable is {1}", firstVariable, secondVariable);
        }
        else
        {
            Console.WriteLine("The second variable is greater or equal to the first so we won't exchange values");
        }
    }
}
