using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace TicTacCamelToe
{
    internal class GameLogic
    {
        internal List<string> GameBorad { get; set; } = new List<string> { "", "", "", "", "", "", "", "", "", };
        internal string player = "O";

        internal void PlaceSymbol(Vector2 Pos)
        {
            for (int i = 0; i < Grafic.Rectangles.Count; i++)
            {
                if (Raylib.CheckCollisionPointRec(Pos, Grafic.Rectangles[i]))
                {
                    if(GameBorad[i] == "")
                    {
                        GameBorad[i] = player;
                        player = player == "O" ? "X" : "O";
                    }
                }
            }
        }
    }
}
