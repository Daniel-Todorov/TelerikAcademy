//Write a program that finds the most frequent 
//number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class MostFrequentNumberInArray
{
    static void Main()
    {
        int[] userArray;
        int arrayLength = 0;
        int mostFrequentNumber = 0;
        int frequency = 0;
        int maxfrequency = 0;

        //Initilize the custom array
        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        userArray = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} -> ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        //Loops to check frequency
        for (int a = 0; a < arrayLength; a++)
        {
            for (int b = 0; b < arrayLength; b++)
            {
                if (userArray[a] == userArray[b])
                {
                    frequency++;
                }
            }
            if (frequency > maxfrequency)
            {
                maxfrequency = frequency;
                mostFrequentNumber = userArray[a];
            }
            frequency = 0;
        }

        Console.WriteLine("The number which repeats the most is {0}. It repeats {1} times.", mostFrequentNumber, maxfrequency);
    }
}
