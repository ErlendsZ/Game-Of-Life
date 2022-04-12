using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameManager
    {
        public void CreateNewGame()
        {
            GameFieldSize gameFieldSize = new GameFieldSize();
            int lenght = gameFieldSize.SetFieldDimensions(gameFieldSize.messageLenght, gameFieldSize.invalidInput);
            int width = gameFieldSize.SetFieldDimensions(gameFieldSize.messageWidth, gameFieldSize.invalidInput);

            CellPopulator randomCellGenerator = new CellPopulator();
            int[,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);

            DisplayGameField displayGameField = new DisplayGameField();
            displayGameField.PrintStartingArray(gameFieldArray);
            NextGenerationGameField(gameFieldArray);
        }

        /// <summary>
        /// Formats new generation of cells in gameField array output
        /// </summary>
        /// <param name="gameField">Previous generation of cells</param>
        public void NextGenerationGameField(int[,] gameFieldArray)
        {
            DisplayGameField displayGameField = new DisplayGameField();
            CellGenerationIterator calculateIterations = new CellGenerationIterator();
            NextCellGeneration nextCellGeneration = new NextCellGeneration();

            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Iteration " + calculateIterations.IterationCounter());
                Console.WriteLine();
                nextCellGeneration.CellCalculation(gameFieldArray);
                displayGameField.PrintArray(gameFieldArray);
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }




}
