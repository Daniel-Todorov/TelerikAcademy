//Write a program that reads two arrays from the 
//console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        string[] firstString;
        string[] secondString;
        int firstStringLength = 0;
        int secondStringLength = 0;

        //Initilize the first array
        Console.Write("Please, type the length of the first array and press Enter: ");
        firstStringLength = int.Parse(Console.ReadLine());
        firstString = new string[firstStringLength];
        for (int a = 0; a < firstStringLength; a++)
        {
            Console.WriteLine("Please, type element {0} in the first array and press Enter: ", a);
            firstString[a] = Console.ReadLine();
        }

        //Initilize the first array
        Console.Write("Please, type the length of the second array and press Enter: ");
        secondStringLength = int.Parse(Console.ReadLine());
        secondString = new string[secondStringLength];
        for (int a = 0; a < secondStringLength; a++)
        {
            Console.WriteLine("Please, type element {0} in the second array and press Enter: ", a);
            secondString[a] = Console.ReadLine();
        }

        //check if length is different
        if (firstStringLength > secondStringLength)
        {
            Console.WriteLine("First array is longer than the second array!");
            return;
        }
        if (firstStringLength < secondStringLength)
        {
            Console.WriteLine("First array is shorter than the second array!");
            return;
        }

        //compare elements in the array
        for (int a = 0; a < firstStringLength; a++)
        {
            if (!(firstString[a].Equals(secondString[a])))
            {
                Console.WriteLine("The two arrays are NOT equal!");
                return;
            }
        }

        Console.WriteLine("The two arrays ARE equal!");
    }
}
