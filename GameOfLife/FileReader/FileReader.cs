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
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(@"./GameOfLifeOutput.txt");
            string[,] data = new string[20,20];
            

            
            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine(line);
              
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
