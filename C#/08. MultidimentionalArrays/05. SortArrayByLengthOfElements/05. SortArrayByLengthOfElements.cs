//You are given an array of strings. Write a method 
//that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;
using System.Collections.Generic;

class SortArrayByLengthOfElements
{
    //The method uses SelectionSort to order the array's elements accourding to their lengths.
    static string[] SortArray (string[] i)
    {
        string[] orderedArray = new string[i.Length];
        string minimalValue = null;
        string maxValue = null;
        int minPosition = 0;

        minimalValue = i[0];

        maxValue = i[0];

        for (int a = 0; a < i.Length; a++)
        {
            if (maxValue.Length < i[a].Length)
            {
                maxValue = i[a];
            }
        }

        for (int a = 0; a < i.Length; a++)
        {
            minimalValue = maxValue;

            for (int b = 0; b < i.Length; b++)
            {
                if (minimalValue.Length > i[b].Length)
                {
                    minimalValue = i[b];
                    minPosition = b;
                }
            }
            i[minPosition] = maxValue;
            orderedArray[a] = minimalValue;
        }

        return orderedArray;
    }

    static void Main()
    {
        int arrayLength = 0;
        string[] array;
        string[] sortedArray;

        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        array = new string[arrayLength];
        sortedArray = new string[arrayLength];
        Console.WriteLine();
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Array {0} -> ", i);
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();

        sortedArray = SortArray(array);

        Console.WriteLine();
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Sorted array {0} -> ", sortedArray[i]);
            Console.WriteLine();
        }
    }
}