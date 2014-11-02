//*Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.
//Examples:
//0 -> "Zero"
//273 -> "Two hundred seventy three" 
//400 -> "Four hundred"
//501 -> "Five hundred and one"
//711 -> "Seven hundred and eleven"

using System;

class ConvertNumberToText
{
    static void Main()
    {
        int userInput = 0;
        int hundreds = 0;
        int decimals = 0;
        int digits = 0;
        string pronunciationFirst = null;
        string pronunciationSecond = null;
        string pronunciationThird = null;
        string pronunciationWhole = null;

        Console.Write("Please, type a number from 0 to 999 to be converted to text and press Enter: ");
        userInput = int.Parse(Console.ReadLine());

        hundreds = userInput / 100;
        switch (hundreds)
        {
            case 1:
                pronunciationFirst = "one hundred";
                break;
            case 2:
                pronunciationFirst = "two hundred";
                break;
            case 3:
                pronunciationFirst = "three hundred";
                break;
            case 4:
                pronunciationFirst = "four hundred";
                break;
            case 5:
                pronunciationFirst = "five hundred";
                break;
            case 6:
                pronunciationFirst = "six hundred";
                break;
            case 7:
                pronunciationFirst = "seven hundred";
                break;
            case 8:
                pronunciationFirst = "eght hundred";
                break;
            case 9:
                pronunciationFirst = "nine hundred";
                break;
            default:
                break;
        }

        decimals = userInput / 10;
        decimals = decimals % 10;
        switch (decimals)
        {
            case 1:
                decimals = userInput % 100;
                switch (decimals)
                {
                    case 10:
                        pronunciationSecond = "ten";
                        break;
                    case 11:
                        pronunciationSecond = "eleven";
                        break;
                    case 12:
                        pronunciationSecond = "twelve";
                        break;
                    case 13:
                        pronunciationSecond = "thirteen";
                        break;
                    case 14:
                        pronunciationSecond = "fourteen";
                        break;
                    case 15:
                        pronunciationSecond = "fifteen";
                        break;
                    case 16:
                        pronunciationSecond = "sixteen";
                        break;
                    case 17:
                        pronunciationSecond = "seventeen";
                        break;
                    case 18:
                        pronunciationSecond = "eighteen";
                        break;
                    case 19:
                        pronunciationSecond = "nineteen";
                        break;
                }
                digits = -1;
                break;
            case 2:
                pronunciationSecond = "twenty ";
                break;
            case 3:
                pronunciationSecond = "thirty";
                break;
            case 4:
                pronunciationSecond = "forty";
                break;
            case 5:
                pronunciationSecond = "fifty";
                break;
            case 6:
                pronunciationSecond = "sixty";
                break;
            case 7:
                pronunciationSecond = "seventy";
                break;
            case 8:
                pronunciationSecond = "eighty";
                break;
            case 9:
                pronunciationSecond = "ninety";
                break;
            default:
                break;
        }

        if (digits != -1)
        {
            digits = userInput % 10;
            switch (digits)
            {
                case 0:
                    pronunciationThird = "zero";
                    break;
                case 1:
                    pronunciationThird = "one";
                    break;
                case 2:
                    pronunciationThird = "two";
                    break;
                case 3:
                    pronunciationThird = "three";
                    break;
                case 4:
                    pronunciationThird = "four";
                    break;
                case 5:
                    pronunciationThird = "five";
                    break;
                case 6:
                    pronunciationThird = "six";
                    break;
                case 7:
                    pronunciationThird = "seven";
                    break;
                case 8:
                    pronunciationThird = "eight";
                    break;
                case 9:
                    pronunciationThird = "nine";
                    break;
                default:
                    break;
            }
        }

        if (pronunciationFirst != null)
        {
            pronunciationWhole = pronunciationWhole + pronunciationFirst;
        }
        if (pronunciationWhole != null && pronunciationSecond != null)
        {
            pronunciationWhole = pronunciationWhole + " and ";
        }
        else if (pronunciationWhole != null && pronunciationThird != null)
        {
            pronunciationWhole = pronunciationWhole + " and ";
        }

        pronunciationWhole = pronunciationWhole + pronunciationSecond + " " + pronunciationThird;
        pronunciationWhole = pronunciationWhole.Trim();
        Console.WriteLine("{0} -> \"{1}\"", userInput, char.ToUpper(pronunciationWhole[0]) + pronunciationWhole.Substring(1));
    }
}
