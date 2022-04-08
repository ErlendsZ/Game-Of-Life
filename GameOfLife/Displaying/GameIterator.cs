using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class DisplayGameField
    {
        /// <summary>
        /// Iterating through field and displaying results
        /// </summary>
        /// <param name="gameField"></param>
        public void PrintArrayIteration(int[,] gameField)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] + " ");
                    
                }
                Console.WriteLine();
              
            }
                if (gameField.GetLength(0) <= gameField.GetLength(1))
                    Console.SetCursorPosition(7 + gameField.GetLength(1), 7 + gameField.GetLength(0));

                if (gameField.GetLength(0) > gameField.GetLength(1))     
                    Console.SetCursorPosition(7 + gameField.GetLength(1), 7 + gameField.GetLength(0));
        }
    }
}
