namespace GameOfLife
{
    public class Game
    {
        private GameFieldData? gameFieldData;
        private Renderer renderer = new Renderer();

        /// <summary>
        /// Main menu of game, which, high level game request logic for proper 
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
                        UserComunicator.PrintWarningMessage(Repository.QuitGameMessage, 0);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        /// <summary>
        /// Creates new game. Sets every time iteration = 1
        /// so that, when:
        /// 1.starting new game;
        /// 2.continuing game
        /// 3.starting new game.
        /// Iteration count would not continue to increase but also resets to 1
        /// Calls constructor for user input and gamearray initialization
        /// </summary>
        public void ExecuteNewGame()
        {
            GameStateChecker.iterationCount = 1;
            gameFieldData = new GameFieldData();
            AdvanceExistingGame();
        }

        /// <summary>
        /// Since rendering array increases iteration counter,
        /// GameStateChecker is set to decrement. Based on key Press executes
        /// either:
        /// 1.Save; 2.Load 3.Quit comands. Quits to main menu.
        /// </summary>
        public void AdvanceExistingGame()
        {
            GameStateChecker.iterationCount--;
            SavedObjects savedObjects = new SavedObjects();
            GameHandler gameHandler = new GameHandler();
            bool isGameOn = true;
            

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
                        gameHandler.SaveData(gameFieldData);
                        GameStateChecker.iterationCount--;
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        isGameOn = false;
                        break;
                    case ConsoleKey.L:
                        object savedData = gameHandler.LoadData();
                        savedObjects = (SavedObjects)savedData;
                        GameStateChecker.iterationCount = savedObjects.Iteration -1;
                        gameFieldData = savedObjects.GameFieldData;
                        Thread.Sleep(500);
                        Console.Clear();
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
