using Raylib_cs;

namespace TicTacCamelToe
{
    internal class Program
    {
        public static GameLogic GameLogic { get; set; }

        private static void Main()
        {
            var width = 1920;
            var height = 1080;

            Raylib.InitWindow(width, height, "Tic tac toe");
            Raylib.SetTargetFPS(60);
            //Raylib.ToggleFullscreen();

            GameLogic = new GameLogic();

            int x = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    var rec = new Rectangle((width / 4 * i - (width / 5 / 2)), (height / 4 * y - (height / 5 / 2)), width / 5, height / 5);
                    GameLogic.Rectangles.Add(rec);
                    x++;
                }
            }

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
                    GameLogic.CheckWinner();
                }
            }
            Raylib.CloseWindow();
        }
    }
}