//Write a program that deletes from a text file all
//words that start with the prefix "test". Words
//contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsWithPrefix
{
    static void Main()
    {
        string fileName = "file.txt";
        string text = null;

        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                text = reader.ReadToEnd();
            }

            text = Regex.Replace(text, @"(\b)test((\w)*)(\b)", "");

            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(text);
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading or writing the file. {0}", a.Message);
        }

        Console.WriteLine("It is done. Please, check the default folder!");
    }
}