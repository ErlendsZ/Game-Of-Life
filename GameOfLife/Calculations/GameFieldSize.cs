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
        public  T SetFielDimensions<T>(T UserMessage, T InvalidInpuptMessage)
        {
            Console.WriteLine(UserMessage);

            string userInputDimension = Console.ReadLine();

            bool success = Int32.TryParse(userInputDimension, out int dimension);

            if (success && dimension > 1)
            {
                return (T)Convert.ChangeType(dimension, typeof(T));
            }
            else
            {
                Console.WriteLine(InvalidInpuptMessage);
                return SetFielDimensions(UserMessage, InvalidInpuptMessage);
                
            }

        }

    }


}

