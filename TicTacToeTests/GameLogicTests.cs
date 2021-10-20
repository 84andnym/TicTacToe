using NUnit.Framework;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Tests
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

        [Test()]
        public void CheckWinnerOfOnePlacedSymbolTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(5); // O
            Assert.IsFalse(gameLogic.CheckWinner().isWinner);
        }

        [Test()]
        public void CheckWinnerOTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(0); // O
            gameLogic.PlaceSymbol(4); // X
            gameLogic.PlaceSymbol(1); // O
            gameLogic.PlaceSymbol(5); // X
            gameLogic.PlaceSymbol(2); // O
            Assert.IsTrue(gameLogic.CheckWinner().isWinner);
            Assert.AreEqual("Player O Wins", gameLogic.CheckWinner().winMessage);
        }

        [Test()]
        public void CheckWinnerXTest()
        {
            var gameLogic = new GameLogic();
            gameLogic.PlaceSymbol(5); // O
            gameLogic.PlaceSymbol(0); // X
            gameLogic.PlaceSymbol(1); // O
            gameLogic.PlaceSymbol(4); // X
            gameLogic.PlaceSymbol(2); // O
            gameLogic.PlaceSymbol(8); // X
            Assert.IsTrue(gameLogic.CheckWinner().isWinner);
            Assert.AreEqual("Player X Wins", gameLogic.CheckWinner().winMessage);
        }
    }
}