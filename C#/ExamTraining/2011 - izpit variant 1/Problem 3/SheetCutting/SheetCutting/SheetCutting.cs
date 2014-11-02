using System;

class SheetCutting
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int leftOver = N;
        int pow = 10;

        for (double a = 0; a <= 10; a++)
        {
            if (N / (Convert.ToInt32(Math.Pow(2, pow))) == 0)
            {
                Console.WriteLine("A{0}", a);
            }
            else
            {
                N = N % (Convert.ToInt32(Math.Pow(2, pow)));
            }

            pow--;
        }
    }
}
