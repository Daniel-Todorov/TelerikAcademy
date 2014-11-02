//Write a method that asks the user for his name 
//and prints “Hello, <name>” (for example, “Hello, 
//Peter!”). Write a program to test this method.

using System;

public class HelloName
{
    public static string SayHello(string name)
    {
        string hello = "Hello, " + name + "!";
        return hello;
    }

    static void Main()
    {
        string myName = null;

        Console.Write("Please, type your name and press Enter: ");
        myName = Console.ReadLine();

        Console.WriteLine(SayHello(myName));
    }
}
