//Write a program that finds the index of given 
//element in a sorted array of integers by using the 
//binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] userArray;
        int userArrayLength = 0;
        int searchingValue = 0;
        int middleValue = 0;
        int subArrayStart = 0;
        int subArrayEnd = 0;
        bool valueNotFound = true;

        Console.Write("Please, type the length of the array and press Enter: ");
        userArrayLength = int.Parse(Console.ReadLine());
        userArray = new int[userArrayLength];
        for (int a = 0; a < userArrayLength; a++)
        {
            Console.Write("Position {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        Array.Sort(userArray);

        Console.Write("Please, type the value you want to search for and press Enter: ");
        searchingValue = int.Parse(Console.ReadLine());

        subArrayStart = 0;
        subArrayEnd = userArrayLength - 1;
        while (valueNotFound)
        {
            if (middleValue != subArrayStart + (subArrayEnd - subArrayStart) / 2)
            {
                middleValue = subArrayStart + (subArrayEnd - subArrayStart) / 2;
            }
            else
            {
                middleValue++;
            }
            if (userArray[middleValue] == searchingValue)
            {
                valueNotFound = false;
            }
            else if (userArray[middleValue] > searchingValue)
            {
                subArrayEnd = middleValue;
            }
            else if (userArray[middleValue] < searchingValue)
            {
                subArrayStart = middleValue;
            }
        }

        Console.WriteLine("The value {0} is at position {1}.", searchingValue, middleValue);
    }
}
