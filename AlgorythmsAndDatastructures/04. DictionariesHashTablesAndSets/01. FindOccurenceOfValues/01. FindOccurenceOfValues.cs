//Write a program that counts in a given array of 
//double values the number of occurrences of each 
//value. Use Dictionary<TKey,TValue>.

namespace _01.FindOccurenceOfValues
{
    using System;
    using System.Collections.Generic;

    class FindOccurenceOfValues
    {
        static void Main()
        {
            double[] givenArray = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> occurencesOfElements = MapElementsToOccurence(givenArray);

            foreach (var pair in occurencesOfElements)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
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
