public class Program
{
    static public void Main(string[] args)
    {
        SetFieldSize();
        PrintFieldIteration();
    }

    static void SetFieldSize()
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

    static void PrintFieldIteration()
    {
        //Console.WriteLine("sds");
    }
}

