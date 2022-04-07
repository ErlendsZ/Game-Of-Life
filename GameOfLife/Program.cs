

using GameOfLife;

public class Program
{
    static public void Main(string[] args)
    {
        int IterationCounter = 0;

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



class Rules
{
  
   public int[,] CellCalculation(int [,] GameField) 
    {

        int[,] tempArr = (int[,])GameField.Clone(); 
        int lenght = GameField.GetLength(0);
        int width = GameField.GetLength(1);
        int[] cordinatesArrX = new int[] { -1, 0, 1 };

        for (int i = 0; i < lenght; i++)
        {

            for (int j = 0; j < width; j++)     // set copied same size array elements to 0
            {
                tempArr[i, j] = 0;
               
            }

        }


        for (int i = 0; i < lenght; i++)
        {

            for (int j = 0; j < width; j++)
            {
                int liveCells = 0;

                foreach (var cordinate in cordinatesArrX)   // Cordinates of each neighbour
                {
                    int x = cordinate + i;
                    int y = j;

                    if (x >= 0 && x < lenght && y >= 0 && y < width && x != y && GameField[x, y] == 1)
                    {
                        liveCells++;

                    }
                }
                foreach (var cordinate in cordinatesArrX)
                {
                    int x = cordinate + i;
                    int y = j-1;

                    if (x >= 0 && x < lenght && y >= 0 && y < width  && GameField[x, y] == 1)
                    {
                        liveCells++;

                    }
                }
                foreach (var cordinate in cordinatesArrX)
                {
                    int x = cordinate + i;
                    int y = j + 1;

                    if (x >= 0 && x < lenght && y >= 0 && y < width  && GameField[x, y] == 1)
                    {
                        liveCells++;

                    }
                }
//-----------------------------------------------------------------------------------------------------------

                //Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                //Any live cell with two or three live neighbours lives on to the next generation.
                //Any live cell with more than three live neighbours dies, as if by overpopulation.
                //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.


                if (GameField[i,j] == 0 && liveCells == 3 ) // Calculate cell state according to game rules
                {
                    tempArr[i,j] = 1; 

                } else if (GameField[i,j] == 1)
                {
                    if (liveCells == 2 || liveCells == 3)
                    {
                        tempArr[i, j] = 1;
                    }
                }
          

            } 
        }

        
        for (int i = 0; i < lenght; i++)    // Rewrite
        {

            for (int j = 0; j < width; j++)
            {

            GameField[i,j] = tempArr[i,j];  
            }

        }
        return GameField;
    }

 

}







   
