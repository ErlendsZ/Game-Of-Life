using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class NextCellGeneration
    {

        /// <summary>
        /// /  Calculates next generation of cells and
        ///  updates game field acording to these 4 rules:
        ///     Any live cell with fewer than two live neighbours dies, as if by underpopulation.
        //      Any live cell with two or three live neighbours lives on to the next generation.
        //      Any live cell with more than three live neighbours dies, as if by overpopulation.
        //      Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        /// </summary>
        /// <param name="gameField"></param>
        public void CellCalculation(int[,] gameField)
        {
           
            int lenght = gameField.GetLength(0);
            int width = gameField.GetLength(1);
            int[,] tempArr = new int[lenght, width];

            for (int i = 0; i < lenght ; i++)
            {
                for (int j = 0; j < width ; j++)
                {

                   int liveNeighbourCells = CalculateAliveNeighbourCount(lenght, width, i, j, gameField);

                    // Calculate current cell state according to game rules
                    if (gameField[i, j] == 1 && (liveNeighbourCells == 3 || liveNeighbourCells == 2)) 
                    {
                        tempArr[i, j] = 1;
                    }
                    else if (gameField[i, j] == 0 && (liveNeighbourCells == 3)) 
                    {
                        tempArr[i, j] = 1;
                    }
                }
            }

            CopyIterationArrayToGameFieldArray(lenght,  width,  tempArr,  gameField);
        }

        public int CalculateAliveNeighbourCount(int lenght, int width, int i, int j, int[,] gameField)
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

                    liveNeighbourCells = liveNeighbourCells + gameField[cordinateX, cordinateY];

                }
            }
            liveNeighbourCells = liveNeighbourCells - gameField[i, j];
            return liveNeighbourCells;
        }

        public int [,] CopyIterationArrayToGameFieldArray(int lenght, int width, int [,] tempArr, int [,] gameField)
        {

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    gameField[i, j] = tempArr[i, j];
                }
            }
            return gameField;

        }

    }
}


