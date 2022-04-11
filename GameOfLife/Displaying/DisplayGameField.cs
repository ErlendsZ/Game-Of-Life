
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
        /// Prints generated starting field base on CellPupulator class
        /// </summary>
        /// <param name="gameFieldArray"></param>
        public void PrintStartingArray(int[,] gameFieldArray)
        {
            Console.WriteLine("Starting field");
            Console.WriteLine();
            PrintArray(gameFieldArray);
            Console.WriteLine();
            Thread.Sleep(1000);

        }

        /// <summary>
        /// Prints next array iteration based on game nextCellGeneration
        /// </summary>
        /// <param name="gameFieldArray"></param>
        public void PrintEveryArrayIteration(int[,] gameFieldArray)
        {
            NextCellGeneration nextCellGeneration = new NextCellGeneration();
            nextCellGeneration.NextGenerationOutput(gameFieldArray);

        }
    }
}
