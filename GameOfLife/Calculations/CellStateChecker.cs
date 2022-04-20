namespace GameOfLife
{
    public class CellStateChecker
    {
        public int AliveCellsInCurrentIteration(int[,] gameFieldArray)
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
    }
}
