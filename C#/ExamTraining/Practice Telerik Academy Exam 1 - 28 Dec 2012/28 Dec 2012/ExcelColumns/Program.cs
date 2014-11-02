using System;

class Program
{
    static void Main()
    {
        long N = 0;
        long index = 0;

        N = long.Parse(Console.ReadLine());
        long[] excelIndex = new long[N];

        for (long i = 0; i < N; i++)
        {
            switch (Console.ReadLine())
            {
                case "A":
                    excelIndex[i] = 1;
                    break;
                case "B":
                    excelIndex[i] = 2;
                    break;
                case "C":
                    excelIndex[i] = 3;
                    break;
                case "D":
                    excelIndex[i] = 4;
                    break;
                case "E":
                    excelIndex[i] = 5;
                    break;
                case "F":
                    excelIndex[i] = 6;
                    break;
                case "G":
                    excelIndex[i] = 7;
                    break;
                case "H":
                    excelIndex[i] = 8;
                    break;
                case "I":
                    excelIndex[i] = 9;
                    break;
                case "J":
                    excelIndex[i] = 10;
                    break;
                case "K":
                    excelIndex[i] = 11;
                    break;
                case "L":
                    excelIndex[i] = 12;
                    break;
                case "M":
                    excelIndex[i] = 13;
                    break;
                case "N":
                    excelIndex[i] = 14;
                    break;
                case "O":
                    excelIndex[i] = 15;
                    break;
                case "P":
                    excelIndex[i] = 16;
                    break;
                case "Q":
                    excelIndex[i] = 17;
                    break;
                case "R":
                    excelIndex[i] = 18;
                    break;
                case "S":
                    excelIndex[i] = 19;
                    break;
                case "T":
                    excelIndex[i] = 20;
                    break;
                case "U":
                    excelIndex[i] = 21;
                    break;
                case "V":
                    excelIndex[i] = 22;
                    break;
                case "W":
                    excelIndex[i] = 23;
                    break;
                case "X":
                    excelIndex[i] = 24;
                    break;
                case "Y":
                    excelIndex[i] = 25;
                    break;
                case "Z":
                    excelIndex[i] = 26;
                    break;
                default:
                    break;
            }
        }

        for (double i = 0; i < N; i++)
        {
            index = index + excelIndex[N - 1 - (long)i] * (long)(Math.Pow(26, i));
        }
        Console.WriteLine(index);
    }
}
