using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TestPoker
{
    [TestClass]
    public class TestHand
    {
        [TestMethod]
        public void TestHandWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            Assert.AreEqual("Ace ♣" + Environment.NewLine + "Ace ♦" + Environment.NewLine + "King ♥" + Environment.NewLine + "King ♠" + Environment.NewLine + "Seven ♦", hand.ToString());
        }

        [TestMethod]
        public void TestHandWithOneCard()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs)
            });

            Assert.AreEqual("Ace ♣", hand.ToString());
        }

        [TestMethod]
        public void TestHandWithZeroCards()
        {
            Hand hand = new Hand(new List<ICard>());

            Assert.AreEqual("", hand.ToString());
        }
    }
}
