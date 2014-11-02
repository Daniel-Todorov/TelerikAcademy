//Sort 3 real values in descending order using nested if statements.

using System;

class SortNumbers
{
    static void Main()
    {
        int firstRealValue = 0;
        int secondRealValue = 0;
        int thirdRealValue = 0;

        Console.Write("Please, type the first real value to order and press Enter: ");
        firstRealValue = int.Parse(Console.ReadLine());
        Console.Write("Please, type the second real value to order and press Enter: ");
        secondRealValue = int.Parse(Console.ReadLine());
        Console.Write("Please, type the third real value to order and press Enter: ");
        thirdRealValue = int.Parse(Console.ReadLine());

        if (firstRealValue > secondRealValue)
        {
            if (secondRealValue > thirdRealValue)
            {
                Console.WriteLine("{0}, {1}, {2}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }
        if (firstRealValue > thirdRealValue)
        {
            if (thirdRealValue > secondRealValue)
            {
                Console.WriteLine("{0}, {2}, {1}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }

        if (secondRealValue > firstRealValue)
        {
            if (firstRealValue > thirdRealValue)
            {
                Console.WriteLine("{1}, {0}, {2}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }
        if (secondRealValue > thirdRealValue)
        {
            if (thirdRealValue > firstRealValue)
            {
                Console.WriteLine("{1}, {2}, {0}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }
        if (thirdRealValue > firstRealValue)
        {
            if (firstRealValue > secondRealValue)
            {
                Console.WriteLine("{2}, {0}, {1}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }
        if (thirdRealValue > secondRealValue)
        {
            if (secondRealValue > firstRealValue)
            {
                Console.WriteLine("{2}, {1}, {0}", firstRealValue, secondRealValue, thirdRealValue);
            }
        }
    }
}
