//Write a program that finds the maximal sequence 
//of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        string[] userString;
        int stringLength = 0;
        int startIndex = 0;
        int maxStartIndex = 0;
        int sequenceLength = 0;
        int maxSequenceLength = 0;
        string stringValue = null;

        Console.Write("Please, type the length of the array and press Enter: ");
        stringLength = int.Parse(Console.ReadLine());
        userString = new string[stringLength];
        for (int a = 0; a < stringLength; a++)
        {
            Console.WriteLine("Please, type element {0} in the array and press Enter: ", a);
            userString[a] = Console.ReadLine();
        }

        startIndex = 0;
        maxStartIndex = 0;
        sequenceLength = sequenceLength + 1;
        maxSequenceLength = sequenceLength;
        stringValue = userString[0];

        for (int a = 1; a < userString.Length; a++)
        {
            if (userString[a].Equals(stringValue))
            {
                sequenceLength = sequenceLength + 1;
                if (maxSequenceLength < sequenceLength)
                {
                    maxSequenceLength = sequenceLength;
                    maxStartIndex = startIndex;
                }
            }
            else
            {
                if (maxSequenceLength < sequenceLength)
                {
                    maxSequenceLength = sequenceLength;
                    maxStartIndex = startIndex;
                }
                sequenceLength = 1;
                stringValue = userString[a];
                startIndex = a;
            }
        }

        for (int a = 0; a < maxSequenceLength; a++)
        {
            Console.Write("{0}, ", userString[maxStartIndex + a]);
        }
    }
}
