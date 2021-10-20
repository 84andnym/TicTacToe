using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace TicTacToe
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
        internal static void DrawWinScreen(string winnerString)
        {
            Raylib.DrawText(winnerString, (Program.width / 2 - 315), (Program.height / 2), 100, Color.GOLD);
            Raylib.DrawRectangleRounded(Shapes.RestartButton, 1F, 1, Color.BLUE);
            Raylib.DrawText("RESTART", Program.width / 2 -160, Program.height / 3 * 2 + 20, 65, Color.GOLD);
        }
    }
    static class Shapes
    {
        public static Rectangle RestartButton { get; set; } = new Rectangle(Program.width/2 - 200, Program.height / 3*2, 400, 100);
    }
}

