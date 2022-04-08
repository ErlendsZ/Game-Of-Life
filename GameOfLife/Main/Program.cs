

using GameOfLife;

public class Program
{
    static public void Main(string[] args)
    {

        string messageWidth = "Enter Width";     // Set field size
        string messageLenght = "Enter Lenght";
        string invalidInput = "Invalid input, please try again!";
      
        int IterationCounter = 0;

        GameFieldSize gameFieldSize = new GameFieldSize();  
        int lenght = Int32.Parse ( gameFieldSize.SetFielDimensions(messageLenght,invalidInput) );
        int width = Int32.Parse (gameFieldSize.SetFielDimensions(messageWidth, invalidInput));

        CellPopulator randomCellGenerator = new CellPopulator();        // Generates Cells in field
        int [,] gameFieldArray = randomCellGenerator.RandomizeCells(new int[width, lenght]);
        Console.WriteLine();

        Console.WriteLine("Starting field");
        Console.WriteLine();
        DisplayGameField gameIterator = new DisplayGameField();         // Prints Generated field 
        gameIterator.PrintArrayIteration(gameFieldArray);
        Console.WriteLine();

        Thread.Sleep(1000);

        while (true)
        {
            Console.WriteLine("Iteration " + (IterationCounter + 1));
            Console.WriteLine();
            NextCellGeneration rules = new NextCellGeneration();      // Change contents of field according to rules (1 itteration)
            rules.CellCalculation(gameFieldArray);
          

            gameIterator.PrintArrayIteration(gameFieldArray);  // Prints changed field
            Console.WriteLine();
            Thread.Sleep(1000);
            IterationCounter++;


          
        }
     

    }

}








