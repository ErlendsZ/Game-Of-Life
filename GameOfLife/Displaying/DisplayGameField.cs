using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class DisplayGameField
    {
        
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
        }
        /// <summary>
        /// Prints generated starting field base on CellPupulator class
        /// </summary>
        /// <param name="gameFieldArray"></param>
        public void PrintStartingArray(int[,] gameFieldArray)
        {
            Console.WriteLine("Starting field");
            Console.WriteLine();
            DisplayGameField gameIterator = new DisplayGameField();
            gameIterator.PrintArray(gameFieldArray);
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Prints next sarray iteration based on game rules
        /// </summary>
        /// <param name="gameFieldArray"></param>
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
