//Write a program that fills and prints a matrix of size 
//(n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;

class FillAndPrintCubeMatrix
{
    static void Main()
    {
        int[,] matrix;
        int n = 0;
        int fillingCounter = 1;

        Console.Write("Please, type the size n of the matrix and press Enter: ");
        n = int.Parse(Console.ReadLine());

        matrix = new int[n, n];

        for (int width = 0; width < matrix.GetLength(1); width++)
        {
            for (int heigth = 0; heigth < matrix.GetLength(0); heigth++)
            {
                matrix[heigth, width] = fillingCounter;
                fillingCounter++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Solution a): ");
        Console.WriteLine();
        for (int heigth = 0; heigth < matrix.GetLength(0); heigth++)
        {
            for (int width = 0; width < matrix.GetLength(1); width++)
            {
                Console.Write("{0,3}", matrix[heigth, width]);
            }
            Console.WriteLine();
        }


        fillingCounter = 1;
        matrix = new int[n, n];

        for (int width = 0; width < matrix.GetLength(1); width++)
        {
            if (width % 2 == 0)
            {
                for (int height = 0; height < matrix.GetLength(0); height++)
                {
                    matrix[height, width] = fillingCounter;
                    fillingCounter++;
                }
            }
            else if (width % 2 == 1)
            {
                for (int height = matrix.GetLength(0) - 1; height >= 0; height--)
                {
                    matrix[height, width] = fillingCounter;
                    fillingCounter++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Solution b): ");
        Console.WriteLine();
        for (int heigth = 0; heigth < matrix.GetLength(0); heigth++)
        {
            for (int width = 0; width < matrix.GetLength(1); width++)
            {
                Console.Write("{0,3}", matrix[heigth, width]);
            }
            Console.WriteLine();
        }


        fillingCounter = 1;
        matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int h = (matrix.GetLength(0) - 1) - i, w = 0; h <= matrix.GetLength(0) - 1; h++, w++)
            {
                matrix[h, w] = fillingCounter;
                fillingCounter++;
            }
        }
        for (int i = n - 1; i >= 0; i--)
        {
            for (int h = 0, w = matrix.GetLength(1) - i; w <= matrix.GetLength(1) - 1; h++, w++)
            {
                matrix[h, w] = fillingCounter;
                fillingCounter++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Solution c): ");
        Console.WriteLine();
        for (int heigth = 0; heigth < matrix.GetLength(0); heigth++)
        {
            for (int width = 0; width < matrix.GetLength(1); width++)
            {
                Console.Write("{0,3}", matrix[heigth, width]);
            }
            Console.WriteLine();
        }


        fillingCounter = 1;
        matrix = new int[n, n];
        int hei = 0;
        int wid = 0;
        int a = 0;
        int b = 1;

        for (; fillingCounter <= n; fillingCounter++, hei++)
        {
            matrix[hei, wid] = fillingCounter;
        }

        hei = n - 1;
        wid = 0;

        for (int i = 0; i < n * n; i++)
        {
            while (a < n - b)
            {
                wid++;
                matrix[hei, wid] = fillingCounter;
                fillingCounter++;
                a++;
            }
            a = 0;

            while (a < n - b)
            {
                hei--;
                matrix[hei, wid] = fillingCounter;
                fillingCounter++;
                a++;
            }
            a = 0;
            b++;

            while (a < n - b)
            {
                wid--;
                matrix[hei, wid] = fillingCounter;
                fillingCounter++;
                a++;
            }
            a = 0;

            while (a < n - b)
            {
                hei++;
                matrix[hei, wid] = fillingCounter;
                fillingCounter++;
                a++;
            }
            a = 0;
            b++;
        }

        Console.WriteLine();
        Console.WriteLine("Solution d): ");
        Console.WriteLine();
        for (int heigth = 0; heigth < matrix.GetLength(0); heigth++)
        {
            for (int width = 0; width < matrix.GetLength(1); width++)
            {
                Console.Write("{0,3}", matrix[heigth, width]);
            }
            Console.WriteLine();
        }
    }
}
