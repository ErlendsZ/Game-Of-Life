using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    

    public  class GameFieldSize
    {
        /// <summary>
        ///  Field size set up in 2D Array
        /// </summary>
        /// <param name="userMessage"></param>
        /// <param name="invalidInpuptMessage"></param>
        /// <returns></returns>
      
        public string SetFielDimensions( string userMessage, string invalidInpuptMessage)
        {
          
            Console.WriteLine(userMessage);
            string userInputDimension = Console.ReadLine();

            bool success = Int32.TryParse(userInputDimension, out int dimension);

            if (success && dimension > 1 && dimension < 1001)
            {
                return dimension.ToString();
            }
            else
            {
                Console.WriteLine(invalidInpuptMessage);
                return SetFielDimensions(userMessage, invalidInpuptMessage);
                
            }

        }

    }


}

