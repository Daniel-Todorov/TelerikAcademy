//Write a program that removes from a text file all
//words listed in given another text file. Handle all 
//possible exceptions in your methods.

using System;
using System.IO;

class RemoveMultipleWordsFromFile
{
    static void Main()
    {
        string fileToChange = "firstFile.txt";
        string changerFile = "secondFile.txt";
        string firstText = null;
        string secondText = null;
        string[] wordsNotToMention;

        try
        {
            StreamReader reader = new StreamReader(changerFile);
            using (reader)
            {
                try
                {
                    secondText = reader.ReadToEnd();
                }
                catch (OutOfMemoryException d)
                {
                    Console.WriteLine("The system is out of memory while reading the second file. {0}", d.Message);
                }
                
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading the second file. {0}", a.Message);
        }
        catch (ArgumentNullException b)
        {
            Console.WriteLine("The file path of the second file is NULL. {0}", b.Message);
        }
        catch (ArgumentException c)
        {
            Console.WriteLine("There is problem with the file path fo the second file. {0}", c.Message);
        }

        wordsNotToMention = secondText.Split(' ', '.', '!', ',', ';', '?', ':', '-');

        try
        {
            StreamReader reader = new StreamReader(fileToChange);
            using (reader)
            {
                try
                {
                    firstText = reader.ReadToEnd();
                }
                catch (OutOfMemoryException d)
                {
                    Console.WriteLine("The system is out of memory while reading the first file. {0}", d.Message);
                }          
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading the first file. {0}", a.Message);
        }
        catch (ArgumentNullException b)
        {
            Console.WriteLine("The file path of the first file is NULL. {0}", b.Message);
        }
        catch (ArgumentException c)
        {
            Console.WriteLine("There is problem with the file path fo the first file. {0}", c.Message);
        }

        try
        {
            for (int i = 0; i < wordsNotToMention.Length; i++)
            {
                try
                {
                    firstText = firstText.Replace(wordsNotToMention[i], "");
                }
                catch (Exception b)
                {
                    Console.WriteLine("There is a problem with firstText.Replace(). There is a NULL argument or one of the arguments is invalid. {0}", b);
                }
                
            }
        }
        catch (OverflowException a)
        {
            Console.WriteLine("There is probllem with the length of the firstTextString. {0}", a.Message);
        }

        try
        {
            StreamWriter writer = new StreamWriter(fileToChange);
            using (writer)
            {
                writer.Write(firstText);
            }
        }
        catch (IOException a)
        {        
            Console.WriteLine("An error occured while writing in the first file. {0}", a.Message);
        }

        Console.WriteLine("It is done. Check the default folder for the result!");
    }
}
