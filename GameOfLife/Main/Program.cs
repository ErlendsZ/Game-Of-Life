

using GameOfLife;

public class Program
{
    static public void Main(string[] args)
    {
        // Set field size
        string messageWidth = "Enter Width";
        string messageLenght = "Enter Lenght";
        string invalidInput = "Invalid input, please try again!";

        GameFieldSize gameFieldSize = new GameFieldSize();
        int lenght = Int32.Parse(gameFieldSize.SetFielDimensions(messageLenght, invalidInput));
        int width = Int32.Parse(gameFieldSize.SetFielDimensions(messageWidth, invalidInput));

        // Generates Cells in field
        CellPopulator randomCellGenerator = new CellPopulator();
        int[,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);
        Console.WriteLine();

        // Prints Generated field 
        DisplayGameField.PrintStartingArray(gameFieldArray);

        // Change contents of field according to rules (1 itteration)
        DisplayGameField.PrintEveryArrayIteration(gameFieldArray);

    }
}








