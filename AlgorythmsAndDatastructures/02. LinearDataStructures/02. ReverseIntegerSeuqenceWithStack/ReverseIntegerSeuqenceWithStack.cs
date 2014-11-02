//Write a program that reads N integers from the 
//console and reverses them using a stack. Use the 
//Stack<int> class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseIntegerSeuqenceWithStack
{
    static void Main()
    {
        Console.Write("How much integers you'd like to type? => ");
        int numberOfIntegers = int.Parse(Console.ReadLine());

        Stack<int> sequence = new Stack<int>();
        for (int i = 0; i < numberOfIntegers; i++)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            sequence.Push(input);
        }

        Console.WriteLine();

        while (sequence.Count > 0)
        {
            Console.Write(sequence.Pop() + " ");
        }

        Console.WriteLine();
    }
}
