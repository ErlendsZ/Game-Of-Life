using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameFieldSize
    {
        /// <summary>
        /// Field size set up  2D array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userMessage"></param>
        /// <param name="invalidInpuptMessage"></param>
        /// <returns></returns>
        public T SetFielDimensions<T>(T userMessage, T invalidInpuptMessage)
        {
            Console.WriteLine(userMessage);
            string userInputDimension = Console.ReadLine();

            bool success = Int32.TryParse(userInputDimension, out int dimension);

            if (success && dimension > 1 && dimension < 1001)
            {
                return (T)Convert.ChangeType(dimension, typeof(T));
            }
            else
            {
                Console.WriteLine(invalidInpuptMessage);
                return SetFielDimensions(userMessage, invalidInpuptMessage);
                
            }

        }

    }


}

