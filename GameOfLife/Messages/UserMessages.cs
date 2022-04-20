namespace GameOfLife
{
    public class UserMessages
    {
        CellGenerationIterator cellGenerationIterator = new CellGenerationIterator();
        CalculateAliveCells calculateAliveCells = new CalculateAliveCells();
        public string InputLenghtMessage()
        {
            string lenght = "Enter Lenght";
            return lenght;
        }
        public string InputWidthMessage()
        {
            string width = "Enter Width";
            return width;
        }

        public string ErrorMessage()
        {
            string errorMessage = "Invalid input, please try again!";
            return errorMessage;
        }
        public void IterationMessage()
        {
            Logger.WriteLine("Iteration " + cellGenerationIterator.IterationCounter());
        }

        public void StartingMessage()
        {
            Logger.WriteLine("Starting field");
        }

        public void LiveCellsMessage(int[,] gameFieldArray)
        {
            Logger.WriteLine("Live cell count  " + calculateAliveCells.AliveCellsInCurrentIteration(gameFieldArray) +  "  ");
        }

        public void OutputChoiceMessage()
        {
            Console.WriteLine("Write 1 for txt output 0 for only console output");
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Quit Game");
        }
        public void IncorrectInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input must be a number!");
            Console.ResetColor();
        }

        public void NumberTooHighOrLow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Selected number is too high or low!");
            Console.ResetColor();
        }

        public void ExitOngoingGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press 2 to go back to menu");
            Console.ResetColor();
        }
    }
}
