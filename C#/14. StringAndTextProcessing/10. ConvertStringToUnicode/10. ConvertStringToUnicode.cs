//Write a program that converts a string to a
//sequence of C# Unicode character literals. Use 
//format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021

using System;
using System.Text;

class ConvertStringToUnicode
{
    static void Main()
    {
        Console.Write("Please, type the string to be converted to Unicode and press Enter: ");
        string userInput = Console.ReadLine();
        StringBuilder output = new StringBuilder(userInput.Length * 6);
        string code = null; ;
        for (int i = 0; i < userInput.Length; i++)
        {
            code = string.Format("/u{0:x4}", Convert.ToInt16(userInput[i]));
            output.Append(code);
        }

        Console.WriteLine("The converted string is: {0}", output.ToString());
    }
}