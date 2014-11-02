//We are given the following sequence:
//S1 = N;
//S2 = S1 + 1;
//S3 = 2*S1 + 1;
//S4 = S1 + 2;
//S5 = S2 + 1;
//S6 = 2*S2 + 1;
//S7 = S2 + 2;
//...
//Using the Queue<T> class write a program to print 
//its first 50 members for given N.


using System;
using System.Collections.Generic;

class FindNumberOfElementsInASequenceWithQueue
{
    static void Main()
    {
        Console.Write("Please, enter an integer number N: ");
        int N = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(N);

        int numberOfPrintedElements = 0;

        while (true)
        {
            if (numberOfPrintedElements == 50)
            {
                Console.WriteLine();
                return;
            }

            int currentValue = queue.Dequeue();

            queue.Enqueue(currentValue + 1);
            queue.Enqueue(2 * currentValue + 1);
            queue.Enqueue(currentValue + 2);

            Console.Write("{0} ", currentValue);
            numberOfPrintedElements++;
        }
    }
}
