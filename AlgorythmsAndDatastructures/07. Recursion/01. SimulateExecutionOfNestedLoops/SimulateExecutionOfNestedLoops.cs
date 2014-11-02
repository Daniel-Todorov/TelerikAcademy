//Write a recursive program that simulates the 
//execution of n nested loops from 1 to n.

namespace _01.SimulateExecutionOfNestedLoops
{
    using System;

    public class SimulateExecutionOfNestedLoops
    {
        public static void Main()
        {
            Console.Write("Please, type an integer number N > 1 and press Enter: ");
            int n = int.Parse(Console.ReadLine());

            Loop(0, n, new int[n]);
        }

        private static void Loop(int counter, int n, int[] result)
        {
            if (counter >= n)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    result[counter] = i;
                    Loop(counter + 1, n, result);
                }
            }
        }
    }
}
