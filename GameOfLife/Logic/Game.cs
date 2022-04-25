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
                        GameHandler.SaveData(gameFieldData);
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
            gameFieldData = new GameFieldData(true);
            AdvanceExistingGame();
        }

        public void AdvanceExistingGame()
        {
            bool isGameOn = true;

            if (gameFieldData == null)
            {
                return;
            }

            while (isGameOn)
            {
                renderer.PrintArray(GameFieldData.gameFieldArray);
                gameFieldData.GetNextGeneration();
                UserComunicator.PrintWarningMessage(Repository.ExitSaveMessage);
                ConsoleKey key = UserComunicator.KeyPressed();
                switch (key)
                {
                    case ConsoleKey.S:
                        GameHandler.SaveData(gameFieldData);
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        isGameOn = false;
                        break;
                    case ConsoleKey.L:
                        //gameFieldData = GameHandler.LoadGame();
                        GameHandler.LoadGame();
                       // GameFieldData.gameFieldArray = GameHandler.LoadGame();
                        break;
                }
                Thread.Sleep(1000);
            }

        }
    }
}
