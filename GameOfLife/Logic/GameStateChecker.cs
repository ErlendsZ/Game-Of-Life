namespace GameOfLife
{
    /// <summary>
    /// Checks variable values for curent game state
    /// </summary>
    public class GameStateChecker
    {
        public static int iterationCount = 1;

        /// <summary>
        /// Calculates alive cells in GameField
        /// </summary>
        /// <param name="gameFieldArray">Current game array</param>
        /// <returns>Alive cell count</returns>
        public static int AliveCellsInCurrentIteration(int[,] gameFieldArray)
        {
            int aliveCells = 0;

            for (int i = 0; i < gameFieldArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameFieldArray.GetLength(1); j++)
                {
                    if (gameFieldArray[i, j] == 1)
                    {
                        aliveCells++;
                    }
                }
            }

            return aliveCells;
        }


        /// <summary>
        /// Iteration counter
        /// </summary>
        /// <returns>incremented iteration count by 1</returns>
        public static int IterationCounter()
        {
            iterationCount++;
            return iterationCount;
        }
    }
}
