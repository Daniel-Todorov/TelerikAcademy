//Write a program that extracts from a given sequence 
//of strings all elements that present in it odd number 
//of times. 

namespace _02.GetElementsWithOddOccurence
{
    using System;
    using System.Collections.Generic;

    public class GetElementsWithOddOccurence
    {
        public static void Main()
        {
            string[] sequenceOfStrings = new string[] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Dictionary<string, int> countOfOccurences = MapElementsToOccurence(sequenceOfStrings);

            foreach (var pair in countOfOccurences)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }

            Console.WriteLine();
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
