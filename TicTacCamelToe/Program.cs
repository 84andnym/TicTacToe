using Raylib_cs;
using System;

namespace TicTacCamelToe
{
    class Program
    {
        public static GameLogic GameLogic { get; set; }
        static void Main()
        {
            Raylib.InitWindow(1920, 1080, "Tic tac cameltoe");
            Raylib.SetTargetFPS(60);
            //Raylib.ToggleFullscreen();

            GameLogic = new GameLogic();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Grafic.DrawGameBoard();


                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
