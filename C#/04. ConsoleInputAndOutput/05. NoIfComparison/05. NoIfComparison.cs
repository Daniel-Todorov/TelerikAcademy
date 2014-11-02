//Write a program that gets two numbers from the console and prints the greater of them. Don't use if statements.

using System;

class NoIfComparison
{
    static void Main()
    {
        int firstInteger = 0;
        int secondinteger = 0;
        string print = null;

        Console.WriteLine("Please, type the first integer number to be compared and press Enter:");
        firstInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the second integer number to be compared and press Enter:");
        secondinteger = int.Parse(Console.ReadLine());

        print = (firstInteger > secondinteger) ? ("The greater number is " + firstInteger) : ("The greater number is " + secondinteger);
        Console.WriteLine(print);
    }
}
