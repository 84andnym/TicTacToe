namespace TicTacToe
{
    using Raylib_cs;
    using System.Numerics;

    internal class Program
    {
        public static GameLogic GameLogic { get; set; }
        public static readonly int width = 1920;
        public static readonly int height = 1080;
        public static bool quitGame = false;

        private static void Main()
        {
            Raylib.InitWindow(width, height, "Tic tac toe");
            Raylib.SetTargetFPS(60);
            //Raylib.ToggleFullscreen();

            GameLogic = new GameLogic();
            GameState gameState = GameState.homeScreen;

            int x = 0;

            /////
            //Create Standatd Values
            /////
            for (int i = 1; i < 4; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    var rec = new Rectangle((width / 4 * i - (width / 5 / 2)), (height / 4 * y - (height / 5 / 2)), width / 5, height / 5);
                    GameLogic.Rectangles.Add(rec);
                    var vec = new Vector2(width / 4 * i, height / 4 * y);
                    GameLogic.TextPos.Add(vec);
                    x++;
                }
            }
            (bool isWinner, string winMessage) checkWinnerRes = (false, "");

            /////
            //Run Game
            /////
            while (!Raylib.WindowShouldClose() && !quitGame)
            {
                switch (gameState)
                {
                    case GameState.homeScreen:
                        SateController.HomeScreen(ref gameState, ref quitGame);
                        break;

                    case GameState.isPlaying:
                        SateController.IsPlaying(GameLogic, ref gameState, ref checkWinnerRes);
                        break;

                    case GameState.winScreen:
                        SateController.WinScreen(GameLogic, ref gameState, checkWinnerRes);
                        break;

                    case GameState.achievementScreen:
                        SateController.AchimentScreen(ref gameState);
                        break;

                    case GameState.settings:
                        SateController.Settings(ref gameState);
                        break;

                    default:
                        SateController.HomeScreen(ref gameState, ref quitGame);
                        break;
                }
            }
            Raylib.CloseWindow();
        }
    }
}