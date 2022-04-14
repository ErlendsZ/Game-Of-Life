using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class OutputManager
    {
        /// <summary>
        /// Based on user choice current output in a text file or not
        /// </summary>
        public int SelectOutputType()
        {
            GameManager gameManager = new GameManager();
            UserMessages userMessages = new UserMessages();

            userMessages.OutputChoiceMessage();
            bool success = Int32.TryParse(Console.ReadLine(), out int input);

            if (success && input == 1)
            {
                gameManager.CreateNewGame();
                Logger.SaveLog(); 
                return 0;
            }

            if (success && input == 0)
            {
                gameManager.CreateNewGame();
                return 0;
            }
            else
            {
                return SelectOutputType();
            }
        }
    }
}
