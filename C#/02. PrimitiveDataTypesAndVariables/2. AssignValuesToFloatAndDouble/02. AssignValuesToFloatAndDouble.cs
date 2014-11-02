//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class AssignValuesToFloatAndDouble
{
    static void Main()
    {
        //float firstNumberFloat = 34.567839023F; <- If you do that, the number will be rounded to 34.56784 (float can show only 7 digits in total)
        float secondNumberFloat = 12.345F;
        //float thirdNumberFloat = 8923.1234857F; <- If you do that, the number will be rounded to 8923.123 (float can show only 7 digits in total)
        float forthNumberFloat = 3456.091F;

        Console.WriteLine("Only two of the four values can be assigned as float type without losing precision: {0} and {1}", secondNumberFloat, forthNumberFloat);

        double firstNumberDouble = 34.567839023;
        double secondNumberDouble = 12.345;
        double thirdNumberDouble = 8923.1234857;
        double forthNumberDouble = 3456.091;

        Console.WriteLine("All four values can be assigned as doule type without losing precision: {0}, {1}, {2} and {3}", firstNumberDouble, secondNumberDouble,thirdNumberDouble, forthNumberDouble);
    }
}