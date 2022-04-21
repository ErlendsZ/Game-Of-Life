namespace GameOfLife
{
    public static class UserMessages
    {
        public static int i = 0;
        public static void IterationMessage()
        {
            i++;
            Console.WriteLine("Iteration " + i);
            Console.WriteLine("");
        }

        public static void LiveCellsMessage(int[,] gameFieldArray)
        {
            CellStateChecker calculateAliveCells = new CellStateChecker();
            Console.WriteLine("Live cell count  " + calculateAliveCells.AliveCellsInCurrentIteration(gameFieldArray) +  "  ");
        }
    }
}
