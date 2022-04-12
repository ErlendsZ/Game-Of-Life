
namespace GameOfLife
{
    public class DisplayGameField
    {

        public void PrintArray(int[,] gameField)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints generated starting array
        /// </summary>
        /// <param name="gameField"> Array containing randomized starting cell values</param>
        public void PrintStartingArray(int[,] gameField)
        {
            Console.WriteLine("Starting field");
            Console.WriteLine();
            PrintArray(gameField);
            Console.WriteLine();
            Thread.Sleep(1000);

        }

        /// <summary>
        /// Prints calculated and formated next generation array iteration based on previous 
        /// </summary>
        /// <param name="gameField">Array containing previous generation cell values</param>
        public void PrintEveryArrayIteration(int[,] gameField)
        {
            NextCellGeneration nextCellGeneration = new NextCellGeneration();
            nextCellGeneration.NextGenerationGameField(gameField);
        }
    }
}
