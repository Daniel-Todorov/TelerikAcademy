//* Write a program that sorts an array of integers 
//using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        //I am going to use Lists for the sorting.
        List<List<int>> firstArray;
        List<List<int>> secondaryArray;
        int arrayLength = 0;

        //The odd array is used to store value if the first array has odd number of elements in it.
        List<int> oddArray;

        //The user types the array to be sorted. 
        //The idea of the merge sort is to have the array splited into lists with one element, so I do it when the user initializes the array.
        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        firstArray = new List<List<int>>();
        for (int a = 0; a < arrayLength; a++)
        {
            firstArray.Add(new List<int>());
            Console.Write("Position {0} -> ", a);
            firstArray[a].Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("");
        }

        //Merge sort requires at each step 2 small arrays to be combined into one larger array untill there is only one big array left.
        //That's why when the number of the arrays reaches 1 the while loop should break.
        while (firstArray.Count > 1)
        {
            secondaryArray = new List<List<int>>();
            oddArray = new List<int>();

            //I check if the number of small arrays is odd. If it is, I store the last smal array in another list and remove it from the main list.
            if (firstArray.Count % 2 > 0)
            {
                oddArray = firstArray[firstArray.Count - 1];
                firstArray.RemoveAt(firstArray.Count - 1);
            }

            //I need to make all small arrays that remain into pairs and then merge and sort them.
            //The pairs are every A element with every A + 1 element.
            //Due to the pairing, after each iteration, A should increase with 2.
            for (int a = 0; a < firstArray.Count; a = a + 2)
            {
                secondaryArray.Add(new List<int>());

                //While every every element in the pair has some unmerged values, I compare the first elements
                //which are supposed to be the lowest in their arrays.
                while (firstArray[a].Count > 0 && firstArray[a + 1].Count > 0)
                {
                    //If the first element in the first array is bigger or equal, I add it to the big array and remove it from the first small array.
                    if (firstArray[a][0] > firstArray[a + 1][0] || firstArray[a][0] == firstArray[a + 1][0])
                    {
                        secondaryArray[secondaryArray.Count - 1].Add(firstArray[a + 1][0]);
                        firstArray[a + 1].RemoveAt(0);
                    }
                    //If the first element in the second array is bigger, then I add it to the big array and remove it from the second small array.
                    else if (firstArray[a][0] < firstArray[a + 1][0])
                    {
                        secondaryArray[secondaryArray.Count - 1].Add(firstArray[a][0]);
                        firstArray[a].RemoveAt(0);
                    }
                }

                //Eventually one of the small arrays will run out of elements. 
                //Every remaining element will have higher value than any of the elements in the big array.
                // That's why with two while loops I check which array still has elements which are not merged and merge them at the last positons in the big array.
                while (firstArray[a].Count > 0)
                {
                    secondaryArray[secondaryArray.Count - 1].Add(firstArray[a][0]);
                    firstArray[a].RemoveAt(0);
                }

                while (firstArray[a + 1].Count > 0)
                {
                    secondaryArray[secondaryArray.Count - 1].Add(firstArray[a + 1][0]);
                    firstArray[a + 1].RemoveAt(0);
                }
            }

            //After the small arrays are depleted of elements, I check if we have an odd array and add it to the list of big arrays of the current iteration.
            if (oddArray.Count > 0)
            {
                secondaryArray.Add(oddArray);
            }

            //Finally, the initial list of arrays takes the values of the list of bigger arrays from the current iteration.
            //In this can it is safe to use "=" because at the start of each iteration I reinitialize secondArray.
            firstArray = secondaryArray;
        }

        //Printing the result at the console.
        foreach (var item in firstArray[0])
        {
            Console.Write("{0}, ", item);
        }
    }
}
