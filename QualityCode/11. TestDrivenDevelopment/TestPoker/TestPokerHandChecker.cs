using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TestPoker
{
    [TestClass]
    public class TestPokerHandChecker
    {
        [TestMethod]
        public void TestForOfKindWithValidCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestForOfKindWithInvalidCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestFlushWithInvalidCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestFlushWithValidHand()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestCheckerWithValidHand()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestCheckerWithDuplicateCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestCheckerWithSixCards()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestCheckerWithZeroCards()
        {
            Hand hand = new Hand(new List<ICard>());

            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestCheckerWithNullCards()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(null));
        }
    }
}
