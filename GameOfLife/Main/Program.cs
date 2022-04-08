

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

        RandomCellGenerator randomCellGenerator = new RandomCellGenerator();        // Generates Cells in field
        int [,] gameArr = randomCellGenerator.RandCells(new int[width, lenght]);
        Console.WriteLine();

        Console.WriteLine("Starting field");
        Console.WriteLine();
        GameIterator gameIterator = new GameIterator();         // Prints Generated field 
        gameIterator.PrintArrayIteration(gameArr);
        Console.WriteLine();

        Thread.Sleep(1000);

        while (!Console.KeyAvailable)
        {
            Console.WriteLine("Iteration " + (IterationCounter + 1));
            Console.WriteLine();
            Rules rules = new Rules();      // Change contents of field according to rules (1 itteration)
            rules.CellCalculation(gameArr);
          

            gameIterator.PrintArrayIteration(gameArr);  // Prints changed field
            Console.WriteLine();
            Thread.Sleep(1000);
            IterationCounter++;

          
        }
     

    }

}








