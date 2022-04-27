﻿namespace GameOfLife
{
    /// <summary>
    /// Repository of all text messages presented to user
    /// </summary>
    public static class Repository
    {
        public const string EnterCollumsCountMessage = "Enter collum count: ";
        public const string EnterRowsCountMessage = "Enter row count: ";
        public const string PressKeyMessage = "Press any key to continue.";
        public const string NotNumberMessage = "Input must be a number!";
        public const string OutOfRangeMessage = "Selected number is too high or low!";
        public const string MainMenuMessage = "1.Start New Game. \n2.Continue. \n3.Quit Game";
        public const string IteratorMessageFirstPart = "Iteration: ";
        public const string IteratorMessageSecondPart = " in Game Of Life";
        public const string LoadedIterationMessageFirstPart = "Loading Iteration: ";
        public const string SavedIterationMessageFirstPart = "Saved Iteration: ";
        public const string LiveCellCountMessage = "There are currently: {0} Live Cells";
        public const string LoadedSavedMessageSecondPart = " of Game Of Life";
        public const string QuitGameMessage = " You quit the game :( ";
        public const string DataFileName = "GameOfLife.data";
        public const string ExitSaveMessage = "Press ESC to exit to main menu, S to save game state, L to load saved game state";
    }
}
