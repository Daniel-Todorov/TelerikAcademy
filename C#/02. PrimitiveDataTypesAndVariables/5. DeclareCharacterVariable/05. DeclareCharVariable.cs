//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexidecimal reprsentation of 72.

using System;

class Program
{
    static void Main()
    {
        char charVariable;
        charVariable = '\u0048';
        Console.WriteLine(charVariable);
    }
}
