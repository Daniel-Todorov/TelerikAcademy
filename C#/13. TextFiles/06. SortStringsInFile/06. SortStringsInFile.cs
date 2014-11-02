//Write a program that reads a text file containing
//a list of strings, sorts them and saves them to 
//another text file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class SortStringsInFile
{
    static void Main()
    {
        string unsortedNamesFile = "unsortedNames.txt";
        string sortedNamesFile = "sortedNames.txt";
        string unsortedList = null;
        string[] arrayToSort;

        try
        {
            StreamReader reader = new StreamReader(unsortedNamesFile);
            StreamWriter writer = new StreamWriter(sortedNamesFile);

            using (reader)
            {
                unsortedList = reader.ReadToEnd();
            }
            arrayToSort = unsortedList.Split(' ');
            Array.Sort(arrayToSort);

            using (writer)
            {
                for (int i = 0; i < arrayToSort.Length; i++)
                {
                    if (i < arrayToSort.Length - 1)
                    {
                        writer.Write("{0} ", arrayToSort[i]);
                    }
                    else
                    {
                        writer.Write("{0}", arrayToSort[i]);
                    }
                }
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading or writing the files. {0}", a.Message);
        }
    }
}
