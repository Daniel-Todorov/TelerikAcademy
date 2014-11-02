using System;

using System.Text;

class Program
{
    static void Main()
    {
        int N = 0;
        StringBuilder line = new StringBuilder();

        N = int.Parse(Console.ReadLine());

        for (int a = 0; a < N / 2; a++)
        {
            line.Append('.', N / 2 - 1 - a);
            line.Append('#');
            line.Append('.', 2 * a);
            line.Append('#');
            line.Append('.', N / 2 - 1 - a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }

        for (int a = 0; a < N / 4; a++)
        {
            line.Append('.', a);
            line.Append('#');
            line.Append('.', N - 2 - 2 * a);
            line.Append('#');
            line.Append('.', a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }

        line.Append('-', N);

        Console.WriteLine(line);
        line = new StringBuilder();

        for (int a = 0; a < N / 2; a++)
        {
            line.Append('.', a);
            line.Append('\\', N / 2 - a);
            line.Append('/', N / 2 - a);
            line.Append('.', a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }
    }
}
