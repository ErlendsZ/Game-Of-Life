public class Program
{
    static public void Main(string[] args)
    {
        Game GameIterator = new Game();
        GameIterator.CurrentField();

        PrintFieldIteration();
    }

    

    static void PrintFieldIteration()
    {
        //Console.WriteLine("sds");
    }
}

public class Game
{   
    //Iterating through field each second
    public void CurrentField()
    {
        Console.WriteLine("Enter Lenght");
        int lenght = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Width");
        int width = Convert.ToInt32(Console.ReadLine());
        int[,] GameField = new int[width, lenght];

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
class Field
{
    //Field size 2D array
}

class Cell
{
    // isAlive or isNotAlive (1/0)
    
}
