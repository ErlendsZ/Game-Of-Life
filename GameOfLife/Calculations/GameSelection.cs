using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameSelection
    {
        public int SelectMode()
        {
            GameManager gameManager = new GameManager();
            UserMessages userMessages = new UserMessages();

            userMessages.GetMenuSelection();

            switch (GetInputValue())
            {
                case 1:
                    gameManager.BuildGame();
                    return 1;
                    break;
                case 2:
                    Console.WriteLine("2. Load Game not implemented");
                    return 2;
                    break;
                case 3:
                    Console.WriteLine("3. Quit Game");
                    Environment.Exit(0);
                    return 3;
                    break;
                default:
                    return GetInputValue();
            }
        }

        private int GetInputValue()
        {
            UserMessages userMessages = new UserMessages();
            bool success = Int32.TryParse(Console.ReadLine(), out int input);

            if (success)
            {
                userMessages.ErrorMessage();
                return input;
            }
           
            else
            {
                Console.WriteLine(userMessages.ErrorMessage());
                userMessages.ErrorMessage();
                userMessages.GetMenuSelection();
                return GetInputValue();
            }
        }
    }
}
