//Write a program that creates an array containing 
//all letters from the alphabet (A-Z). Read a word 
//from the console and print the index of each of its 
//letters in the array.

using System;

class ReadWordAndPrintIndexOfLetters
{
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string word = null;

        Console.Write("Please, type a word in small letters and press Enter: ");
        word = Console.ReadLine();

        for (int a = 0; a < word.Length; a++)
        {
            for (int b = 0; b < alphabet.Length; b++)
            {
                if (word[a].Equals(alphabet[b]))
                {
                    Console.WriteLine("The index of letter {0} is {1}.", a + 1, b);
                }
            }
        }
    }
}
