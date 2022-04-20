namespace GameOfLife
{
    public class UserMessages
    {
        CalculateAliveCells calculateAliveCells = new CalculateAliveCells();
        public static int i = 0;
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
            i++;
            Logger.WriteLine("Iteration " + i);
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

        public string DisplayMainMenu()
        {
            string MainMenuMessages = "1. Start Game. \n2. Load Game. \n3. Quit Game";
            return MainMenuMessages;
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
