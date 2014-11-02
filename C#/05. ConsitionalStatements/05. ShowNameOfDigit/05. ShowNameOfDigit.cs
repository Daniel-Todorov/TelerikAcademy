//Write program that asks for a digit and depending on the input shows the name of tat digit (in English) using s switch statement

using System;

class ShowNameOfDigit
{
    static void Main()
    {
        byte digit = 0;

        Console.Write("Please, type a digit (0-9) and press Enter: ");
        digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("The digit you typed is {0} -> \"zero\"", digit);
                break;
            case 1:
                Console.WriteLine("The digit you typed is {0} -> \"one\"", digit);
                break;
            case 2:
                Console.WriteLine("The digit you typed is {0} -> \"two\"", digit);
                break;
            case 3:
                Console.WriteLine("The digit you typed is {0} -> \"three\"", digit);
                break;
            case 4:
                Console.WriteLine("The digit you typed is {0} -> \"four\"", digit);
                break;
            case 5:
                Console.WriteLine("The digit you typed is {0} -> \"five\"", digit);
                break;
            case 6:
                Console.WriteLine("The digit you typed is {0} -> \"six\"", digit);
                break;
            case 7:
                Console.WriteLine("The digit you typed is {0} -> \"seven\"", digit);
                break;
            case 8:
                Console.WriteLine("The digit you typed is {0} -> \"eight\"", digit);
                break;
            case 9:
                Console.WriteLine("The digit you typed is {0} -> \"nine\"", digit);
                break;
            default:
                Console.WriteLine("This is not a digit!");
                break;
        }
    }
}
