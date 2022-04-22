using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {
        GameFieldData? gameFieldData;
        Renderer renderer = new Renderer();

        /// <summary>
        /// Contains, high level game request logic for proper 
        /// execution of game of life
        /// </summary>
        public void Run()
        {
            GameHandler dataSaver = new GameHandler();

            while (true)
            {
                int choice = UserComunicator.GetInputValueRanged(Repository.MainMenuMessage, 1, 3);

                switch (choice)
                {
                    case 1:
                        ExecuteNewGame();
                        break;
                    case 2:
                        //gameFieldData = dataSaver.LoadData(gameFieldData);
                        dataSaver.SaveData(gameFieldData);
                        AdvanceExistingGame();
                        UserComunicator.PrintOrdinaryMessage(Repository.PressKeyMessage);
                        Console.ReadKey();
                        break;
                    case 3:
                        UserComunicator.PrintWarningMessage(Repository.QuitGameMessage);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void ExecuteNewGame()
        { 
            GameStateChecker.iterationCount = 0;
            gameFieldData = new GameFieldData();
            AdvanceExistingGame();
        }

        public void AdvanceExistingGame()
        {
            while (!Console.KeyAvailable)
            {
                renderer.PrintArray(gameFieldData.gameFieldArray);
                gameFieldData.GetNextGeneration();
                //Monitor key press function
                Thread.Sleep(1000);
            }

        }
    }
}
