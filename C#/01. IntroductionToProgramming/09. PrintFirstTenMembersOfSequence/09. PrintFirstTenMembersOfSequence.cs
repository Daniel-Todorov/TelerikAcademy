using System;

class PrintFirstTenMembersOfSequence
{
    static void Main()
    {

        int startNumber = 2;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(startNumber);
            if (startNumber % 2 == 0)
            {
                startNumber = (startNumber + 1) * (-1);
            }
            else
            {
                startNumber = (startNumber - 1) * (-1);
            }
        }
    }
}

