//Declare two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeValuesOfTwoVariables
{
    static void Main()
    {
        byte firstVariable = 5;
        byte secondVariable = 10;
        byte transVariable;
        Console.WriteLine("First variable is {0} and second variable is {1}", firstVariable, secondVariable);

        transVariable = firstVariable;
        firstVariable = secondVariable;
        secondVariable = transVariable;
        Console.WriteLine("After the transition the first variable is {0} and the second variable is {1}", firstVariable, secondVariable);
    }
}
