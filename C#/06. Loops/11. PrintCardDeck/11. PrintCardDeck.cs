//Write a program that prints all possible cards from a standard deck of 52 cards (without jockers). 
//The cards should be printed with their English names.
//Use nested for loops and switch-case.

using System;

class PrintCardDeck
{
    static void Main()
    {
        int cardCounter = 0;
        string colorCard = null;

        for (int a = 1; a <= 4; a++) 
        {
            switch (a)
            {
                case 1:
                    colorCard = "clubs";
                    break;
                case 2:
                    colorCard = "diamonds";
                    break;
                case 3:
                    colorCard = "hearts";
                    break;
                case 4:
                    colorCard = "spades";
                    break;
            }

            for (cardCounter = 2; cardCounter <= 14; cardCounter++)
            {
                switch (cardCounter)
                {
                    case 2:
                        Console.WriteLine("Two of {0}", colorCard);
                        break;
                    case 3:
                        Console.WriteLine("Three of {0}", colorCard);
                        break;
                    case 4:
                        Console.WriteLine("Four of {0}", colorCard);
                        break;
                    case 5:
                        Console.WriteLine("Five of {0}", colorCard);
                        break;
                    case 6:
                        Console.WriteLine("Six of {0}", colorCard);
                        break;
                    case 7:
                        Console.WriteLine("Seven of {0}", colorCard);
                        break;
                    case 8:
                        Console.WriteLine("Eight of {0}", colorCard);
                        break;
                    case 9:
                        Console.WriteLine("Nine of {0}", colorCard);
                        break;
                    case 10:
                        Console.WriteLine("Ten of {0}", colorCard);
                        break;
                    case 11:
                        Console.WriteLine("Jack of {0}", colorCard);
                        break;
                    case 12:
                        Console.WriteLine("Queen of {0}", colorCard);
                        break;
                    case 13:
                        Console.WriteLine("King of {0}", colorCard);
                        break;
                    case 14:
                        Console.WriteLine("Ace of {0}", colorCard);
                        break;
                }
            }
        }
    }
}
