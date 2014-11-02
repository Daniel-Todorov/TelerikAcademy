//Declare two string variables and assign the with "Hello" and "World".
//Declare an object variable and assign it witht he concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class AssignStringsAndObjectVariables
{
    static void Main()
    {
        string helloString;
        string worldString;
        helloString = "Hello";
        worldString = "World";

        object helloWorldObject;
        helloWorldObject = helloString + " " + worldString;

        string helloWorldString = (string)helloWorldObject;
        Console.WriteLine(helloWorldString);
    }
}
