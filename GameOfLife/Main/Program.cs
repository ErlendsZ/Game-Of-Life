﻿
using GameOfLife;

public class Program
{
    static public void Main(string[] args)
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








