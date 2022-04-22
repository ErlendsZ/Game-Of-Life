namespace GameOfLife
{
    public class GameStateChecker
    {
        public static int iterationCount = 0;
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

        public static int IterationCounter()
        {
            iterationCount++;
            return iterationCount;
        }
    }
}
