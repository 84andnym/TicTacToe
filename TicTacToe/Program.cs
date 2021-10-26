namespace TicTacToe
{
    using Raylib_cs;

    internal class Program
    {
        public static GameLogic GameLogic { get; set; }
        public static readonly int width = 1920;
        public static readonly int height = 1080;

        private static void Main()
        {
            Raylib.InitWindow(width, height, "Tic tac toe");
            Raylib.SetTargetFPS(60);
            //Raylib.ToggleFullscreen();

            GameLogic = new GameLogic();
            GameState gameState = GameState.isPlaying;

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
            (bool isWinner, string winMessage) checkWinnerRes = (false, "");
            while (!Raylib.WindowShouldClose())
            {
                if (gameState == GameState.isPlaying)
                {
                    SateController.IsPlaying(GameLogic, ref gameState, ref checkWinnerRes);
                }
                if (gameState == GameState.winScreen)
                {
                    SateController.WinScreen(GameLogic, ref gameState, checkWinnerRes);
                }
            }
            Raylib.CloseWindow();
        }
    }
}