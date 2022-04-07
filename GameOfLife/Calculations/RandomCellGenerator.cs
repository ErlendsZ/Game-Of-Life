using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{

    public class RandomCellGenerator
    {
        // Generates randomly which cells are alive which not
        public int[,] RandCells(int[,] GameField)
        {
            Random rand = new Random();

            for (int i = 0; i < GameField.GetLength(0); i++)
            {

                for (int j = 0; j < GameField.GetLength(1); j++)
                {
                    int number = rand.Next(0, 2); // Writes random number between 0-1
                    GameField[i, j] = number;
                }

            }

            return GameField;
        }

    }
}
