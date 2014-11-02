//Write a method that return the maximal element
//in a portion of array of integers starting at given 
//index. Using it write another method that sorts an 
//array in ascending / descending order.

//NOTE! To write an ascending sort will require a new algorith for FindMaximalValue method.
using System;
using System.Collections.Generic;

class SortByMaximalElement
{
    //This is the method that returns the maximal element in a portion of the array.
    static int FindMaximalValue(int[] array, int startingIndex)
    {
        int maxValue = 0;
        int maxValueIndex = 0;
        for (int i = startingIndex; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxValueIndex = i;
            }
        }

        return maxValueIndex;
    }

    //This is the method that sorts in ascending order.
    static int[] SortDescending(int[] array)
    {
        int transValue = 0;
        int transIndex = 0;
        int[] result = new int[array.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            transValue = result[i];
            transIndex = FindMaximalValue(result, i);
            result[i] = result[transIndex];
            result[transIndex] = transValue;
        }

        return result;
    }

    static void Main()
    {
        int[] userArray = Utilities.GenerateIntegerArray();
        int[] sortedArray = new int[userArray.Length];

        sortedArray = SortDescending(userArray);

        Console.Write("The array in descending order is: ");
        foreach (var item in sortedArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
