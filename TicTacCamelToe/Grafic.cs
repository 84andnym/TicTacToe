using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace TicTacCamelToe
{
    class Grafic
    {
        internal static void DrawGameBoard()
        {

            for (int i = 0; i < Program.GameLogic.Rectangles.Count; i++)
            {
               Raylib.DrawRectangleRec(Program.GameLogic.Rectangles[i], Program.GameLogic.GameBorad[i] == "O" ? Color.GREEN : Program.GameLogic.GameBorad[i] == "X" ? Color.RED : Color.GRAY);
            }
        }
    }
}

