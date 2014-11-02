using System;

class Program
{
    static void Main()
    {
        //int N1 = int.Parse(Console.ReadLine());
        //int N2 = int.Parse(Console.ReadLine());
        //int N3 = int.Parse(Console.ReadLine());
        //int N4 = int.Parse(Console.ReadLine());
        //int N5 = int.Parse(Console.ReadLine());
        //int N6 = int.Parse(Console.ReadLine());
        //int N7 = int.Parse(Console.ReadLine());
        //int N8 = int.Parse(Console.ReadLine());
        //int N9 = int.Parse(Console.ReadLine());
        //int N10 = int.Parse(Console.ReadLine());
        //int N11 = int.Parse(Console.ReadLine());
        //int N12 = int.Parse(Console.ReadLine());
        //int N13 = int.Parse(Console.ReadLine());
        //int N14 = int.Parse(Console.ReadLine());
        //int N15 = int.Parse(Console.ReadLine());
        //int N16 = int.Parse(Console.ReadLine());
        int[] firstTeam = new int[8];
        int[] secondTeam = new int[8];
        int mask = 1;
        bool player1 = false;
        bool player2 = false;
        int firstScores = 0;
        int secondScores = 0;

        for (int i = 0; i < 8; i++)
        {
            firstTeam[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 8; i++)
        {
            secondTeam[i] = int.Parse(Console.ReadLine());
        }


        for (int a = 0; a < 8; a++)
        {
            for (int b = 0; b < 8; b++)
            {
                mask = 1;
                mask = mask << b;
                player1 = (firstTeam[a] & mask) > 0;
                if (player1 == true)
                {
                    for (int c = a; c < 8; c++)
                    {
                        mask = 1;
                        mask = mask << b;
                        player2 = (secondTeam[c] & mask) > 0;
                        if (player2 == true)
                        {
                            break;
                        }
                    }
                }
                if (player1 == true && player2 == true)
                {
                    continue;
                }
                else if (player1 == false)
                {
                    continue;
                }
                else
                {
                    firstScores++;
                    break;
                }

                player1 = false;
                player2 = false;
            }
        }
        Console.WriteLine(firstScores);
    }
}
