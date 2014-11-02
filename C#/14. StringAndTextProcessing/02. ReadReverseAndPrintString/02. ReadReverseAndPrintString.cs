//Write a program that reads a string, reverses it
//and prints the result at the console.
//Example: "sample" -> "elpmas".

using System;
using System.Text;

class ReadReverseAndPrintString
{
    static StringBuilder Reverse(string userInput)
    {
        StringBuilder reversed = new StringBuilder(userInput.Length);
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed.Append(userInput[i]);
        }

        return reversed;
    }

    static void Main()
    {
        Console.Write("Please, type the string to be reversed and press Enter: ");
        string userInput = Console.ReadLine();
        StringBuilder reversedInput = Reverse(userInput);
        Console.WriteLine("The reversed string is '{0}'", reversedInput);
    }
}