using System;

class Program
{
    static void Main()
    {
        int L = 0;
        string firstLetter = null;
        int firstNumber = 0;
        string secondLetter = null;
        int secondNumber = 0;
        string line = null;
        int firstTransVariable = 0;
        int secondTransVariable = 0;

        firstLetter = Console.ReadLine();
        secondLetter = Console.ReadLine();
        L = int.Parse(Console.ReadLine());

        switch (firstLetter)
        {
            case "A":
                firstNumber = 1;
                break;
            case "B":
                firstNumber = 2;
                break;
            case "C":
                firstNumber = 3;
                break;
            case "D":
                firstNumber = 4;
                break;
            case "E":
                firstNumber = 5;
                break;
            case "F":
                firstNumber = 6;
                break;
            case "G":
                firstNumber = 7;
                break;
            case "H":
                firstNumber = 8;
                break;
            case "I":
                firstNumber = 9;
                break;
            case "J":
                firstNumber = 10;
                break;
            case "K":
                firstNumber = 11;
                break;
            case "L":
                firstNumber = 12;
                break;
            case "M":
                firstNumber = 13;
                break;
            case "N":
                firstNumber = 14;
                break;
            case "O":
                firstNumber = 15;
                break;
            case "P":
                firstNumber = 16;
                break;
            case "Q":
                firstNumber = 17;
                break;
            case "R":
                firstNumber = 18;
                break;
            case "S":
                firstNumber = 19;
                break;
            case "T":
                firstNumber = 20;
                break;
            case "U":
                firstNumber = 21;
                break;
            case "V":
                firstNumber = 22;
                break;
            case "W":
                firstNumber = 23;
                break;
            case "X":
                firstNumber = 24;
                break;
            case "Y":
                firstNumber = 25;
                break;
            case "Z":
                firstNumber = 26;
                break;
            default:
                break;
        }
        switch (secondLetter)
        {
            case "A":
                secondNumber = 1;
                break;
            case "B":
                secondNumber = 2;
                break;
            case "C":
                secondNumber = 3;
                break;
            case "D":
                secondNumber = 4;
                break;
            case "E":
                secondNumber = 5;
                break;
            case "F":
                secondNumber = 6;
                break;
            case "G":
                secondNumber = 7;
                break;
            case "H":
                secondNumber = 8;
                break;
            case "I":
                secondNumber = 9;
                break;
            case "J":
                secondNumber = 10;
                break;
            case "K":
                secondNumber = 11;
                break;
            case "L":
                secondNumber = 12;
                break;
            case "M":
                secondNumber = 13;
                break;
            case "N":
                secondNumber = 14;
                break;
            case "O":
                secondNumber = 15;
                break;
            case "P":
                secondNumber = 16;
                break;
            case "Q":
                secondNumber = 17;
                break;
            case "R":
                secondNumber = 18;
                break;
            case "S":
                secondNumber = 19;
                break;
            case "T":
                secondNumber = 20;
                break;
            case "U":
                secondNumber = 21;
                break;
            case "V":
                secondNumber = 22;
                break;
            case "W":
                secondNumber = 23;
                break;
            case "X":
                firstNumber = 24;
                break;
            case "Y":
                secondNumber = 25;
                break;
            case "Z":
                secondNumber = 26;
                break;
            default:
                break;
        }

        Console.WriteLine(firstLetter);

        for (int i = 0; i < L - 1; i++)
        {
            if (i == 0)
            {
                firstTransVariable = firstNumber;
                firstNumber = secondNumber;
                if (firstNumber + firstTransVariable < 27)
                {
                    secondNumber = firstTransVariable + firstNumber;
                }
                else
                {
                    secondNumber = (firstTransVariable + firstNumber) % 26;
                }
            }
            else
            {
                if (firstNumber + secondNumber > 26)
                {
                    firstNumber = (firstNumber + secondNumber) % 26;
                }
                else
                {
                    firstNumber = firstNumber + secondNumber;
                }
                if (firstNumber + secondNumber > 26)
                {
                    secondNumber = (firstNumber + secondNumber) % 26;
                }
                else
                {
                    secondNumber = firstNumber + secondNumber;
                }
            }
            switch (firstNumber)
            {
                case 1:
                    firstLetter = "A";
                    break;
                case 2:
                    firstLetter = "B";
                    break;
                case 3:
                    firstLetter = "C";
                    break;
                case 4:
                    firstLetter = "D";
                    break;
                case 5:
                    firstLetter = "E";
                    break;
                case 6:
                    firstLetter = "F";
                    break;
                case 7:
                    firstLetter = "G";
                    break;
                case 8:
                    firstLetter = "H";
                    break;
                case 9:
                    firstLetter = "I";
                    break;
                case 10:
                    firstLetter = "J";
                    break;
                case 11:
                    firstLetter = "K";
                    break;
                case 12:
                    firstLetter = "L";
                    break;
                case 13:
                    firstLetter = "M";
                    break;
                case 14:
                    firstLetter = "N";
                    break;
                case 15:
                    firstLetter = "O";
                    break;
                case 16:
                    firstLetter = "P";
                    break;
                case 17:
                    firstLetter = "Q";
                    break;
                case 18:
                    firstLetter = "R";
                    break;
                case 19:
                    firstLetter = "S";
                    break;
                case 20:
                    firstLetter = "T";
                    break;
                case 21:
                    firstLetter = "U";
                    break;
                case 22:
                    firstLetter = "V";
                    break;
                case 23:
                    firstLetter = "W";
                    break;
                case 24:
                    firstLetter = "X";
                    break;
                case 25:
                    firstLetter = "Y";
                    break;
                case 26:
                    firstLetter = "Z";
                    break;
                default:
                    break;
            }
            switch (secondNumber)
            {
                case 1:
                    secondLetter = "A";
                    break;
                case 2:
                    secondLetter = "B";
                    break;
                case 3:
                    secondLetter = "C";
                    break;
                case 4:
                    secondLetter = "D";
                    break;
                case 5:
                    secondLetter = "E";
                    break;
                case 6:
                    secondLetter = "F";
                    break;
                case 7:
                    secondLetter = "G";
                    break;
                case 8:
                    secondLetter = "H";
                    break;
                case 9:
                    secondLetter = "I";
                    break;
                case 10:
                    secondLetter = "J";
                    break;
                case 11:
                    secondLetter = "K";
                    break;
                case 12:
                    secondLetter = "L";
                    break;
                case 13:
                    secondLetter = "M";
                    break;
                case 14:
                    secondLetter = "N";
                    break;
                case 15:
                    secondLetter = "O";
                    break;
                case 16:
                    secondLetter = "P";
                    break;
                case 17:
                    secondLetter = "Q";
                    break;
                case 18:
                    secondLetter = "R";
                    break;
                case 19:
                    secondLetter = "S";
                    break;
                case 20:
                    secondLetter = "T";
                    break;
                case 21:
                    secondLetter = "U";
                    break;
                case 22:
                    secondLetter = "V";
                    break;
                case 23:
                    secondLetter = "W";
                    break;
                case 24:
                    secondLetter = "X";
                    break;
                case 25:
                    secondLetter = "Y";
                    break;
                case 26:
                    secondLetter = "Z";
                    break;
                default:
                    break;
            }
            line = new String(' ', i);
            Console.WriteLine(firstLetter + line + secondLetter);
        }
    }
}
