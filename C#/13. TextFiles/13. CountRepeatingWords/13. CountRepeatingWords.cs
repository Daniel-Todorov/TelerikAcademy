//Write a program that reads a list of words from a
//file words.txt and finds how many times each of 
//the words is contained in another file test.txt. 
//The result should be written in the file result.txt 
//and the words should be sorted by the number of 
//their occurrences in descending order. Handle all 
//possible exceptions in your methods.

using System;
using System.Text;
using System.IO;

//It gets really ugly if you try to catch every single exception one by one.
//This is why I have handled only the major ones, mostly the IO based.

class CountRepeatingWords
{
    static void Main()
    {
        string wordsFileName = "words.txt";
        string wordsText = null;
        string testFileName = "test.txt";
        string testText = null;
        string resultFileName = "result.txt";
        string[] words;
        string[] test;
        string[,] initialResults;
        int counter = 0;
        int[] sortingArray;
        string[] finalResults;

        try
        {
            StreamReader readWords = new StreamReader(wordsFileName);
            using (readWords)
            {
                wordsText = readWords.ReadToEnd();
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("A problem occured while trying to read 'words.txt'. {0}", a.Message);
        }
        catch (ArgumentException b)
        {
            Console.WriteLine("The name of the file 'words.txt' is not correct. {0}", b.Message);
        }
        catch (OutOfMemoryException c)
        {
            Console.WriteLine("The file 'words.txt' is too big. {0}", c.Message);
        }
        words = wordsText.Split(' ', ',', '.', '!', '?', ':', ';');

        try
        {
            StreamReader readTest = new StreamReader(testFileName);
            using (readTest)
            {
                testText = readTest.ReadToEnd();
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("A problem occured while trying to read 'test.txt'. {0}", a.Message);
        }
        catch (ArgumentException b)
        {
            Console.WriteLine("The name of the file 'test.txt' is not correct. {0}", b.Message);
        }
        catch (OutOfMemoryException c)
        {
            Console.WriteLine("The file 'test.txt' is too big. {0}", c.Message);
        }
        test = testText.Split(' ', ',', '.', '!', '?', ':', ';');

        initialResults = new string[2, words.GetLength(0)];

        for (int col = 0; col < initialResults.GetLength(1); col++)
        {
            initialResults[0, col] = words[col];
        }

        for (int col = 0; col < initialResults.GetLength(1); col++)
        {
            for (int i = 0; i < test.Length; i++)
            {
                if (initialResults[0, col].CompareTo(test[i]) == 0)
                {
                    counter++;
                }
            }
            initialResults[1, col] = counter.ToString();
            counter = 0;
        }

        sortingArray = new int[initialResults.GetLength(1)];

        for (int i = 0; i < sortingArray.Length; i++)
        {
            sortingArray[i] = int.Parse(initialResults[1, i]);
        }

        Array.Sort(sortingArray);

        finalResults = new string[initialResults.GetLength(1)];

        for (int i = 0; i < finalResults.Length; i++)
        {
            for (int col = 0; col < initialResults.GetLength(1); col++)
            {
                if (sortingArray[i].ToString().CompareTo(initialResults[1, col]) == 0)
                {
                    finalResults[i] = "The word '" + initialResults[0, col] + "' repeats " + initialResults[1, col] + " times in 'test.txt'";
                }
            }
        }

        try
        {
            StreamWriter writerResult = new StreamWriter(resultFileName);
            using (writerResult)
            {
                for (int i = finalResults.Length - 1; i >= 0; i--)
                {
                    writerResult.WriteLine(finalResults[i]);
                }
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("A problem occured while trying to write 'result.txt'. {0}", a.Message);
        }
        catch (ArgumentException b)
        {
            Console.WriteLine("The name of the file 'result.txt' is not correct. {0}", b.Message);
        }
        catch (UnauthorizedAccessException c)
        {
            Console.WriteLine("Unauthorized access while writing 'result.txt'. {0}", c.Message);
        }

        Console.WriteLine("Aaaaand, it is done. Please check the default directory for the result file.");
    }
}