using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameFieldSize
    {
        // Field size set up  2D array
        public int SelectLenght()
        {
            Console.WriteLine("Enter Lenght");
            string lenghtInput = Console.ReadLine();

            bool success = Int32.TryParse(lenghtInput, out int lenght);

            if (success)
            {
                return lenght;
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
            }
            return SelectLenght();
        }

        public int SelectWidth()
        {
            Console.WriteLine("Enter Width");
            string widthInput = Console.ReadLine();

            bool success =Int32.TryParse(widthInput, out int width);

            if (success)
            {
                return width;
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
            }
            return SelectWidth();
        
                
        }

    }

}
