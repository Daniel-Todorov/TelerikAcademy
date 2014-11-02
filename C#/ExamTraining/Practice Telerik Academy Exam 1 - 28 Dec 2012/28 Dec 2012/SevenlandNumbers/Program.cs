using System;

class Program
{
    static void Main()
    {
        int K = 0;
        int tenSystem = 0;
        int leftover = 0;

        K = int.Parse(Console.ReadLine());

            for (double i = 0.0; K > 0; i++)
            {
                leftover = K % 10;
                K = K / 10;
                tenSystem = tenSystem + (int)(leftover * Math.Pow(7, i));
            }

            tenSystem++;

            for (double i = 0; tenSystem > 0; i++)
            {
                leftover = tenSystem % 7;
                tenSystem = tenSystem / 7;
                K = K + (int)(leftover * Math.Pow(10, i));
            }
            Console.WriteLine(K);
    }
}
