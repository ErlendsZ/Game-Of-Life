namespace GameOfLife
{
    public static class UserMessages
    {
        
        public static int i = 0;
        public static string InputLenghtMessage()
        {
            string lenght = "Enter Lenght";
            return lenght;
        }
        public static string InputWidthMessage()
        {
            string width = "Enter Width";
            return width;
        }

        public static string ErrorMessage()
        {
            string errorMessage = "Invalid input, please try again!";
            return errorMessage;
        }
        public static void IterationMessage()
        {
            i++;
            Logger.WriteLine("Iteration " + i);
            Logger.WriteLine("");
        }

        public static void StartingMessage()
        {
            Logger.WriteLine("Starting field");
        }

        public static void LiveCellsMessage(int[,] gameFieldArray)
        {
            CellStateChecker calculateAliveCells = new CellStateChecker();
            Logger.WriteLine("Live cell count  " + calculateAliveCells.AliveCellsInCurrentIteration(gameFieldArray) +  "  ");
        }

        public static void OutputChoiceMessage()
        {
            Console.WriteLine("Write 1 for txt output 0 for only console output");
        }

        public static string DisplayMainMenu()
        {
            string MainMenuMessages = "1. Start Game. \n2. Load Game. \n3. Quit Game";
            return MainMenuMessages;
        }
        public static void IncorrectInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input must be a number!");
            Console.ResetColor();
        }

        public static void NumberTooHighOrLow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Selected number is too high or low!");
            Console.ResetColor();
        }

        public static void ExitOngoingGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press 2 to go back to menu");
            Console.ResetColor();
        }
    }
}
