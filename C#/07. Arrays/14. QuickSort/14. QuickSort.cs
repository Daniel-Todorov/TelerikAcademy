//Write a program that sorts an array of strings using
//the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        List<int> initialArray = new List<int>();
        List<int> firstTransitionalArray = new List<int>();
        List<int> secondTransitionalArray = new List<int>();
        int arrayLength = 0;
        int initialPivot = 0;
        int pivot = 0;
        int pivotPosition = 0;

        //Initializing the array which is abotu to be sorted.
        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} -> ", a);
            initialArray.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("");
        }

        //Assigning the value of the pivot (I will start frm the last element in the unsorted array).
        //Saving the value of the initial pivot.
        pivotPosition = arrayLength;
        initialPivot = initialArray[pivotPosition - 1];

        //This loop sorts all the values in the last that are lower than the initial pivot.
        while (pivotPosition > 0)
        {
            pivotPosition = pivotPosition - 1;
            pivot = initialArray[pivotPosition];
            
            //Removing the current pivot from the list.
            initialArray.Remove(pivot);

            //Splitting the current list in two - lower and higher than the current pivot.
            for (int a = 0; a < arrayLength - 1; a++)
            {
                if (initialArray[a] <= pivot)
                {
                    firstTransitionalArray.Add(initialArray[a]);
                }
                else
                {
                    secondTransitionalArray.Add(initialArray[a]);
                }
            }

            //Assembling back together of the splited lists.
            initialArray = new List<int>();
            initialArray.AddRange(firstTransitionalArray);
            pivotPosition = initialArray.Count;
            initialArray.Add(pivot);
            initialArray.AddRange(secondTransitionalArray);
            firstTransitionalArray = new List<int>();
            secondTransitionalArray = new List<int>();
        }

        //The same operation but for all elements higher than the initial pivot.
        pivotPosition = initialArray.IndexOf(initialPivot);
        while (pivotPosition < arrayLength - 1)
        {
            pivotPosition = pivotPosition + 1;
            pivot = initialArray[pivotPosition];

            initialArray.Remove(pivot);
            for (int a = 0; a < arrayLength - 1; a++)
            {
                if (initialArray[a] <= pivot)
                {
                    firstTransitionalArray.Add(initialArray[a]);
                }
                else
                {
                    secondTransitionalArray.Add(initialArray[a]);
                }
            }

            initialArray = new List<int>();
            initialArray.AddRange(firstTransitionalArray);
            initialArray.Add(pivot);
            initialArray.AddRange(secondTransitionalArray);
            firstTransitionalArray = new List<int>();
            secondTransitionalArray = new List<int>();
        }

        //Printing out the result.
        Console.Write("The sorted array looks like this: ");
        foreach (var item in initialArray)
        {
            Console.Write("{0}, ", item);
        }
    }
}