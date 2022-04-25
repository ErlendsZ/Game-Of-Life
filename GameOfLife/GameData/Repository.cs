namespace GameOfLife
{
    public static class Repository
    {
        public const string PressKeyMessage = "Press any key to continue.";
        public const string NotNumberMessage = "Input must be a number!";
        public const string OutOfRangeMessage = "Selected number is too high or low!";
        public const string MainMenuMessage = "1.Start New Game. \n2.Load Last Game. \n3.Quit Game";
        public const string IteratorMessageFirstPart = "Iteration: ";
        public const string IteratorMessageSecondPart = " in Game Of Life";
        public const string LoadedIterationMessageFirstPart = "Loaded Iteration: ";
        public const string SavedIterationMessageFirstPart = "Saved Iteration: ";
        public const string LoadedSavedMessageSecondPart = " of Game Of Life";
        public const string LiveCellCountMessageFirstPart = "There are currently: ";
        public const string LiveCellCountMessageSecondPart = " Live Cells ";
        public const string QuitGameMessage = " You quit the game :( ";
        public const string DataFileName = "GameOfLife.data";
        public const string ExitSaveMessage = "Press ESC to exit to main menu, S to save game state, L to load saved game state";
    }
}
