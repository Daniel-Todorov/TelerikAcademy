//Write a program that compares two text files line
//by line and prints the number of lines that are the 
//same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;
using System.Text;

class CompareTextFiles
{
    static void Main()
    {
        string firstFile = "firstFile.txt";
        string secondFile = "secondFile.txt";
        string firstTextLine = null;
        string secondTextLine = null;
        int sameLineCounter = 0;
        int differentLineCounter = 0;

        try
        {
            StreamReader firstReader = new StreamReader(firstFile);
            StreamReader secondReader = new StreamReader(secondFile);

            firstTextLine = firstReader.ReadLine();
            secondTextLine = secondReader.ReadLine();
            while (firstTextLine != null)
            {
                if (string.Compare(firstTextLine, secondTextLine) == 0)
                {
                    sameLineCounter++;
                }
                else
                {
                    differentLineCounter++;
                }

                firstTextLine = firstReader.ReadLine();
                secondTextLine = secondReader.ReadLine();
            }
        }
        catch (IOException err)
        {
            Console.WriteLine("An error occured while reading the files. {0}", err.Message);
        }

        Console.WriteLine("{0} lines are the same and {1} lines are different.", sameLineCounter, differentLineCounter);
    }
}