using System;
using System.Text;

class Carpets
{
    static void Main()
    {
        int N = 0;
        int b = 0;
        StringBuilder line = new StringBuilder();

        N = int.Parse(Console.ReadLine());

        for (int a = 1; a <= N / 2; a++)
        {
            line.Append('.', N / 2 - a);

            while (line.Length < N / 2)
            {
                if (line.Length < N / 2 - 1)
                {
                    line.Append("/ ");
                }
                else
                {
                    line.Append("/");
                }
            }

            while (line.Length < N - (N / 2 - a))
            {
                if (a % 2 != 0)
                {
                    line.Append(@"\");
                }
                else
                {
                    line.Append(@" ");
                }

                if ((N - (N / 2 - a)) - line.Length == 0)
                {
                    break;
                }
                else if (((N - (N / 2 - a)) - line.Length) % 2 != 0)
                {
                    line.Append(@"\");
                }
                else if (((N - (N / 2 - a)) - line.Length) % 2 == 0)
                {
                    line.Append(@" ");
                }
            }

            line.Append('.', N / 2 - a);

            Console.WriteLine(line);
            line = new StringBuilder();
        }

        for (int a = N / 2; a < N; a++)
        {
            line.Append('.', a - N / 2);

            while (line.Length < N / 2)
            {
                if (line.Length < N / 2 - 1)
                {
                    line.Append(@"\ ");
                }
                else
                {
                    line.Append(@"\");
                }
            }

            while (line.Length < N - (N / 2 - a))
            {
                if (a % 2 != 0)
                {
                    line.Append(@"/");
                }
                else
                {
                    line.Append(@" ");
                }

                if ((N - (a - N / 2)) - line.Length <= 0)
                {
                    break;
                }
                else if (((N - (a - N / 2)) - line.Length) % 2 != 0)
                {
                    line.Append(@"/");
                }
                else if (((N - (a - N / 2)) - line.Length) % 2 == 0)
                {
                    line.Append(@" ");
                }

            }
            if (a % 2 == 0 && a > N / 2)
            {
                line.Remove(line.Length - 1, 1);
            }
            line.Append('.', a - N / 2);

            Console.WriteLine(line);
            line = new StringBuilder();
        }
    }
}
