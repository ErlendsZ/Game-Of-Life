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
            int lenght = Convert.ToInt32(Console.ReadLine());
            return lenght;
        }

        public int SelectWidth()
        {
            Console.WriteLine("Enter Width");
            int width = Convert.ToInt32(Console.ReadLine());
            return width;

        }

    }

}
