using System;
using System.Text;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = null;
        int bullsMax = 0;
        int cowsMax = 0;
        int bulls = 0;
        int cows = 0;
        StringBuilder guess = new StringBuilder();

        secretNumber = Console.ReadLine();
        bullsMax = int.Parse(Console.ReadLine());
        cowsMax = int.Parse(Console.ReadLine());

        if (bullsMax == 3 && cowsMax == 1)
        {
            Console.WriteLine("No");
            return;
        }

        for (int a = 1000; a < 10000; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                if (secretNumber[b] == a.ToString()[b])
                {
                    bulls++;
                }
                else
                {
                    switch (b)
                    {
                        case 0:
                            if (secretNumber[b] == a.ToString()[1] || secretNumber[b] == a.ToString()[2] || secretNumber[b] == a.ToString()[3])
                            {
                                cows++;
                            }
                            break;
                        case 1:
                            if (secretNumber[b] == a.ToString()[0] || secretNumber[b] == a.ToString()[2] || secretNumber[b] == a.ToString()[3])
                            {
                                cows++;
                            }
                            break;
                        case 2:
                            if (secretNumber[b] == a.ToString()[0] || secretNumber[b] == a.ToString()[1] || secretNumber[b] == a.ToString()[3])
                            {
                                cows++;
                            }
                            break;
                        case 3:
                            if (secretNumber[b] == a.ToString()[0] || secretNumber[b] == a.ToString()[1] || secretNumber[b] == a.ToString()[2])
                            {
                                cows++;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            if (bulls == bullsMax && cows == cowsMax && a.ToString()[1] != '0' && a.ToString()[2] != '0' && a.ToString()[3] != '0')
            {
                Console.Write("{0} ", a);
            }

            bulls = 0;
            cows = 0;
        }
    }
}