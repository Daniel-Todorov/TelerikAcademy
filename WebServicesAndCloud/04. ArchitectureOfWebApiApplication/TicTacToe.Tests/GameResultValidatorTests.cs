using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.GameLogic;

namespace TicTacToe.Tests
{
    [TestClass]
    public class GameResultValidatorTests
    {
        [TestMethod]
        public void WhenEmptyBoard_ShouldReturnNotFinished()
        {
            var board = "---------";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.NotFinished, result);
        }

        [TestMethod]
        public void WhenBoardHasOneSign_ShouldReturnNotFinished()
        {
            var board = "----O----";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.NotFinished, result);
        }

        [TestMethod]
        public void WhenBoardIsFullButWithoutWinner_ShouldReturnDraw()
        {
            var board = "XOXXOXOXO";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.Draw, result);
        }

        [TestMethod]
        public void WhenBoardIsFullWithXWinnerByColumn_ShouldReturnWonByX()
        {
            var board = "XOXXOOXXO";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.WonByX, result);
        }

        [TestMethod]
        public void WhenBoardIsFullWithOWinnerByColumn_ShouldReturnWonByO()
        {
            var board = "OXXXOXOXO";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.WonByO, result);
        }

        [TestMethod]
        public void WhenBoardIsFullWithOWinnerByRow_ShouldReturnWonByO()
        {
            var board = "OOOXOXOXO";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.WonByO, result);
        }

        [TestMethod]
        public void WhenBoardIsFullWithXWinnerByDiagonal_ShouldReturnWonByX()
        {
            var board = "XOOOXXOXX";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.WonByX, result);
        }

        [TestMethod]
        public void WhenBoardIsNotFullWithXWinnerByDiagonal_ShouldReturnWonByX()
        {
            var board = "XOOXXXOXO";
            var validator = new GameResultValidator();
            GameResult result = validator.GetResult(board);

            Assert.AreEqual(GameResult.WonByX, result);
        }
    }
}
