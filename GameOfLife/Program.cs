public class Program
{
    static public void Main(string[] args)
    {
        GameFieldSize gameFieldSize = new GameFieldSize();
        int lenght = gameFieldSize.SelectLenght();
        int width = gameFieldSize.SelectWidth();

        RandomCellGenerator randomStart = new RandomCellGenerator();
        int [,] createdArr = randomStart.RandCells(new int[width, lenght]);

        Console.WriteLine();

        GameIterator gameIterator = new GameIterator();
        gameIterator.PrintArrayIteration(createdArr);

    }

}

public class GameIterator { 
    //Iterating through field each second
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
                int number = rand.Next(0, 2); //writes random number between 0-1
                GameField[i, j] = number;
                Console.Write(GameField[i, j] + " ");
            }
            Console.WriteLine();
        }
        int [,] pollutedArray = GameField;

        return pollutedArray;
    }
     
}



class GameFieldSize
{
    //Field size set up  2D array
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

class Cell
{
    // isAlive or isNotAlive (1/0)
    
}
