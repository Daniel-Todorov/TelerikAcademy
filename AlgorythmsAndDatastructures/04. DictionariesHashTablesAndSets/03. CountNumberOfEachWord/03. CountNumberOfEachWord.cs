//Write a program that counts how many times each 
//word from given text file words.txt appears in it. 
//The character casing differences should be ignored. 
//The result words should be ordered by their number 
//of occurrences in the text. 

namespace _03.CountNumberOfEachWord
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text.RegularExpressions;

    public class CountNumberOfEachWord
    {
        public static void Main()
        {
            string filePath = "test.txt";
            StreamReader reader = new StreamReader(filePath);

            string fileContent = null;

            try
            {
                using (reader)
                {
                    fileContent = reader.ReadToEnd().ToString();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Make sure the file path is correct.");
            }

            string[] words = Regex.Split(fileContent.ToLower(), "\\W+|\\d").Where(word => !string.IsNullOrEmpty(word)).ToArray();

            Dictionary<string, int> result = MapElementsToOccurence(words)
                .OrderBy(pair => pair.Value).
                ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static Dictionary<T, int> MapElementsToOccurence<T>(T[] arrayOfElements)
        {
            Dictionary<T, int> countHolder = new Dictionary<T, int>();

            foreach (var item in arrayOfElements)
            {
                if (countHolder.ContainsKey(item))
                {
                    countHolder[item]++;
                }
                else
                {
                    countHolder[item] = 1;
                }
            }

            return countHolder;
        }
    }
}
