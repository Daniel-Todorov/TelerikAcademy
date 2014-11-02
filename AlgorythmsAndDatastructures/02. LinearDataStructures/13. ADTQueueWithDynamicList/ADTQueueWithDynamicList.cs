//Implement the ADT queue as dynamic linked list. 
//Use generics (LinkedQueue<T>) to allow storing 
//different data types in the queue.

//NOTE!!! I used the linked list from problem 11.
// I've implemented the basic functionalities mentioned in the presentation.

using System;

class ADTQueueWithDynamicList
{
    static void Main()
    {
        LinkedQueue<string> names = new LinkedQueue<string>();

        names.Enqueue("Misho");
        names.Enqueue("Birata");

        Console.WriteLine(names.Dequeue());
        Console.WriteLine(names.Peek());
        Console.WriteLine(names.Count());
        Console.WriteLine(names.Contains("Misho"));
        Console.WriteLine(names.Contains("Birata"));
    }
}
