//We are given 5 integer numbers.
//Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class CheckSumOfSubset
{
    static void Main()
    {
        int firstVariable = 0;
        int secondVariable = 0;
        int thirdVariable = 0;
        int forthVariable = 0;
        int fifthVariable = 0;
        int counter = 0;

        Console.Write("Please, type a number and press Enter: ");
        firstVariable = int.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        secondVariable = int.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        thirdVariable = int.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        forthVariable = int.Parse(Console.ReadLine());
        Console.Write("Please, type a number and press Enter: ");
        fifthVariable = int.Parse(Console.ReadLine());

        if (firstVariable + secondVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + thirdVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (secondVariable + thirdVariable == 0)
        {
            counter = counter + 1;
        }
        if (secondVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (secondVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (thirdVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (thirdVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }

        if (firstVariable + secondVariable + thirdVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + secondVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + secondVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + thirdVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + thirdVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }

        if (firstVariable + secondVariable + thirdVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + secondVariable + thirdVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (firstVariable + thirdVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }

        if (firstVariable + secondVariable + thirdVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
//............................
        if (secondVariable + thirdVariable + forthVariable == 0)
        {
            counter = counter + 1;
        }
        if (secondVariable + thirdVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
        if (secondVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }

        if (secondVariable + thirdVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }
//...............................
        if (thirdVariable + forthVariable + fifthVariable == 0)
        {
            counter = counter + 1;
        }

        Console.WriteLine("There are exactly {0} subsets whose sum is equal to 0.", counter);
    }
}
