
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
        public void PrintStartingArray(int[,] gameFieldArray)
        {
            UserMessages userMessages = new UserMessages();

            userMessages.StartingMessage();
            userMessages.LiveCellsMessage(gameFieldArray);
            Console.WriteLine();
            PrintArray(gameFieldArray);
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}
