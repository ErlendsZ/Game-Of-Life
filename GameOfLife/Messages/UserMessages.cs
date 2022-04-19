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
            Logger.WriteLine("Live cell count  " + calculateAliveCells.AliveCellsInCurrentIteration(gameFieldArray));
        }

        public void OutputChoiceMessage()
        {
            Console.WriteLine("Write 1 for txt output 0 for only console output");
        }
    }
}
