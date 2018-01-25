using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameEngine;

namespace UnitTestGameEngine
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void CheckWinner_3Xs_XWins()
        {
            // Arrage
            GameBoard bg = new GameBoard();
            bg.Fields[0] = "X.png";
            bg.Fields[1] = "X.png";
            bg.Fields[2] = "X.png";
            TicTacToe ttt = new TicTacToe();
            ttt.Players.Add(new Player() {
                Name = "player1"
            });

            // Act
            var result = ttt.CheckWinner();

            // Assert
            Assert.AreEqual("The winner is player1", result);
        }
    }
}
