//Write a program that reads a text file and inserts
//line numbers in front of each of its lines. The result 
//should be written to another text file.

using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        string fileWithoutNumbers = "withoutNumbers.txt";
        string fileWithNumbers = "withNumbers.txt";
        string lineText;
        int lineCounter = 0;

        try
        {
            StreamReader withoutNumbers = new StreamReader(fileWithoutNumbers);
            StreamWriter withnumbers = new StreamWriter(fileWithNumbers);
            using (withoutNumbers)
            {     
                lineText = withoutNumbers.ReadLine();
                using (withnumbers)
                {
                    while (lineText != null)
                    {
                        withnumbers.WriteLine("{0, 2} {1}", lineCounter + 1, lineText);

                        lineText = withoutNumbers.ReadLine();
                        lineCounter++;
                    }
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("An error had occured while reading or writing the files.");
        }

        Console.WriteLine("We are done!");
    }
}
