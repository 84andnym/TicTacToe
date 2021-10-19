using Raylib_cs;
using System;

namespace TicTacCamelToe
{
    class Program
    {
        public static GameLogic GameLogic { get; set; }
        static void Main()
        {
            Raylib.InitWindow(1920, 1080, "Tic tac toe");
            Raylib.SetTargetFPS(60);
            Raylib.ToggleFullscreen();

            GameLogic = new GameLogic();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Grafic.DrawGameBoard();
                Raylib.EndDrawing();

                if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    var pos = Raylib.GetMousePosition();
                    GameLogic.GetRectangle(pos);
                }
            }
            Raylib.CloseWindow();
        }
    }
}
