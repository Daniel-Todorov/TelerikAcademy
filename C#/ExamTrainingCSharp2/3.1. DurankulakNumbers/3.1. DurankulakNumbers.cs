using System;
using System.Text.RegularExpressions;

class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        var parsedInput = Regex.Matches(input, "[a-z][A-Z]|[A-Z]");

        ulong decimalNumber = 0;
        int partialDurankulak = 0;
        int power = parsedInput.Count - 1;
        for (int i = 0; i < parsedInput.Count; i++)
        {
            if (parsedInput[i].Length == 1)
            {
                partialDurankulak = GetCapitalValue(parsedInput[i].ToString());
            }
            else if (parsedInput[i].Length == 2)
            {
                partialDurankulak = GetMixedValue(parsedInput[i].ToString());
            }

            decimalNumber = decimalNumber + ((ulong)partialDurankulak) * ((ulong)(Math.Pow(168, power)));
            power--;
        }

        Console.WriteLine(decimalNumber);
    }

    static int GetMixedValue(string input)
    {
        int result = 0;
        int smallLetter = 0;
        int bigLetter = 0;
        bigLetter = GetCapitalValue(input[1].ToString());
        smallLetter = GetSmallValue(input[0].ToString());
        result = smallLetter + bigLetter;

        return result;
    }

    static int GetSmallValue(string input)
    {
        int result = 0;
        switch (input)
        {
            case "a": result = 1 * 26; break;
            case "b": result = 2 * 26; break;
            case "c": result = 3 * 26; break;
            case "d": result = 4 * 26; break;
            case "e": result = 5 * 26; break;
            case "f": result = 6 * 26; break;
        }

        return result;
    }

    static int GetCapitalValue(string input)
    {
        int result = 0;
        switch (input)
        {
            case "A": result = 0; break;
            case "B": result = 1; break;
            case "C": result = 2; break;
            case "D": result = 3; break;
            case "E": result = 4; break;
            case "F": result = 5; break;
            case "G": result = 6; break;
            case "H": result = 7; break;
            case "I": result = 8; break;
            case "J": result = 9; break;
            case "K": result = 10; break;
            case "L": result = 11; break;
            case "M": result = 12; break;
            case "N": result = 13; break;
            case "O": result = 14; break;
            case "P": result = 15; break;
            case "Q": result = 16; break;
            case "R": result = 17; break;
            case "S": result = 18; break;
            case "T": result = 19; break;
            case "U": result = 20; break;
            case "V": result = 21; break;
            case "W": result = 22; break;
            case "X": result = 23; break;
            case "Y": result = 24; break;
            case "Z": result = 25; break;
        }

        return result;
    }
}