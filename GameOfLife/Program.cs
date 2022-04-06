public class Program
{
    static public void Main(string[] args)
    {
        GameFieldSize gameFieldSize = new GameFieldSize();  // Set field size
        int lenght = gameFieldSize.SelectLenght();
        int width = gameFieldSize.SelectWidth();

        RandomCellGenerator randomCellGenerator = new RandomCellGenerator();        // Generates Cells in field
        int [,] gameArr = randomCellGenerator.RandCells(new int[width, lenght]);
        Console.WriteLine();

        Console.WriteLine("Starting field");
        Console.WriteLine();
        GameIterator gameIterator = new GameIterator();         // Prints Generated field 
        gameIterator.PrintArrayIteration(gameArr);
        Console.WriteLine();


        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Iteration " + (i+1));
            Console.WriteLine();
            Rules rules = new Rules();      // Change contents of field according to rules (1 itteration)
            rules.CellCalculation(gameArr);
          

            gameIterator.PrintArrayIteration(gameArr);  // Prints changed field
            Console.WriteLine();
        }
     

    }

}

public class GameIterator { 

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
    }

}

class Rules
{
   //Any live cell with fewer than two live neighbours dies, as if by underpopulation.
   //Any live cell with two or three live neighbours lives on to the next generation.
   //Any live cell with more than three live neighbours dies, as if by overpopulation.
   //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

   public int[,] CellCalculation(int [,] GameField) 
    {
        // NOT IMPLEMENTED, CALCULATION CODE GOES HERE
        int[,] tempArr = GameField;

        for (int i = 0; i < GameField.GetLength(0); i++)
        {
            for (int j = 0; j < GameField.GetLength(1); j++)
            {
                GameField[i, j] = 2;
            } 
        }

        return GameField;

    }



}

public class RandomCellGenerator
{
    // Generates randomly which cells are alive which not
    public int[,] RandCells(int[,] GameField)
    {
        Random rand = new Random();
        

        for (int i = 0; i < GameField.GetLength(0); i++)
        {
           
            for (int j = 0; j < GameField.GetLength(1); j++)
            {
                int number = rand.Next(0, 2); // Writes random number between 0-1
                GameField[i, j] = number;
            }

        }

        return GameField;
    }
     
}



class GameFieldSize
{
    // Field size set up  2D array
    public int SelectLenght()
    {
        Console.WriteLine("Enter Lenght");
        int lenght = Convert.ToInt32(Console.ReadLine());
        return lenght;
    }

    public int SelectWidth()
    {
        Console.WriteLine("Enter Lenght");
        int lenght = Convert.ToInt32(Console.ReadLine());
        return lenght;

    }

}
