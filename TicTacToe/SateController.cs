using Raylib_cs;
using System;

namespace TicTacToe
{
    internal static class SateController
    {
        /// <summary>
        /// Controll Playing state
        /// </summary>
        /// <param name="gameLogic">GameLogic class</param>
        /// <param name="gameState">Gamestate</param>
        /// <param name="checkWinnerRes">Check winner</param>
        internal static void IsPlaying(GameLogic gameLogic, ref GameState gameState, ref (bool isWinner, string winMessage) checkWinnerRes)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Grafic.DrawGameBoard();
            Raylib.EndDrawing();

            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
            {
                var pos = Raylib.GetMousePosition();
                gameLogic.GetRectangle(pos);
                checkWinnerRes = gameLogic.CheckWinner();
                if (checkWinnerRes.isWinner == true)
                {
                    gameState = GameState.winScreen;
                }
            }
        }

        internal static void HomeScreen(ref GameState gameState, ref bool quitGame)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Grafic.DrawMainScreen();
            Raylib.EndDrawing();

            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.StartButton))
            {
                gameState = GameState.settings;
            }
            else if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.QuitButton))
            {
                quitGame = true;
            }
        }

        /// <summary>
        /// Controll winScreen
        /// </summary>
        /// <param name="gameLogic">GameLogic class</param>
        /// <param name="gameState">gaemstate</param>
        /// <param name="checkWinnerRes">CechWinner result</param>
        internal static void WinScreen(GameLogic gameLogic, ref GameState gameState, (bool isWinner, string winMessage) checkWinnerRes)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Grafic.DrawWinScreen(checkWinnerRes.winMessage);
            Raylib.EndDrawing();
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.RestartButton))
            {
                gameLogic.ClearGame();
                gameState = GameState.isPlaying;
            }
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.HomeScreenButton))
            {
                gameLogic.ClearGame();
                gameState = GameState.homeScreen;
            }
        }

        internal static void Settings(ref GameState gameState)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Grafic.DrawOptionScreen();
            Raylib.EndDrawing();
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.PlayerColorO))
            {
                Grafic.playerOColorIndex++;
                if (Grafic.playerOColorIndex >= Grafic.playerColors.Count)
                {
                    Grafic.playerOColorIndex = 0;

                }
            }
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.PlayerColorX))
            {
                Grafic.playerXColorIndex++;
                if (Grafic.playerXColorIndex >= Grafic.playerColors.Count)
                {
                    Grafic.playerXColorIndex = 0;
                }
            }
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON) && Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), Shapes.StartGame))
            {
                gameState = GameState.isPlaying;
            }
        }

        internal static void AchimentScreen(ref GameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}