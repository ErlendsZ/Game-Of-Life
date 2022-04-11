using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{

    public class CellPopulator
    {
       
        public int[,] RandomizeCells(int[,] gameField)
        {
            Random randomizer = new Random();

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    //gameField[i, j] = randomizer.Next(0, 2); 
                    GliderCreation(gameField);

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
