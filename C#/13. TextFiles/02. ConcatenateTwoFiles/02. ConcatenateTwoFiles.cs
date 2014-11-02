//Write a program that concatenates two text files
//into another text file.

using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        string firstText = null;
        try
        {
            StreamReader firstFile = new StreamReader("firstFile.txt");

            using (firstFile)
            {
                firstText = firstFile.ReadToEnd();
            }
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while reading the first file");
        }

        string secondText = null;
        try
        {
            StreamReader secondFile = new StreamReader("secondFile.txt");
            using (secondFile)
            {
                secondText = secondFile.ReadToEnd();
            }
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while reading the second file");
        }
        
        try
        {
            StreamWriter concatenatedFile = new StreamWriter("concatenatedFile.txt");
            using (concatenatedFile)
            {
                concatenatedFile.Write("{0} + {1}", firstText, secondText);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while writing at the concatenated file");
        }

        Console.WriteLine("We are done!");
    }
}
