﻿namespace GameOfLife
{


    public class GameFieldSize
    {
        /// <summary>
        /// Creates 2D array based on user entered dimensions
        /// </summary>
        /// <param name="userMessage"> Message to user about array dimension (lenght or width) user is expected to input</param>
        /// <param name="invalidInpuptMessage"> Message to user about invalid input attempt</param>
        /// <returns>if succcess entered dimension (either lenght or width), 
        /// else invalidInpuptMessage, then userMessage for retrying input</returns>
        /// 

        public int SetFieldDimensions(string userMessage, string invalidInpuptMessage)
        {
            Logger.WriteLine(userMessage);
            string userInputDimension = Console.ReadLine();
            Logger.ReadLine(userInputDimension);

            bool success = Int32.TryParse(userInputDimension, out int dimension);

            if (success && dimension > 1 && dimension < 1001)
            {
                return dimension;
            }
            else
            {
                Logger.WriteLine(invalidInpuptMessage);
                return SetFieldDimensions(userMessage, invalidInpuptMessage);
            }
        }
    }
}

