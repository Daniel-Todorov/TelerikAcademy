//Write a program that shows the sign (+ or -) of te product of three real
//numbers without calculating it. Use a sequence of if statements.

using System;

class ShowSignOfProduct
{
    static void Main()
    {
        int firstRealNumber = 0;
        int secondRealNumber = 0;
        int thirdRealNumber = 0;
        byte signCounter = 0;

        Console.Write("Please, type the first real number and press Enter: ");
        firstRealNumber = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second real number and press Enter: ");
        secondRealNumber = int.Parse(Console.ReadLine());
        Console.Write("Please, type the third real number and press Enter: ");
        thirdRealNumber = int.Parse(Console.ReadLine());

        if (firstRealNumber < 0)
        {
            signCounter++;
        }
        if (secondRealNumber < 0)
        {
            signCounter++;
        }
        if (thirdRealNumber < 0)
        {
            signCounter++;
        }

        if (signCounter % 2 == 0)
        {
            Console.WriteLine("The sign of the product is PLUS +");
        }
        if (signCounter % 2 != 0)
        {
            Console.WriteLine("The sign of the product is MINUS -");
        }
    }
}
