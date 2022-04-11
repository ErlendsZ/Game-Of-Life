using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class StartNewGameOfLife
    {
        public void CreateNewGame()
        {
            GameFieldSize gameFieldSize = new GameFieldSize();
            int lenght = gameFieldSize.SetFielDimensions(gameFieldSize.messageLenght, gameFieldSize.invalidInput);
            int width = gameFieldSize.SetFielDimensions(gameFieldSize.messageWidth, gameFieldSize.invalidInput);

            CellPopulator randomCellGenerator = new CellPopulator();
            int[,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);

            DisplayGameField displayGameField = new DisplayGameField();
            displayGameField.PrintStartingArray(gameFieldArray);
            displayGameField.PrintEveryArrayIteration(gameFieldArray);
        }
    }




}
