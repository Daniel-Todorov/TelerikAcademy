//10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSumWithCertainAccuracy
{
    static void Main()
    {
        double sum = 1.0;

        for (double i = 1.0; 1 / i > 0.001; i++) // When 1/i is lower than 0.001, the result will be irrelevant for our presicion.
        {
            if (i % 2 == 0)
            {
                sum = sum + 1.0 / i;
            }
            else
            {
                sum = sum - 1.0 / i;
            }
        }
        Console.WriteLine("The sum (with accuracy of 0.001) of the sequence 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... is {0:0.000}", sum);
    }
}
