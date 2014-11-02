//Write a program that applies bonus scores to given scores in the range [1..9].
//The program reads a digit as input.
//If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multplies it by 100; if it is between 7 and 9, multiplies it by 1000.
//If it is zero or if the value is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class ApplyBonusScores
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Please, type scores (1 to 9) and press Enter: ");

        if (int.TryParse(Console.ReadLine(), out score))
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    score = score * 10;
                    Console.WriteLine("The multiplied scores are {0}", score);
                    break;
                case 4:
                case 5:
                case 6:
                    score = score * 100;
                    Console.WriteLine("The multiplied scores are {0}", score);
                    break;
                case 7:
                case 8:
                case 9:
                    score = score * 1000;
                    Console.WriteLine("The multiplied scores are {0}", score);
                    break;
                default:
                    Console.WriteLine("You type incorrect value! Note that it must be a digit (1 to 9)!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("You type incorrect value! Note that it must be a digit (1 to 9)!");
        }
        
    }
}
