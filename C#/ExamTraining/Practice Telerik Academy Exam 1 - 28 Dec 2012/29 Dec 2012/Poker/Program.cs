using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] streight = new string[5];

        string firstCard = Console.ReadLine();
        if (firstCard.Equals("10"))
        {
            firstCard = "D";
        }

        string secondCard = Console.ReadLine();
        if (secondCard.Equals("10"))
        {
            secondCard = "D";
        }
        if (firstCard.Equals(secondCard))
        {
            firstCard = firstCard + secondCard;
        }

        string thirdCard = Console.ReadLine();
        if (thirdCard.Equals("10"))
        {
            thirdCard = "D";
        }
        if (thirdCard.Equals(firstCard[0].ToString()))
        {
            firstCard = firstCard + thirdCard;
        }
        else if (thirdCard.Equals(secondCard))
        {
            secondCard = secondCard + thirdCard;
        }

        string forthCard = Console.ReadLine();
        if (forthCard.Equals("10"))
        {
            forthCard = "D";
        }
        if (forthCard.Equals(firstCard[0].ToString()))
        {
            firstCard = firstCard + forthCard;
        }
        else if (forthCard.Equals(secondCard[0].ToString()))
        {
            secondCard = secondCard + forthCard;
        }
        else if (forthCard.Equals(thirdCard))
        {
            thirdCard = thirdCard + forthCard;
        }

        string fifthCard = Console.ReadLine();
        if (fifthCard.Equals("10"))
        {
            fifthCard = "D";
        }
        if (fifthCard.Equals(firstCard[0].ToString()))
        {
            firstCard = firstCard + fifthCard;
        }
        else if (fifthCard.Equals(secondCard[0].ToString()))
        {
            secondCard = secondCard + fifthCard;
        }
        else if (fifthCard.Equals(thirdCard[0].ToString()))
        {
            thirdCard = thirdCard + fifthCard;
        }
        else if (fifthCard.Equals(forthCard))
        {
            thirdCard = thirdCard + fifthCard;
        }

        if (firstCard.Length == 5)
        {
            Console.WriteLine("Impossible");
            return;
        }

        if (firstCard.Length == 4 || secondCard.Length == 4)
        {
            Console.WriteLine("Four of a Kind");
            return;
        }

        if (firstCard.Length == 3 || secondCard.Length == 3 || thirdCard.Length == 3 || forthCard.Length == 3 || fifthCard.Length == 3)
        {
            if (firstCard.Length == 2 || secondCard.Length == 2 || thirdCard.Length == 2 || forthCard.Length == 2 || fifthCard.Length == 2)
            {
                Console.WriteLine("Full House");
                return;
            }
            else
            {
                Console.WriteLine("Three of a Kind");
                return;
            }
        }
        else if (firstCard.Length == 2 ^ secondCard.Length == 2 ^ thirdCard.Length == 2 ^ forthCard.Length == 2 ^ fifthCard.Length == 2)
        {
            Console.WriteLine("One Pair");
            return;
        }

        if (firstCard.Length == 2 && (secondCard.Length == 2 || thirdCard.Length == 2 || forthCard.Length == 2 || fifthCard.Length == 2))
        {
            Console.WriteLine("Two Pairs");
            return;
        }
        else if (secondCard.Length == 2 && (thirdCard.Length == 2 || forthCard.Length == 2 || fifthCard.Length == 2))
        {
            Console.WriteLine("Two Pairs");
            return;
        }
        else if (thirdCard.Length == 2 && forthCard.Length == 2)
        {
            Console.WriteLine("Two Pairs");
            return;
        }

        streight[0] = firstCard;
        streight[1] = secondCard;
        streight[2] = thirdCard;
        streight[3] = forthCard;
        streight[4] = fifthCard;
        Array.Sort(streight);
        string streightSorted = streight[0].ToString() + streight[1].ToString() + streight[2].ToString() + streight[3].ToString() + streight[4].ToString();

        if (streightSorted.Equals("2345A") || streightSorted.Equals("23456") || streightSorted.Equals("34567") || streightSorted.Equals("45678") || streightSorted.Equals("56789") || streightSorted.Equals("6789D") || streightSorted.Equals("789DJ") || streightSorted.Equals("89DJQ") || streightSorted.Equals("9DJQK") || streightSorted.Equals("ADJKQ"))
        {
            Console.WriteLine("Straight");
            return;
        }

        Console.WriteLine("Nothing");
    }
}
