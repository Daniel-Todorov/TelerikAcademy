using System;
using System.IO;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int totalNumberOfInitialLines = int.Parse(Console.ReadLine()); //N
        int numberOfJustifiedSymbols = int.Parse(Console.ReadLine()); //W
        StringBuilder textJoro = new StringBuilder();
        for (int a = 0; a < totalNumberOfInitialLines; a++)
        {
            textJoro.Append(Console.ReadLine());
            textJoro.Append(' ');
        }


        char[] separator = { ' ' };
        string[] removedSpaces = textJoro.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder justifiedLine = new StringBuilder();
        int counterSpaces = 0;
        for (int b = 0; b < removedSpaces.Length; b++)
        {
            while (justifiedLine.Length < numberOfJustifiedSymbols)
            {
                if (b > removedSpaces.Length - 1)
                {
                    justifiedLine = AddWhiteSpaces(justifiedLine, numberOfJustifiedSymbols);
                    break;
                }
                if (removedSpaces[b].Length < numberOfJustifiedSymbols - justifiedLine.Length - 1)
                {
                    justifiedLine.Append(removedSpaces[b]);
                    justifiedLine.Append(" ");
                    b++;
                }
                else if (removedSpaces[b].Length == numberOfJustifiedSymbols - justifiedLine.Length - 1)
                {
                    justifiedLine.Append(removedSpaces[b]);
                    b++;
                }
                else if (removedSpaces[b].Length == numberOfJustifiedSymbols - justifiedLine.Length)
                {
                    justifiedLine.Append(removedSpaces[b]);
                }
                else
                {
                    if (counterSpaces > 0)
                    {
                        break;
                    }
                    justifiedLine = AddWhiteSpaces(justifiedLine, numberOfJustifiedSymbols);
                    counterSpaces++;
                    b--;
                }
            }

            Console.WriteLine(justifiedLine);
            justifiedLine = new StringBuilder();
            
            counterSpaces = 0;
        }


    }

    static StringBuilder AddWhiteSpaces(StringBuilder line, int numberOfSymbols)
    {
        char[] separator = {' '};
        string[] words = line.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int letters = 0;
        for (int i = 0; i < words.Length; i++)
        {
            letters = letters + words[i].Length;
        }
        int neededSpaces = numberOfSymbols - letters;
        int numberOfIntervals = words.Length - 1;
        int[] intervals = new int[numberOfIntervals];
        for (int i = 0; i < numberOfIntervals; i++)
        {
            intervals[i] = neededSpaces / numberOfIntervals;
        }
        StringBuilder result = new StringBuilder();
        if (numberOfIntervals == 0)
        {
            result.Append(words[0]);
            return result;
        }
        neededSpaces = neededSpaces % numberOfIntervals;
        int counter = 0;
        while (neededSpaces > 0)
        {
            intervals[counter] = intervals[counter] + 1;
            neededSpaces = neededSpaces - 1;
            if (counter < intervals.Length)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
        
        for (int i = 0; i < words.Length - 1; i++)
        {
            result.Append(words[i]);
            result.Append(' ', intervals[i]);
        }
        result.Append(words[words.Length - 1]);

        return result;
    }
}
