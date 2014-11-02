//Sorting an array means to arrange its elements 
//in increasing order. Write a program to sort an 
//array. Use the "selection sort" algorithm: Find the 
//smallest element, move it at the first position, find 
//the smallest from the rest, move it at the second position, ect.

using System;

class SortArrayIncreasingOrder
{
    static void Main()
    {
        int[] userArray;
        int[] orderedArray;
        int arrayLength;
        int minimalValue = 0;
        int maxValue = 0;
        int minPosition = 0;

        Console.Write("Please, type the length of the array to be sorted and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        userArray = new int[arrayLength];
        orderedArray = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        minimalValue = userArray[0];

        maxValue = userArray[0];

        for (int a = 0; a < arrayLength; a++)
        {
            if (maxValue < userArray[a])
            {
                maxValue = userArray[a];
            }
        }

        for (int a = 0; a < arrayLength; a++)
        {
            minimalValue = maxValue;

            for (int b = 0; b < arrayLength; b++)
            {
                if (minimalValue > userArray[b])
                {
                    minimalValue = userArray[b];
                    minPosition = b;
                    
                }
            }
            userArray[minPosition] = maxValue;
            orderedArray[a] = minimalValue;
            
        }

        for (int a = 0; a < arrayLength; a++)
        {
            Console.WriteLine(orderedArray[a]);
        }
    }
}
