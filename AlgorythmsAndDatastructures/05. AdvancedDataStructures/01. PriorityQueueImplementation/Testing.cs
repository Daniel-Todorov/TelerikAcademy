using System;
using System.Linq;

public class Testing
{
    public static void Main()
    {
        PriorityQueue<int> testQueue = new PriorityQueue<int>();

        testQueue.Enqueue(5);
        testQueue.Enqueue(10);
        testQueue.Enqueue(-5);
        testQueue.Enqueue(1);
        testQueue.Enqueue(13);
        testQueue.Enqueue(13);
        testQueue.Enqueue(0);
        testQueue.Enqueue(25);

        Console.WriteLine(testQueue.Peek());

        Console.WriteLine();

        while (testQueue.Count > 0)
        {
            Console.WriteLine(testQueue.Dequeue());
        }

        Console.WriteLine();
    }
}