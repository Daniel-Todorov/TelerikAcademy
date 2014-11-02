using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TestPoker
{
    [TestClass]
    public class TestCard
    {
        [TestMethod]
        public void TestToStringMethodWithAceAndClubs()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Clubs);
            Assert.AreEqual("Ace ♣", card.ToString());
        }

        [TestMethod]
        public void TestToStringMethodWithNumberAndDiamonds()
        {
            Card card = new Card(CardFace.Four, CardSuit.Diamonds);
            Assert.AreEqual("Four ♦", card.ToString());
        }

        [TestMethod]
        public void TestToStringMethodWithNumberAndHearts()
        {
            Card card = new Card(CardFace.Nine, CardSuit.Hearts);
            Assert.AreEqual("Nine ♥", card.ToString());
        }

        [TestMethod]
        public void TestToStringMethodWithKingAndSpades()
        {
            Card card = new Card(CardFace.King, CardSuit.Spades);
            Assert.AreEqual("King ♠", card.ToString());
        }
    }
}
