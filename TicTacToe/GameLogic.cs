using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace TicTacToe
{
    public class GameLogic
    {
        public List<Rectangle> Rectangles { get; set; } = new List<Rectangle>();
        public List<string> GameBorad { get; set; } = new List<string> { "", "", "", "", "", "", "", "", "", };
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
    }
}
