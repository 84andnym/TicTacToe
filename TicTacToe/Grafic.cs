namespace TicTacToe
{
    using Raylib_cs;
    using System.Collections.Generic;
    using System.Numerics;

    internal class Grafic
    {
        internal static bool samePlayerTexture = false;
        internal static int player1TextureIndex = 0;
        internal static int player2TextureIndex = 1;
        internal static int player1ColorIndex = 0;
        internal static int player2ColorIndex = 4;
        public static List<Color> playerColors = new List<Color> { Color.GREEN, Color.BLUE, Color.ORANGE, Color.YELLOW, Color.RED, Color.PURPLE, Color.GOLD, Color.LIME };
        internal static Texture2D Camel = Raylib.LoadTexture("Textures/CamelX.png");
        internal static Texture2D HorseShoe = Raylib.LoadTexture("Textures/HorseShoe.png");
        internal static Texture2D Moon = Raylib.LoadTexture("Textures/MoonX.png");
        internal static Texture2D Star = Raylib.LoadTexture("Textures/StarX.png");
        public static List<Texture2D> playerTextures = new List<Texture2D> { Camel, HorseShoe, Moon, Star };

        /// <summary>
        /// Draws the active Game board
        /// </summary>
        internal static void DrawGameBoard()
        {

            Raylib.DrawText("Player " + (Program.GameLogic.player == "O" ? "1" : "2") + "'s turn", Program.width / 2 - 190, 20, 50, Color.RED);

            for (int i = 0; i < Program.GameLogic.Rectangles.Count; i++)
            {
                Raylib.DrawRectangleRec(Program.GameLogic.Rectangles[i], Program.GameLogic.GameBorad[i] == "O" ? playerColors[player1ColorIndex] : Program.GameLogic.GameBorad[i] == "X" ? playerColors[player2ColorIndex] : Color.GRAY);

                if(Program.GameLogic.GameBorad[i] == "O")
                {
                    Raylib.DrawTexture(playerTextures[player1TextureIndex], (int)Program.GameLogic.TextPos[i].X - 100, (int)Program.GameLogic.TextPos[i].Y - 100, Color.WHITE);
                }
                else if(Program.GameLogic.GameBorad[i] == "X")
                {
                    Raylib.DrawTexture(playerTextures[player2TextureIndex], (int)Program.GameLogic.TextPos[i].X - 100, (int)Program.GameLogic.TextPos[i].Y - 100, Color.WHITE);
                }
            }
        }

        /// <summary>
        /// Draws option screen
        /// </summary>
        internal static void DrawOptionScreen()
        {
            Raylib.DrawRectangleRounded(Shapes.PlayerColor1, 1F, 1, playerColors[player1ColorIndex]);
            Raylib.DrawRectangleRounded(Shapes.PlayerColor2, 1F, 1, playerColors[player2ColorIndex]);
            Raylib.DrawRectangleRounded(Shapes.StartGame, 1F, 1, Color.GREEN);
            Raylib.DrawTexture(playerTextures[player1TextureIndex], Program.width / 3 - 100, Program.height / 3 - 100, Color.WHITE);
            Raylib.DrawTexture(playerTextures[player2TextureIndex], Program.width / 3 * 2 - 100, Program.height / 3 - 100, Color.WHITE);
            Raylib.DrawText("Player 1", Program.width / 3 - 165, Program.height / 2 + 15, 75, Color.WHITE);
            Raylib.DrawText("Player 2", Program.width / 3 * 2 - 165, Program.height / 2 + 15, 75, Color.WHITE);
            Raylib.DrawText("Start", Program.width / 2 - 115, Program.height / 3 * 2 + 15, 75, Color.WHITE);
            if(samePlayerTexture == true)
            {
                Raylib.DrawText("Cannot have the same character.", Program.width / 2 - 200 - 300, Program.height / 3 * 2 + 100, 50, Color.RED);
            }
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
        //Option screen
        public static Rectangle StartGame { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 3 * 2, 400, 100);
        public static Rectangle PlayerTexture1 { get; set; } = new Rectangle(Program.width / 3 - 100, Program.height / 3 - 100, 200, 200);
        public static Rectangle PlayerTexture2 { get; set; } = new Rectangle(Program.width / 3 * 2 - 100, Program.height / 3 - 100, 200, 200);

        public static Rectangle PlayerColor1 { get; set; } = new Rectangle(Program.width / 3 - 200, Program.height / 2, 400, 100);
        public static Rectangle PlayerColor2 { get; set; } = new Rectangle(Program.width / 3 * 2 - 200, Program.height / 2, 400, 100);

        ///Win scren
        public static Rectangle RestartButton { get; set; } = new Rectangle(Program.width / 2 - 450, Program.height / 3 * 2, 400, 100);

        public static Rectangle HomeScreenButton { get; set; } = new Rectangle(Program.width / 2 + 50, Program.height / 3 * 2, 400, 100);

        //Home Screen
        public static Rectangle StartButton { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 2 - 100, 400, 100);

        public static Rectangle QuitButton { get; set; } = new Rectangle(Program.width / 2 - 200, Program.height / 2 + 100, 400, 100);
    }
}