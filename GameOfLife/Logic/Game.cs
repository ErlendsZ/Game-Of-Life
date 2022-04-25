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
                        AdvanceExistingGame();
                        UserComunicator.PrintOrdinaryMessage(Repository.PressKeyMessage);
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
            
            int savedIteration = 0;

            if (gameFieldData == null)
            {
                return;
            }
            
            
            while (isGameOn)
            {
                bool isLoaded = false;
                renderer.PrintArray(gameFieldData.gameFieldArray);
                Thread.Sleep(1000);
                ConsoleKey key = UserComunicator.KeyPressed();
               
                switch (key)
                {
                    case ConsoleKey.S:
                        savedIteration = GameHandler.SaveData(gameFieldData);
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        isGameOn = false;
                        break;
                    case ConsoleKey.L:
                        GameStateChecker.iterationCount = savedIteration-1;
                        gameFieldData = GameHandler.LoadGame();
                        isLoaded = true;
                       // renderer.PrintArray(gameFieldData.gameFieldArray);
                        break;
                        default:
                        if (isLoaded == false)
                        gameFieldData.GetNextGeneration();
                        break;
                }
               
            }
        }
    }
}
