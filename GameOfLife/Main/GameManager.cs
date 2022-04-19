namespace GameOfLife
{
    public class GameManager
    {
        public void BuildGame()
        {
            GameFieldSize gameFieldSize = new GameFieldSize();
            UserMessages userMessages = new UserMessages();
            OutputManager outputManager = new OutputManager();
   
            bool isTextOutput = outputManager.SelectOutputType();
            int lenght = gameFieldSize.SetFieldDimensions(userMessages.InputLenghtMessage(), userMessages.ErrorMessage());
            int width = gameFieldSize.SetFieldDimensions(userMessages.InputWidthMessage(), userMessages.ErrorMessage());


            CellPopulator randomCellGenerator = new CellPopulator();
            int[,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);

            Console.Clear();
            NextGenerationGameField(gameFieldArray, isTextOutput);
        }

        /// <summary>
        /// Formats new generation of cells in gameFieldArray  output
        /// </summary>
        /// <param name="gameField">Previous generation of cells</param>
        private void NextGenerationGameField(int[,] gameFieldArray, bool isTextOutput)
        {
            DisplayGameField displayGameField = new DisplayGameField();
            NextCellGeneration nextCellGeneration = new NextCellGeneration();
            UserMessages userMessages = new UserMessages();

            nextCellGeneration.CellCalculation(gameFieldArray);

            while (!Console.KeyAvailable)
            {
                Console.SetCursorPosition(0, 0);
                userMessages.IterationMessage();
                userMessages.LiveCellsMessage(gameFieldArray);
                Logger.WriteLine("");
                displayGameField.PrintArray(gameFieldArray);
                if (isTextOutput)
                    Logger.SaveLog();
                nextCellGeneration.CellCalculation(gameFieldArray);
                Logger.WriteLine("");
                Logger.WriteLine("");
                Thread.Sleep(1000);
            }
        }
    }
}
