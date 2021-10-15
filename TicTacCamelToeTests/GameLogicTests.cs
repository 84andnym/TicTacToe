using NUnit.Framework;
using TicTacCamelToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacCamelToe.Tests
{
    [TestFixture()]
    public class GameLogicTests
    {
        [Test()]
        public void PlaceSymbolTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(5);
            Assert.AreEqual("O", gameLogic.GameBorad[5]);
        }

        [Test()]
        public void PlaceManySymbolTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(5); // O
            gameLogic.PlaceSymbol(1); // X
            gameLogic.PlaceSymbol(3); // O
            gameLogic.PlaceSymbol(7); // X
            Assert.AreEqual("O", gameLogic.GameBorad[5]);
            Assert.AreEqual("X", gameLogic.GameBorad[1]);
            Assert.AreEqual("O", gameLogic.GameBorad[3]);
            Assert.AreEqual("X", gameLogic.GameBorad[7]);
        }


        [Test()]
        public void PlaceSymbolWereSymbolIsAlreadyPlacedTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(5); // O
            gameLogic.PlaceSymbol(1); // X
            gameLogic.PlaceSymbol(3); // O
            gameLogic.PlaceSymbol(7); // X
            gameLogic.PlaceSymbol(7); // O
            gameLogic.PlaceSymbol(4); // O
            Assert.AreEqual("O", gameLogic.GameBorad[5]);
            Assert.AreEqual("X", gameLogic.GameBorad[1]);
            Assert.AreEqual("O", gameLogic.GameBorad[3]);
            Assert.AreEqual("X", gameLogic.GameBorad[7]);
            Assert.AreEqual("O", gameLogic.GameBorad[4]);
        }
    }
}