//Write a program that deletes from given text file all
//odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string fileName = "file.txt";
        string text = null;
        List<string> lines = new List<string>();
        int counter = 0;

        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                text = reader.ReadLine();
                while (text != null)
                {
                    if (counter % 2 == 1)
                    {
                        lines.Add(text);
                    }

                    text = reader.ReadLine();
                    counter++;
                }
            }

            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                foreach (var item in lines)
                {
                    writer.WriteLine(item);
                }
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading or writing the file. {0}", a.Message);
        }

        Console.WriteLine("It is done. Please check the default folder!");
    }
}
