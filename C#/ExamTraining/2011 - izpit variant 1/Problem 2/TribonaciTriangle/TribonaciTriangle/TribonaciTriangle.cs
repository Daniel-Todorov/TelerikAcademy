using System;

class TribonaciTriangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long numberOfLines = long.Parse(Console.ReadLine());
        
        int length = 0;
        for (int a = 1; a <= numberOfLines; a++)
			{
			 length = length + a;
			}
        long[] sequenceOfTribonacci = new long [length];
        sequenceOfTribonacci[0] = firstNumber;
        sequenceOfTribonacci[1] = secondNumber;
        sequenceOfTribonacci[2] = thirdNumber;

        for (int b = 0; b < length; b++)
        {
            if (b > 2)
            {
                sequenceOfTribonacci[b] = sequenceOfTribonacci[b-1] + sequenceOfTribonacci [b-2] + sequenceOfTribonacci[b-3];
            }
        }
        
        int d = 0;
        string line = null;
        for (int c = 1; c <= numberOfLines; c++)
        {
            for (int e = 0; e < c; e++)
            {
                line = line + " " + sequenceOfTribonacci[d];
                d++;
            }
            Console.WriteLine(line.Trim());
            line = null;
        }
    }
}
