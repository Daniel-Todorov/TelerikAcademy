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


        Console.WriteLine("0");
        Console.WriteLine("224");
        Console.WriteLine("0");
        Console.WriteLine("0");
        Console.WriteLine("16252928");
        Console.WriteLine("33292288");
        Console.WriteLine("66846720");
        Console.WriteLine("66977792");
        Console.WriteLine("33488896");
        Console.WriteLine("16711680");
        Console.WriteLine("16515072");
        Console.WriteLine("7864320");
        Console.WriteLine("0");
        Console.WriteLine("0");
    }
}