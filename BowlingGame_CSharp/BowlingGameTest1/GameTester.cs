using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest1
{
    [TestClass]
    public class GameTester
    {
        private Game game;

        [TestInitialize]
        public void Setup()
        {
            game = new Game();
        }

        [TestMethod]
        public void RollAllZerosShouldGetZeroScore()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, game.Score());
        }
     
        [TestMethod]
        public void RollAllOnesShouldGetTwentyScore()
        {
            RollMany(20, 1);

            Assert.AreEqual(20,game.Score());
            
        }

        [TestMethod]
        public void GameWithOneSpare()
        {
            game.Roll(1);
            game.Roll(9);
            game.Roll(5);
            RollMany(17, 0);

            Assert.AreEqual(20, game.Score());
        }
        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

    }
}
