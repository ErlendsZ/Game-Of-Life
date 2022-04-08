using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameIterator
    {

        //Iterating through field and displaying results
        public void PrintArrayIteration(int[,] GameField)
        {

            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(1); j++)
                {
                    Console.Write(GameField[i, j] + " ");
                }
                Console.WriteLine();
            }
            if(GameField.GetLength(0) < GameField.GetLength(1))
            {
                Console.SetCursorPosition(7 + GameField.GetLength(1), 7 + GameField.GetLength(0));
            }

            else
            {
                Console.SetCursorPosition(7 + GameField.GetLength(1), 7 + GameField.GetLength(0));
            }
        
        }

    }
}
