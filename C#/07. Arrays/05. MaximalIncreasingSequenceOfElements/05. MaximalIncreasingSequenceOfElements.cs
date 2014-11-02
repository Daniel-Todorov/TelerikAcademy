//Write a program that finds the maximal increasing 
//sequence in an array. Example: 
//{3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequenceOfElements
{
    static void Main()
    {
        int[] userArray;
        int arrayLength = 0;

        int startPosition = 0;
        int maxStartPosition = 0;
        int value = 0;
        int length = 1;
        int maxLength = 1;

        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        userArray = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Element {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        value = userArray[0];

        for (int a = 1; a < arrayLength; a++)
        {
            if (userArray[a] == (userArray[a - 1] + 1))
            {
                length++;
                if (length > maxLength)
                {
                    maxStartPosition = startPosition;
                    maxLength = length;
                }
            }
            else
            {
                value = userArray[a];
                startPosition = 1;
                length = 1;
            }
        }

        for (int a = 0; a < maxLength; a++)
        {
            Console.Write("{0} ", userArray[maxStartPosition + a]);
        }
    }
}
