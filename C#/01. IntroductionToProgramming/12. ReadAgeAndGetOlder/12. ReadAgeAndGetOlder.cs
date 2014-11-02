using System;

class ReadAgeAndGetOlder
{
    static void Main()
    {
        int currentAge;

        Console.WriteLine("Please, write your age and press Enter:");
        currentAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old", currentAge + 10);
    }
}

