//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace WebApp.Controllers
//{
//    public class TicTacToeGameLogic
//    {

         
//            public void TicTacToe_PlaceFirstRow_Winning()
//            {
//            var ticTacToe = new TicTacToe();
//            ticTacToe.Player1 = new Client { ConnectionId = Guid.NewGuid().ToString() };
//            ticTacToe.Player2 = new Client { ConnectionId = Guid.NewGuid().ToString() };

//            ticTacToe.Play(0, 0);
//            ticTacToe.Play(1, 3);
//            ticTacToe.Play(0, 1);
//            ticTacToe.Play(1, 7);
//            ticTacToe.Play(0, 2);

//            /// Assert.IsTrue(ticTacToe.IsGameOver);
//            /// ///https://msdn.microsoft.com/en-us/library/ms243768.aspx
//            /// på länken vi kan läsa om Assert klassen
//        }

//        public void TicTacToe_PlaceSecondRow_Winning()
//            {
//            var ticTacToe = new TicTacToe();
//            ticTacToe.Player1 = new Client { ConnectionId = Guid.NewGuid().ToString() };
//            ticTacToe.Player2 = new Client { ConnectionId = Guid.NewGuid().ToString() };

//            ticTacToe.Play(0, 0);
//            ticTacToe.Play(1, 3);
//            ticTacToe.Play(0, 1);
//            ticTacToe.Play(1, 4);
//            ticTacToe.Play(0, 6);
//            ticTacToe.Play(1, 5);

//            // Assert.IsTrue(ticTacToe.IsGameOver);
//        }


//            public void TicTacToe_PlaceThirdRow_Winning()
//            {
//            var ticTacToe = new TicTacToe();
//            ticTacToe.Player1 = new Client { ConnectionId = Guid.NewGuid().ToString() };
//            ticTacToe.Player2 = new Client { ConnectionId = Guid.NewGuid().ToString() };

//            ticTacToe.Play(0, 0);
//            ticTacToe.Play(1, 6);
//            ticTacToe.Play(0, 1);
//            ticTacToe.Play(1, 7);
//            ticTacToe.Play(0, 6);
//            ticTacToe.Play(1, 8);

//            // Assert.IsTrue(ticTacToe.IsGameOver);
//        }

//            public void TicTacToe_PlaceDiagonalOne_Winning()
//            {
//            var ticTacToe = new TicTacToe();
//            ticTacToe.Player1 = new Client { ConnectionId = Guid.NewGuid().ToString() };
//            ticTacToe.Player2 = new Client { ConnectionId = Guid.NewGuid().ToString() };

//            ticTacToe.Play(0, 0);
//            ticTacToe.Play(1, 1);
//            ticTacToe.Play(0, 4);
//            ticTacToe.Play(1, 7);
//            ticTacToe.Play(0, 8);
//            ticTacToe.Play(1, 6);

//            //Assert.IsTrue(ticTacToe.IsGameOver);
//        }

//            public void TicTacToe_PlaceDiagonalTwo_Winning()
//            {
//            var ticTacToe = new TicTacToe();
//            ticTacToe.Player1 = new Client { ConnectionId = Guid.NewGuid().ToString() };
//            ticTacToe.Player2 = new Client { ConnectionId = Guid.NewGuid().ToString() };

//            ticTacToe.Play(0, 2);
//            ticTacToe.Play(1, 1);
//            ticTacToe.Play(0, 4);
//            ticTacToe.Play(1, 7);
//            ticTacToe.Play(0, 6);
//            ticTacToe.Play(1, 8);

//            // Assert.IsTrue(ticTacToe.IsGameOver);


//        }
//        }








//    }
