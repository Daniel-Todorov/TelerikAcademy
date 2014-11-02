//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1.
//If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output.
//Use switch statement.

using System;

class DifferentInputTypes
{
    static void Main()
    {
        double doubleVariable; //All numbers in the integer range can be included in double range so we'll use just a double variable
        string stringVariable = null;
        bool userInput = false;

        Console.Write("Please, type an integer, double and string variable and press Enter: ");
        stringVariable = Console.ReadLine();

        userInput = double.TryParse(stringVariable, out doubleVariable);

        switch (userInput)
        {
            case true:
                Console.WriteLine(doubleVariable + 1.0);
                break;
            case false:
                Console.WriteLine(stringVariable + "*");
                break;
        }
    }
}
