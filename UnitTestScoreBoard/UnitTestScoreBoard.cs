using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestScoreBoard
{
    [TestClass]
    public class UnitTestScoreBoard
    {
        [TestMethod]
        public void TestPositiveNegativeScenario()
        {
            ScoreBoard.Scoreboard board = new ScoreBoard.Scoreboard();
            board.PlayersName = "Hans";
            board.Requested = 1;
            board.Received = 1;
            int result = board.Score;
            Assert.AreEqual(30, result);
            board.Requested = 1;
            board.Received = 0;
            result = board.Score;
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestNegativePositiveScenario()
        {
            ScoreBoard.Scoreboard board = new ScoreBoard.Scoreboard();
            board.PlayersName = "Hans";
            board.Requested = 1;
            board.Received = 0;
            int result = board.Score;
            Assert.AreEqual(-10, result);
            board.Requested = 1;
            board.Received = 0;
            result = board.Score;
            Assert.AreEqual(-20, result);
            board.Requested = 0;
            board.Received= 0;
            result = board.Score;
            Assert.AreEqual(0, result);
        }
    }
}
