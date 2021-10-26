namespace TicTacToe
{
    using Raylib_cs;
    using System.Collections.Generic;
    using System.Numerics;

    public class GameLogic
    {
        public List<Rectangle> Rectangles { get; set; } = new List<Rectangle>();
        public int Turns { get; set; } = 0;
        public List<string> GameBorad { get; set; } = new List<string> { "", "", "", "", "", "", "", "", "" };
        internal string player = "O";

        /// <summary>
        /// Get the Rectangle that is pressed
        /// </summary>
        /// <param name="Pos">Where mouse is pressed</param>
        internal void GetRectangle(Vector2 Pos)
        {
            for (int i = 0; i < Rectangles.Count; i++)
            {
                if (Raylib.CheckCollisionPointRec(Pos, Rectangles[i]))
                {
                    PlaceSymbol(i);
                }
            }
        }

        /// <summary>
        /// Palce symbol in Array
        /// </summary>
        /// <param name="i"></param>
        public void PlaceSymbol(int i)
        {
            if (GameBorad[i] == "")
            {
                GameBorad[i] = player;
                player = player == "O" ? "X" : "O";
                Turns++;
            }
        }

        /// <summary>
        /// Reset Game Logic
        /// </summary>
        public void ClearGame()
        {
            GameBorad.Clear();
            Turns = 0;
            GameBorad = new List<string> { "", "", "", "", "", "", "", "", "" };
        }

        /// <summary>
        /// Check if a winner is set
        /// </summary>
        /// <returns>a bool and a who won</returns>
        public (bool isWinner, string winMessage) CheckWinner()
        {
            if ((GameBorad[0] == "O" && GameBorad[1] == "O" && GameBorad[2] == "O") ||
                (GameBorad[3] == "O" && GameBorad[4] == "O" && GameBorad[5] == "O") ||
                (GameBorad[6] == "O" && GameBorad[7] == "O" && GameBorad[8] == "O") ||
                (GameBorad[0] == "O" && GameBorad[3] == "O" && GameBorad[6] == "O") ||
                (GameBorad[1] == "O" && GameBorad[4] == "O" && GameBorad[7] == "O") ||
                (GameBorad[2] == "O" && GameBorad[5] == "O" && GameBorad[8] == "O") ||
                (GameBorad[0] == "O" && GameBorad[4] == "O" && GameBorad[8] == "O") ||
                (GameBorad[2] == "O" && GameBorad[4] == "O" && GameBorad[6] == "O"))
            {
                return (true, "Player O Wins");
            }
            else if ((GameBorad[0] == "X" && GameBorad[1] == "X" && GameBorad[2] == "X") ||
                    (GameBorad[3] == "X" && GameBorad[4] == "X" && GameBorad[5] == "X") ||
                    (GameBorad[6] == "X" && GameBorad[7] == "X" && GameBorad[8] == "X") ||
                    (GameBorad[0] == "X" && GameBorad[3] == "X" && GameBorad[6] == "X") ||
                    (GameBorad[1] == "X" && GameBorad[4] == "X" && GameBorad[7] == "X") ||
                    (GameBorad[2] == "X" && GameBorad[5] == "X" && GameBorad[8] == "X") ||
                    (GameBorad[0] == "X" && GameBorad[4] == "X" && GameBorad[8] == "X") ||
                    (GameBorad[2] == "X" && GameBorad[4] == "X" && GameBorad[6] == "X"))
            {
                return (true, "Player X Wins");
            }
            else if (Turns == 9)
            {
                return (true, "It's a draw");
            }
            return (false, "");
        }
    }

    public enum GameState
    {
        isPlaying,
        winScreen,
        achievementScreen,
        homeScreen
    }
}