using System;
using System.Text;

class BullsAndCows2
{
    static void Main()
    {
        string secretNumber = null;
        int bullsMax = 0;
        int cowsMax = 0;
        int bulls = 0;
        int cows = 0;
        StringBuilder guess = new StringBuilder();
        string stringedguess = null;

        secretNumber = Console.ReadLine();
        bullsMax = int.Parse(Console.ReadLine());
        cowsMax = int.Parse(Console.ReadLine());

        for (int i = 1000; i < 10000; i++)
        {
            stringedguess = i.ToString();

            if (stringedguess[0] == secretNumber[0])
            {
                bulls++;
            }
            else if (stringedguess[0] == secretNumber[1] || stringedguess[0] == secretNumber[2] || stringedguess[0] == secretNumber[3])
            {
                cows++;
            }
            if (stringedguess[1] == secretNumber[1])
            {
                bulls++;
            }
            else if (stringedguess[1] == secretNumber[0] || stringedguess[1] == secretNumber[2] || stringedguess[1] == secretNumber[3])
            {
                cows++;
            }
            if (stringedguess[2] == secretNumber[2])
            {
                bulls++;
            }
            else if (stringedguess[2] == secretNumber[0] || stringedguess[2] == secretNumber[1] || stringedguess[2] == secretNumber[3])
            {
                cows++;
            }
            if (stringedguess[3] == secretNumber[3])
            {
                bulls++;
            }
            else if (stringedguess[3] == secretNumber[0] || stringedguess[3] == secretNumber[1] || stringedguess[3] == secretNumber[2])
            {
                cows++;
            }

            if (bulls == bullsMax && cows == cowsMax && i.ToString()[1] != '0' && i.ToString()[2] != '0' && i.ToString()[3] != '0')
            {
                guess.Append(i.ToString());
                guess.Append(" ");
                Console.Write(guess);
            }

            bulls = 0;
            cows = 0;
        }
    }
}