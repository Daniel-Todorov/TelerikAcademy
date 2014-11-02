//Write a program that replaces all occurrences of
//the substring "start" with the substring "finish" in a 
//text file. Ensure it will work with large files (e.g. 100 
//MB).

using System;
using System.IO;
using System.Text;

class ReplaceSubstringInTextFile
{
    static void Main()
    {
        string fileName = "startFinishFile.txt";
        string text = null;
        string initial = "start";
        string changeTo = "finish";

        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                text = reader.ReadToEnd();
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading the file. {0}", a.Message);
        }

        text = text.Replace(initial, changeTo);

        try
        {
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(text);
            }
        }
        catch (IOException b)
        {
            Console.WriteLine("An error occured while writing the file. {0}", b.Message);
        }

        Console.WriteLine("It is done!");
    }
}
