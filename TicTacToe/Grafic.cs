namespace TicTacToe
{
    using Raylib_cs;
    using System.Collections.Generic;

    internal class Grafic
    {
        internal static int playerOColorIndex = 0;
        internal static int playerXColorIndex = 4;
        internal static char playerOCHar = 'O';
        internal static char playerXCHar = 'X';
        public static List<Color> playerColors = new List<Color> { Color.GREEN, Color.BLUE, Color.ORANGE, Color.YELLOW, Color.RED, Color.PURPLE, Color.GOLD, Color.LIME };

        /// <summary>
        /// Draws the active Game board
        /// </summary>
        internal static void DrawGameBoard()
        {
            var font = Raylib.GetFontDefault();
            for (int i = 0; i < Program.GameLogic.Rectangles.Count; i++)
            {
                Raylib.DrawRectangleRec(Program.GameLogic.Rectangles[i], Program.GameLogic.GameBorad[i] == "O" ? playerColors[playerOColorIndex] : Program.GameLogic.GameBorad[i] == "X" ? playerColors[playerXColorIndex] : Color.GRAY);

                Raylib.DrawText(Program.GameLogic.GameBorad[i] == "O" ? playerOCHar.ToString() : Program.GameLogic.GameBorad[i] == "X" ? playerXCHar.ToString() : "",
                    (int)Program.GameLogic.TextPos[i].X,
                    (int)Program.GameLogic.TextPos[i].Y,
                    150, 
                    Color.BLACK);
            }
        }

        internal static void DrawOptionScreen()
        {
            Raylib.DrawRectangleRounded(Shapes.PlayerColorO, 1F, 1, playerColors[playerOColorIndex]);
            Raylib.DrawRectangleRounded(Shapes.PlayerColorX, 1F, 1, playerColors[playerXColorIndex]);
            Raylib.DrawRectangleRounded(Shapes.StartGame, 1F, 1, Color.GREEN);
            Raylib.DrawText("Player O", Program.width / 2 - 165, Program.height / 3 + 15, 75, Color.WHITE);
            Raylib.DrawText("Player X", Program.width / 2 - 165, Program.height / 2 + 15, 75, Color.WHITE);
            Raylib.DrawText("Start", Program.width / 2 - 115, Program.height / 3 * 2 + 15, 75, Color.WHITE);
        }

        /// <summary>
        /// Draws the winscreen
        /// </summary>
        /// <param name="winnerString">win massage</param>
        internal static void DrawWinScreen(string winnerString)
        {
            Raylib.DrawText(winnerString, (Program.width / 2 - 315), (Program.height / 2), 100, Color.GOLD);
            Raylib.DrawRectangleRounded(Shapes.RestartButton, 1F, 1, Color.BLUE);
            Raylib.DrawText("RESTART", Program.width / 2 - 410, Program.height / 3 * 2 + 20, 65, Color.GOLD);
            Raylib.DrawRectangleRounded(Shapes.HomeScreenButton, 1F, 1, Color.BLUE);
            Raylib.DrawText("HOME", Program.width / 2 + 160, Program.height / 3 * 2 + 20, 65, Color.GOLD);
        }
        /// <summary>
        /// Draws a Main Screen
        /// </summary>
        internal static void DrawMainScreen()
        {
            Raylib.DrawRectangleRounded(Shapes.StartButton, 1F, 1, Color.GREEN);
            Raylib.DrawText("START", Program.width / 2 - 110, Program.height / 2 - 75, 65, Color.WHITE);
            Raylib.DrawRectangleRounded(Shapes.QuitButton, 1F, 1, Color.RED);
            Raylib.DrawText("QUIT", Program.width / 2 - 75, Program.height / 2 + 125, 65, Color.WHITE);
        }
    }

    internal static class Shapes
    {
        public static Rectangle StartGame { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 3 * 2, 400, 100);
        public static Rectangle PlayerColorO { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 3, 400, 100);
        public static Rectangle PlayerColorX { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 2, 400, 100);
        public static Rectangle RestartButton { get; set; } = new Rectangle(Program.width / 2 - 450, Program.height / 3 * 2, 400, 100);
        public static Rectangle HomeScreenButton { get; set; } = new Rectangle(Program.width / 2 + 50, Program.height / 3 * 2, 400, 100);
        public static Rectangle StartButton { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 2 - 100, 400, 100);
        public static Rectangle QuitButton { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 2 + 100, 400, 100);
    }
}