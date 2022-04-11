namespace GameOfLife
{

    public class CellPopulator
    {
        /// <summary>
        /// Pupulates array with random numbers either 1 or 0. Live cell = 1. Dead
        /// cell = 0.
        /// </summary>
        /// <param name="gameField"></param>
        /// <returns></returns>
        public int[,] RandomizeCells(int[,] gameField)
        {
            Random randomizer = new Random();

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = randomizer.Next(0, 2);
                }

            }
            return gameField;
        }

        public void GliderCreation(int[,] gameField)
        {

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {

                    if (i == 1 && j == 1)
                        gameField[i, j] = 1;
                    if (i == 1 && j == 3)
                        gameField[i, j] = 1;
                    if (i == 2 && j == 2)
                        gameField[i, j] = 1;
                    if (i == 2 && j == 3)
                        gameField[i, j] = 1;
                    if (i == 3 && j == 2)
                        gameField[i, j] = 1;
                }

            }
        }

    }
}
