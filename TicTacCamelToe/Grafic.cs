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
            var width = 1920;
            var height = 1080;
            int x = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    var rec = new Rectangle((width / 4 * i - (width / 5 / 2)), (height / 4 * y - (height / 5 / 2)), width / 5, height / 5);
                    Raylib.DrawRectangleRec(rec, Program.GameLogic.GameBorad[x] == "O" ? Color.GREEN : Program.GameLogic.GameBorad[x] == "X" ? Color.RED : Color.GRAY);
                    Program.GameLogic.Rectangles.Add(rec);
                    x++;
                }
            }
        }
    }
}
