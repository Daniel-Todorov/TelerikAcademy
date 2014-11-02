//Write a program that reads a number and prints
//it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the 
//output aligned right in 15 symbols.

using System;

class PrintNumberInVariousWays
{
    static void Main()
    {
        Console.Write("Please, type an integer number and press Enter: ");
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.Write("This is not an enteger number, please, try again: ");
            number = int.Parse(Console.ReadLine());
        }        

        PrintDecimal(number);
        PrintHexadecimal(number);
        PrintPercentage(number);
        PrintScientific(number);
    }

    static void PrintDecimal(int number)
    {
        Console.WriteLine("Printed as decimal: ");
        Console.WriteLine("{0,15:D}", number);
    }

    static void PrintHexadecimal(int number)
    {
        Console.WriteLine("Printed as decimal: ");
        Console.WriteLine("{0,15:X}", number);
    }

    static void PrintPercentage(int number)
    {
        Console.WriteLine("Printed as decimal: ");
        Console.WriteLine("{0,15:P}", number);
    }

    static void PrintScientific(int number)
    {
        Console.WriteLine("Printed as decimal: ");
        Console.WriteLine("{0,15:E}", number);
    }
}
