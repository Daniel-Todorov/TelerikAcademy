using System;

class SpecialValue
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[][] pattern = new int[N][];
        string[][] stringPatterns = new string[N][];
        for (int i = 0; i < stringPatterns.GetLength(0); i++)
        {
            stringPatterns[i] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        }

        pattern = ConvertStringPattern(stringPatterns);

        ulong specialValue = 0;
        ulong specialValueMax = 0;
        int oldValue = 0;

        for (int row = 0; row < pattern.GetLength(0); row++)
        {
            for (int col = 0; col < pattern[0].Length; col++)
            {
                int currentRow = row;
                int currentCol = col;
                while (pattern[currentRow][currentCol] >= 0 && pattern[currentRow][currentCol] != 9999)
                {
                    oldValue = pattern[currentRow][currentCol];
                    pattern[currentRow][currentCol] = 9999;
                    specialValue++;
                    currentRow++;
                    currentCol = oldValue;
                }
                if (pattern[currentRow][currentCol] == 9999)
                {
                    break;
                }
                if (pattern[currentRow][currentCol] < 0)
                {
                    specialValue = specialValue + (ulong)(pattern[currentRow][currentCol] * (-1));
                }
                if (specialValue > specialValueMax)
                {
                    specialValueMax = specialValue;
                }

                specialValue = 0;
            }
        }

        Console.WriteLine(specialValueMax);
    }

    static int[][] ConvertStringPattern(string[][] input)
    {
        int[][] result = new int[input.GetLength(0)][];

        for (int i = 0; i < input.GetLength(0); i++)
        {
            result[i] = new int[input[i].Length];
        }

        for (int row = 0; row < input.GetLength(0); row++)
        {
            for (int col = 0; col < input[row].Length; col++)
            {
                result[row][col] = int.Parse(input[row][col]);
            }
        }

        return result;
    }
}
