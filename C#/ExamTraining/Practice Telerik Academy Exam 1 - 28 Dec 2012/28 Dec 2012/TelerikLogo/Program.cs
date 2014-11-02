using System;
using System.Text;

class Program
{
    static void Main()
    {
        int X = 0;
        int Y = 0;
        int Z = 0;
        int a = 0;
        int b = 0;
        StringBuilder line = new StringBuilder();

        X = int.Parse(Console.ReadLine());
        Y = X;
        Z = X / 2 + 1;


        //Print to Z
        for (; a < Z; a++)
        {
            line.Append('.', X / 2 - a);
            line.Append('*');
            if (a > 0)
            {
                line.Append('.', 2 * a - 1);
                line.Append('*');
            }
            line.Append('.', 2 * X - 3 - 2 * a);
            line.Append('*');
            if (a > 0)
            {
                line.Append('.', 2 * a - 1);
                line.Append('*');
            }
            line.Append('.', X / 2 - a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }

        //PrintY
        for (; 2 * X - 3 - 2 * (a - 1) > 1; a++)
        {
            line.Append('.', X + b);
            line.Append('*');
            if (a < X - 1)
            {
                line.Append('.', 2 * X - 3 - 2 * a);
                line.Append('*');
            }
            line.Append('.', X + b);

            b++;
            Console.WriteLine(line);
            line = new StringBuilder();
        }

        //Print upper X
        for (int i = 0; i < X; i++)
        {
            line.Append('.', X + b);
            line.Append('*');
            if (i > 0)
            {
                line.Append('.', 2 * i - 1);
                line.Append('*');
            }
            line.Append('.', X + b);

            b--;
            Console.WriteLine(line);
            line = new StringBuilder();
        }

        b = b + 2;
        for (int i = 0; i < X - 1; i++)
        {
            line.Append('.', X + b);
            line.Append('*');
            if (i < X - 2)
            {
                line.Append('.', 2 * X - 5 - 2 * i);
                line.Append('*');
            }
            line.Append('.', X + b);

            b++;
            Console.WriteLine(line);
            line = new StringBuilder();
        }
    }
}
