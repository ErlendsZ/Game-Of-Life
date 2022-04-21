using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {
        public void Run()
        {
            while (true)
            {
                int choice = UserComunicator.GetInputValueRanged(Repository.MainMenuMessage, 1, 3);

                switch (choice)
                {
                    case 1:
                        ExecuteNewGame();
                        break;
                    case 2:
                        UserComunicator.PrintErrorMessage("Not Implemented");
                        UserComunicator.PrintOrdinaryMessage(Repository.PressKeyMessage);
                        Console.ReadKey();
                        break;
                    case 3:
                        UserComunicator.PrintHeaderMessage("dogee");
                        UserComunicator.PrintOrdinaryMessage(Repository.PressKeyMessage);
                        Console.ReadKey();
                        break;
                }
            }
           
        }

        public void ExecuteNewGame()
        {
            CellStateChecker.iterationCount = 0;
            GameFieldData gameFieldData = new GameFieldData();
            Renderer renderer = new Renderer();
            while (!Console.KeyAvailable)
            {
                renderer.PrintArray(gameFieldData.gameFieldArray);
                gameFieldData.GetNextGeneration();
                Thread.Sleep(1000);
            }
        }
    }
}
