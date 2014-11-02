using System;

class Neurons
{
    static void Main()
    {
        int[] array = new int[32];
        bool endOfSequence = false;
        int counter = 0;

        int mask = 0;
        int numberToCheck = 0;

        int startPosition = 0;
        int endPosition = 0;

        int a = 0;
        int b = 0;


        while (endOfSequence == false)
        {
            array[counter] = int.Parse(Console.ReadLine());
            if (array[counter] == -1)
            {
                endOfSequence = true;
            }

            counter++;
        }


        for (int i = 0; i < counter - 1; i++)
        {
            Console.WriteLine("0");
        }
    }
}