using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.Face);
            result.Append(" ");
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    result.Append("♣");
                    break;
                case CardSuit.Diamonds:
                    result.Append("♦");
                    break;
                case CardSuit.Hearts:
                    result.Append("♥");
                    break;
                case CardSuit.Spades:
                    result.Append("♠");
                    break;
                default:
                    break;
            }

            return result.ToString();
        }
    }
}
