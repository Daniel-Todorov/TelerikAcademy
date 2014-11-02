using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = 0;
        StringBuilder line = new StringBuilder();

        N = int.Parse(Console.ReadLine());

        //Print upper side
        for (int a = 0; a < N / 2; a++)
        {
            line = line.Append('.', a);
            line = line.Append('\\');
            line = line.Append('.', N / 2 - 1 - a);
            line = line.Append('|');
            line = line.Append('.', N / 2 - 1 - a);
            line = line.Append('/');
            line = line.Append('.', a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }

        //Print center
        for (int b = 0; b < N; b++)
        {
            if (b == N / 2)
            {
                line = line.Append('*');
            }
            else
            {
                line = line.Append('-');
            }
            Console.Write(line);
            line = new StringBuilder();
        }

        Console.WriteLine("");

        //Pint down side
        for (int c = 0; c < N / 2; c++)
        {
            line = line.Append('.', N / 2 - 1 - c);
            line = line.Append('/');
            line = line.Append('.', c);
            line = line.Append('|');
            line = line.Append('.', c);
            line = line.Append('\\');
            line = line.Append('.', N / 2 - 1 - c);

            Console.WriteLine(line);
            line = new StringBuilder();
        }
    }
}
