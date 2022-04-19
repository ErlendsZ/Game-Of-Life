namespace GameOfLife
{
    public class FileReader
    {
        public void ReadLastInputData()
        {
            string FileName = @"./GameOfLifeOutput.txt";

            int Lenght = Int16.Parse(File.ReadLines(FileName).Skip(1).Take(2).First());
            int Width = Int16.Parse(File.ReadLines(FileName).Skip(3).Take(4).First());
            int index = 0;
            int Total = Lenght * Width;

            string[,] array2D = new string[Lenght, Width];
            string[] array1D = new string[Total];
            string [] lines = File.ReadAllLines(@"./GameOfLifeOutput.txt");
            

            foreach (string line in lines)
            {
                Console.WriteLine(line);

            }

            Console.WriteLine("Entered Lenght " + Lenght);
            Console.WriteLine("Entered Width " + Width);

            foreach (var line in lines.Reverse())
            {

                //if (line == "")
                //    break;

                //for (int i = 0; i < length; i++)
                //{
                //    array1D[index] = line[i];
                //    index++;
                //}
               
                // process line here
                Console.WriteLine(line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
