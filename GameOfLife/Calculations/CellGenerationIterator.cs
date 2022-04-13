namespace GameOfLife
{
    public class CellGenerationIterator
    {
        private int iterationCounter = 0;

        /// <summary>
        /// Iteration number counter increment by 1
        /// </summary>
        /// <returns>Iteration number for current CellGeneration</returns>
        public int IterationCounter()
        {
            iterationCounter++;
            return iterationCounter;
        }
    }
}
