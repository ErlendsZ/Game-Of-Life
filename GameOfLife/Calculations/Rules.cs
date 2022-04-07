﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Rules
    {
        public int[,] CellCalculation(int[,] GameField)
        {
            int[,] tempArr = (int[,])GameField.Clone();
            int lenght = GameField.GetLength(0);
            int width = GameField.GetLength(1);

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)     // set copied same size array elements to 0
                {
                    tempArr[i, j] = 0;
                }
            }


            for (int i = 0; i < lenght ; i++)
            {
                for (int j = 0; j < width ; j++)
                {
                    int liveCells = 0; // Livecell neighbour count for each cell

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

                            if (cordinateY > width-1)       // Calculate outside the borders
                            {
                                cordinateY = 0;
                            }

                            if (cordinateY < 0)
                            {
                                cordinateY = width -1;
                            }

                            liveCells = liveCells + GameField[cordinateX, cordinateY];

                        }
                    }
                    liveCells = liveCells - GameField[i, j];

                    //Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                    //Any live cell with two or three live neighbours lives on to the next generation.
                    //Any live cell with more than three live neighbours dies, as if by overpopulation.
                    //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                    //1
                    if (GameField[i, j] == 1 && liveCells < 2) // Calculate cell state according to game rules
                    {
                        tempArr[i, j] = 0;
                    }
                    //2
                    else if (GameField[i, j] == 1 && (liveCells == 3 || liveCells == 2)) 
                    {
                        tempArr[i, j] = 1;
                    }
                    //3
                    else if (GameField[i, j] == 1 && (liveCells > 3))
                    {
                        tempArr[i, j] = 0;
                    }
                    //4
                    else if (GameField[i, j] == 0 && (liveCells == 3)) 
                    {
                        tempArr[i, j] = 1;
                    }
                }
            }


            for (int i = 0; i < lenght; i++)    // Rewrite
            {
                for (int j = 0; j < width; j++)
                {
                    GameField[i, j] = tempArr[i, j];
                }
            }
            return GameField;
        }

    }
}

