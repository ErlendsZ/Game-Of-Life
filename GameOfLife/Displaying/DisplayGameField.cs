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
        public void PrintArray(int[,] gameField)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] + " ");
                    
                }
                Console.WriteLine();
              
            }
                //if (gameField.GetLength(0) <= gameField.GetLength(1))
                //    Console.SetCursorPosition(7 + gameField.GetLength(1), 7 + gameField.GetLength(0));

                //if (gameField.GetLength(0) > gameField.GetLength(1))     
                //    Console.SetCursorPosition(7 + gameField.GetLength(1), 7 + gameField.GetLength(0));  
        }
        public void PrintStartingArray(int[,] gameFieldArray)
        {
            Console.WriteLine("Starting field");
            Console.WriteLine();
            DisplayGameField gameIterator = new DisplayGameField();
            gameIterator.PrintArray(gameFieldArray);
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        public void PrintEveryArrayIteration(int[,] gameFieldArray)
        {
          
            int IterationCounter = 0;
            NextCellGeneration rules = new NextCellGeneration();

            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Iteration " + (IterationCounter + 1));
                Console.WriteLine();
                rules.CellCalculation(gameFieldArray);

                // Prints changed field
                DisplayGameField gameIterator = new DisplayGameField();
                gameIterator.PrintArray(gameFieldArray);
                Console.WriteLine();
                Thread.Sleep(1000);
                IterationCounter++;
            }
        }
    }
}
