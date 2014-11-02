//Write a program that compares two char arrays 
//lexicographically (letter by letter).

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        char[] firstArray;
        char[] secondArray;
        int firstArrayLength = 0;
        int secondArrayLength = 0;

        //Initilize the first array
        Console.Write("Please, type the length of the first array and press Enter: ");
        firstArrayLength = int.Parse(Console.ReadLine());
        firstArray = new char[firstArrayLength];
        for (int a = 0; a < firstArrayLength; a++)
        {
            Console.WriteLine("Please, type element {0} in the first array and press Enter: ", a);
            firstArray[a] = char.Parse(Console.ReadLine());
        }

        //Initilize the first array
        Console.Write("Please, type the length of the second array and press Enter: ");
        secondArrayLength = int.Parse(Console.ReadLine());
        secondArray = new char[secondArrayLength];
        for (int a = 0; a < secondArrayLength; a++)
        {
            Console.WriteLine("Please, type element {0} in the second array and press Enter: ", a);
            secondArray[a] = char.Parse(Console.ReadLine());
        }

        for (int a = 0; a < Math.Min(firstArrayLength, secondArrayLength); a++)
        {
            if (firstArray[a] < secondArray[a])
            {
                Console.WriteLine("The first array comes before the second array!");
                return;
            }
            if (firstArray[a] > secondArray[a])
            {
                Console.WriteLine("The second array comes before the first array!");
                return;
            }
        }
        if (firstArrayLength > secondArrayLength)
        {
            Console.WriteLine("The second array comes before the first array!");
            return;
        }
        if (firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first array comes before the second array!");
            return;
        }
        Console.WriteLine("The two char arrays ARE EQUAL!");
    }
}
