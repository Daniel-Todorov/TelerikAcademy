//Write a program that reads a text file and prints on
//the console its odd lines.

using System;
using System.IO;

class ReadAndPrintOddLines
{
    static void Main()
    {
        string file = "text.txt";
        string text = null;
        int line = 0;

        try
        {
            StreamReader reader = new StreamReader(file);
            using (reader)
            {
                text = reader.ReadLine();
                while (text != null)
                {
                    if (line % 2 == 0)
                    {
                        Console.WriteLine("Line {0}: {1}", line + 1, text);
                    }

                    text = reader.ReadLine();
                    line++;
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("A problem had occured while reading the file.");
        }

    }
}
