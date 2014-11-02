using System;
using System.Collections.Generic;
using System.Text;

class KaspichanNumbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        if (input == 0)
        {
            Console.WriteLine("A");
            return;
        }
        ulong remainder = input;
        List<string> kaspichanNumber = new List<string>();
        while (remainder > 0)
        {
            kaspichanNumber.Add(TurnToKaspichan(remainder % 256));
            remainder = remainder / 256;
        }
        kaspichanNumber.Reverse();

        StringBuilder numberToDisplay = new StringBuilder();
        foreach (var item in kaspichanNumber)
        {
            numberToDisplay.Append(item);
        }

        Console.WriteLine(numberToDisplay);
    }

    static string TurnToKaspichan(ulong number)
    {
        ulong wholePart = number/26;
        ulong remainder = number%26;
        StringBuilder kaspichanNumber = new StringBuilder();

        switch (wholePart)
        {
            case 1:
                kaspichanNumber.Append("a");
                break;
            case 2:
                kaspichanNumber.Append("b");
                break;
            case 3:
                kaspichanNumber.Append("c");
                break;
            case 4:
                kaspichanNumber.Append("d");
                break;
            case 5:
                kaspichanNumber.Append("e");
                break;
            case 6:
                kaspichanNumber.Append("f");
                break;
            case 7:
                kaspichanNumber.Append("g");
                break;
            case 8:
                kaspichanNumber.Append("h");
                break;
            case 9:
                kaspichanNumber.Append("i");
                break;
        }

        switch (remainder)
        {
            case 0:
                kaspichanNumber.Append("A");
                break;
            case 1:
                kaspichanNumber.Append("B");
                break;
            case 2:
                kaspichanNumber.Append("C");
                break;
            case 3:
                kaspichanNumber.Append("D");
                break;
            case 4:
                kaspichanNumber.Append("E");
                break;
            case 5:
                kaspichanNumber.Append("F");
                break;
            case 6:
                kaspichanNumber.Append("G");
                break;
            case 7:
                kaspichanNumber.Append("H");
                break;
            case 8:
                kaspichanNumber.Append("I");
                break;
            case 9:
                kaspichanNumber.Append("G");
                break;
            case 10:
                kaspichanNumber.Append("K");
                break;
            case 11:
                kaspichanNumber.Append("L");
                break;
            case 12:
                kaspichanNumber.Append("M");
                break;
            case 13:
                kaspichanNumber.Append("N");
                break;
            case 14:
                kaspichanNumber.Append("O");
                break;
            case 15:
                kaspichanNumber.Append("P");
                break;
            case 16:
                kaspichanNumber.Append("Q");
                break;
            case 17:
                kaspichanNumber.Append("R");
                break;
            case 18:
                kaspichanNumber.Append("S");
                break;
            case 19:
                kaspichanNumber.Append("T");
                break;
            case 20:
                kaspichanNumber.Append("U");
                break;
            case 21:
                kaspichanNumber.Append("V");
                break;
            case 22:
                kaspichanNumber.Append("W");
                break;
            case 23:
                kaspichanNumber.Append("X");
                break;
            case 24:
                kaspichanNumber.Append("Y");
                break;
            case 25:
                kaspichanNumber.Append("Z");
                break;
        }

        return kaspichanNumber.ToString();
    }
}
