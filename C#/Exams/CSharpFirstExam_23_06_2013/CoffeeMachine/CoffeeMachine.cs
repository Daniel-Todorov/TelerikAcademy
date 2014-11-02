using System;

class CoffeeMachine
{
    static void Main()
    {
        long N1 = 0;
        long N2 = 0;
        long N3 = 0;
        long N4 = 0;
        long N5 = 0;
        double tray = 0.0;

        double A = 0.0;
        double P = 0.0;

        N1 = long.Parse(Console.ReadLine());
        N2 = long.Parse(Console.ReadLine());
        N3 = long.Parse(Console.ReadLine());
        N4 = long.Parse(Console.ReadLine());
        N5 = long.Parse(Console.ReadLine());

        A = double.Parse(Console.ReadLine());
        P = double.Parse(Console.ReadLine());

        tray = 0.05 * N1 + 0.10 * N2 + 0.20 * N3 + 0.50 * N4 + 1.00 * N5;

        if (P > A)
        {
            Console.WriteLine("More {0:0.00}",P - A);
        }

        if (A >= P && A - P <= tray)
        {
            Console.WriteLine("Yes {0:0.00}", tray - (A - P));
        }

        if (A >= P && A - P > tray)
        {
            Console.WriteLine("No {0:0.00}", (A - P) - tray);
        }
    }
}
