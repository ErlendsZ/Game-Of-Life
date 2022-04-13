namespace GameOfLife
{
    public class GameManager
    {
        public void CreateNewGame()
        {

            
            
            GameFieldSize gameFieldSize = new GameFieldSize();
            UserMessages userMessages = new UserMessages();
            Output output = new Output();
            output.TxtFileOutput();

            int lenght = gameFieldSize.SetFieldDimensions(userMessages.InputLenghtMessage(), userMessages.ErrorMessage());
            int width = gameFieldSize.SetFieldDimensions(userMessages.InputWidthMessage(), userMessages.ErrorMessage());

            CellPopulator randomCellGenerator = new CellPopulator();
            int[,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);

            DisplayGameField displayGameField = new DisplayGameField();
            displayGameField.PrintStartingArray(gameFieldArray);
            NextGenerationGameField(gameFieldArray);
        }

        /// <summary>
        /// Formats new generation of cells in gameFieldArray  output
        /// </summary>
        /// <param name="gameField">Previous generation of cells</param>
        private void NextGenerationGameField(int[,] gameFieldArray)
        {
            DisplayGameField displayGameField = new DisplayGameField();
            NextCellGeneration nextCellGeneration = new NextCellGeneration();
            UserMessages userMessages = new UserMessages();

            nextCellGeneration.CellCalculation(gameFieldArray);

            while (!Console.KeyAvailable)
            {
                userMessages.IterationMessage();
                userMessages.LiveCellsMessage(gameFieldArray);
                Console.WriteLine();
                displayGameField.PrintArray(gameFieldArray);
                nextCellGeneration.CellCalculation(gameFieldArray);
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1000);
                
            }
        }
    }




}
