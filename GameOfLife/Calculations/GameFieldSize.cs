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

            try
            {
               int lenght = Convert.ToInt32(Console.ReadLine());
                if(lenght <= 0)
                {
                    Console.WriteLine("Invalid input try again!");
                    return SelectLenght();
                }
               return lenght;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input try again!");
                return SelectLenght();
            }
        
        }

        public int SelectWidth()
        {
            Console.WriteLine("Enter Width");
            try
            {
                int width = Convert.ToInt32(Console.ReadLine());
                if (width <= 0)
                {
                    Console.WriteLine("Invalid input try again!");
                    return SelectWidth();
                }
                return width;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input try again!");
                return SelectWidth();
            }
        

        }

    }

}
