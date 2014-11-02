//Write a program to check if in a given expression
//the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class CheckBrackets
{
    static void Main()
    {
        Console.Write("Please, type the expression and press Enter: ");
        string expression = Console.ReadLine();
        int openingBracketsCount = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openingBracketsCount++;
            }
            else if (expression[i] == ')')
            {
                openingBracketsCount--;
            }
            if (openingBracketsCount < 0)
            {
                break;
            }
        }

        if (openingBracketsCount == 0)
        {
            Console.WriteLine("The brackets are placed correctly");
        }
        else
        {
            Console.WriteLine("The brackets are NOT places correctly");
        }
    }
}