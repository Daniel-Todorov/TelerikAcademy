//Write a program that finds the sequence of 
//maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan 
//through the elements of the array)?

using System;

class MaxSumSequence
{
    static void Main()
    {
        int[] userArray;
        int arrayLength = 0;
        int startPosition = 0;
        int endPosition = 0;
        int sum = 0;
        int maxsum = 0;

        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        userArray = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        for (int a = 0; a < arrayLength; a++)
        {
            sum = userArray[a];
            for (int b = a + 1; b < arrayLength; b++)
            {
                sum = sum + userArray[b];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    startPosition = a;
                    endPosition = b;
                }
            }
        }

        for (int a = 0; a < endPosition - startPosition + 1; a++)
        {
            Console.WriteLine("{0} ", userArray[startPosition + a]);
        }
    }
}

//I am sorry but I have no idea how to make it with one loop only :(