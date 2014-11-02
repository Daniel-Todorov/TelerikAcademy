//Write a program that reads from the console a
//string of maximum 20 characters. If the length of 
//the string is less than 20, the rest of the characters 
//should be filled with '*'. Print the result string into 
//the console.

using System;
using System.Text;

class ReadAndPrintTwentyCharacterString
{

    static void Main()
    {
        Console.Write("Please, type a string of maximum 20 characters and press Enter: ");
        string inputString = Console.ReadLine();
        while (inputString.Length > 20)
        {
            Console.Write("The string was not withthe correct length. Please, try again: ");
            inputString = Console.ReadLine();
        }

        StringBuilder twentyCharString = new StringBuilder(20);
        twentyCharString.Append(inputString);
        twentyCharString.Append('*', 20 - inputString.Length);

        Console.WriteLine("The 20 character long string is {0}.", twentyCharString);
    }
}
