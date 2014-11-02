using System;
using System.Text.RegularExpressions;

class MultiverseCommunication
{
    static void Main()
    {
        string msg = Console.ReadLine().ToUpper();

        MatchCollection digits = Regex.Matches(msg, "CHU|TEL|OFT|IVA|EMY|VNB|POQ|ERI|CAD|K-A|IIA|YLO|PLA", RegexOptions.IgnorePatternWhitespace);

        ulong[] decimalDigits = new ulong[digits.Count];
        for (int i = 0; i < decimalDigits.Length; i++)
        {
            decimalDigits[i] = TurnToDecimal(digits[i].ToString());
        }
        //tested

        ulong decimalNumber = 0;
        for (int i = decimalDigits.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            decimalNumber = decimalNumber + (decimalDigits[i] * (ulong) Math.Pow(13, pow));
        }

        Console.WriteLine(decimalNumber);
    }

    static ulong TurnToDecimal(string input)
    {
        ulong result = 0;
        switch (input)
        {
            case "CHU": result = 0; break;
            case "TEL": result = 1; break;
            case "OFT": result = 2; break;
            case "IVA": result = 3; break;
            case "EMY": result = 4; break;
            case "VNB": result = 5; break;
            case "POQ": result = 6; break;
            case "ERI": result = 7; break;
            case "CAD": result = 8; break;
            case "K-A": result = 9; break;
            case "IIA": result = 10; break;
            case "YLO": result = 11; break;
            case "PLA": result = 12; break;
            default:
                break;
        }

        return result;
    }
}
