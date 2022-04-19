namespace GameOfLife
{
    public class FileReader
    {
        public void ReadLastInputData()
        {
            string FileName = @"./GameOfLifeOutput.txt";

            int Lenght = Int16.Parse(File.ReadLines(FileName).Skip(1).Take(2).First());
            int Width = Int16.Parse(File.ReadLines(FileName).Skip(3).Take(4).First());
 
     
            Console.WriteLine("width is "  );
            Console.WriteLine("lenght is "  );
            Console.WriteLine("Line" + Lenght);
            Console.WriteLine("Line" + Width);
            
            string[] lines = File.ReadAllLines(@"./GameOfLifeOutput.txt");
            string[,] data = new string[20,20];
            

            foreach (string line in lines)
            {
                Console.WriteLine(line);
              
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
