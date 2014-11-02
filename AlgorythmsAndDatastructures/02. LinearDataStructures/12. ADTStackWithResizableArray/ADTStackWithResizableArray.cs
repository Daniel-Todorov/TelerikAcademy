//Implement the ADT stack as auto-resizable array. 
//Resize the capacity on demand (when no space is 
//available to add / insert a new element).

//NOTE!!! I;ve implemented the basic operations of stacks, mentioned in the prsentation

using System;

class ADTStackWithResizableArray
{
    static void Main()
    {
        ResizableStack<string> stack = new ResizableStack<string>();

        stack.Push("Fred");
        stack.Push("Flinstone");

        Console.WriteLine(stack.Count());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Count());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Contains("Fred"));
        Console.WriteLine(stack.Count());

        stack.Push("Wilma");

        Console.WriteLine(stack.Count());

        stack.Push("Barni");

        Console.WriteLine(stack.Count());

        stack.Clear();

        Console.WriteLine(stack.Count());
    }
}
