//You are given a sequence of positive integer values
//writen into a string, separated by spaces. Write a
//function that reads these values from the given string 
//and calculates their sum. Example:
//string = "43 68 9 23 318" -> result = 461

using System;

class ReadAndCalculateMultipleValuesFromSingleString
{
    static double FunctionToCalculate(string givenString)
    {
        string[] splittedString = null;
        double sum = 0.0;

        splittedString = givenString.Split(' ');

        for (int i = 0; i < splittedString.Length; i++)
        {
            sum = sum + int.Parse(splittedString[i]);
        }

        return sum;
    }

    static void Main()
    {
        string givenString = null;
        double sum = 0.0;

        Console.Write("Please type a string with several numbers separated with intervals and press Enter: ");
        givenString = Console.ReadLine();

        sum = FunctionToCalculate(givenString);

        Console.WriteLine("The sum is {0}.", sum);
    }
}
