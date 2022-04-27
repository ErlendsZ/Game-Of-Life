namespace GameOfLife
{
    /// <summary>
    /// Contains data of array dimensions and data about 
    /// next generation results based on previous
    /// </summary>
    [Serializable]
    public class GameFieldData
    {
        public int[,]? gameFieldArray;
        public GameFieldData()
        {
            int rows = UserComunicator.GetInputValueRanged(Repository.EnterRowsCountMessage, 5, 50);
            int colums = UserComunicator.GetInputValueRanged(Repository.EnterCollumsCountMessage, 5, 50);
            gameFieldArray = new int[rows, colums];
            CellPopulator.RandomizeCells(gameFieldArray);
        }

        /// <summary>
        ///  Calculates next generation of cells and updates gameField acording to these 4 rules:
        ///  1)Any live cell with fewer than two live neighbours dies, as if by underpopulation.
        ///  2)Any live cell with two or three live neighbours lives on to the next generation.
        ///  3)Any live cell with more than three live neighbours dies, as if by overpopulation.
        ///  4)Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        /// </summary>
        /// <param name="gameField">Passing previous generation of array for next generation cell calculation</param>
        public void GetNextGeneration()
        {
            int lenght = gameFieldArray.GetLength(0);
            int width = gameFieldArray.GetLength(1);
            int[,] nextGenerationOfCells = new int[lenght, width];
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int liveNeighbourCells = CalculateAliveNeighbourCount(lenght, width, i, j, gameFieldArray);

                    if (gameFieldArray[i, j] == 1 && (liveNeighbourCells == 3 || liveNeighbourCells == 2))
                    {
                        nextGenerationOfCells[i, j] = 1;
                    }
                    else if (gameFieldArray[i, j] == 0 && (liveNeighbourCells == 3))
                    {
                        nextGenerationOfCells[i, j] = 1;
                    }
                }
            }
            CopyNextGenerationArrayToGameFieldArray(lenght, width, nextGenerationOfCells, gameFieldArray);
        }

        /// <summary>
        /// Calculates state of currently selected cell 8 neihbhours. Live neihbour = 1. Dead = 0
        /// </summary>
        /// <param name="lenght">gameField array lenght</param>
        /// <param name="width"> gameField array lenght</param>
        /// <param name="i"> Selected cell cordinate in array</param>
        /// <param name="j"> Selected cell cordiante in arry</param>
        /// <param name="gameField"> array from which current cell acording to [i,j] cordinates
        /// is taken for neighbour search[cordinateX,cordinateY]</param>
        /// <returns>Live neighbour count of currently selected cell</returns>
        private int CalculateAliveNeighbourCount(int lenght, int width, int i, int j, int[,] gameField)
        {
            int liveNeighbourCells = 0;

            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    int cordinateX = i + x;
                    int cordinateY = j + y;

                    if (cordinateX > lenght - 1)
                    {
                        cordinateX = 0;
                    }

                    if (cordinateX < 0)
                    {
                        cordinateX = lenght - 1;
                    }

                    if (cordinateY > width - 1)
                    {
                        cordinateY = 0;
                    }

                    if (cordinateY < 0)
                    {
                        cordinateY = width - 1;
                    }

                    liveNeighbourCells += gameField[cordinateX, cordinateY];
                }
            }
            liveNeighbourCells -= gameField[i, j];
            return liveNeighbourCells;
        }

        private void CopyNextGenerationArrayToGameFieldArray(int lenght, int width, int[,] nextGenerationOfCells, int[,] gameField)
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    gameField[i, j] = nextGenerationOfCells[i, j];
                }
            }
        }
    }
}


