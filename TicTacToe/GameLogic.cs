using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace TicTacToe
{
    public class GameLogic
    {
        public List<Rectangle> Rectangles { get; set; } = new List<Rectangle>();
        public List<string> GameBorad { get; set; } = new List<string> { "", "", "", "", "", "", "", "", "" };
        internal string player = "O";

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

        public void PlaceSymbol(int i)
        {
            if (GameBorad[i] == "")
            {
                GameBorad[i] = player;
                player = player == "O" ? "X" : "O";
            }
        }

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
            return (false, "its a draw");
        }
    }
    public enum GameState
    {
        isPlaying,
        winScreen
    }
}