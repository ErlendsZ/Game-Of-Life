namespace GameOfLife
{
    public class Game
    {
        private GameFieldData? gameFieldData;
        private Renderer renderer = new Renderer();
        UserComunicator userComunicator = new UserComunicator();

        /// <summary>
        /// Main menu of game, which, high level game request logic for proper 
        /// execution of game of life
        /// </summary>
        public void Run()
        {
            while (true)
            {
                int choice = userComunicator.GetInputValueRanged(Repository.MainMenuMessage, 1, 3);

                switch (choice)
                {
                    case 1:
                        ExecuteNewGame();
                        break;
                    case 2:
                        AdvanceExistingGame();
                        break;
                    case 3:
                        userComunicator.PrintWarningMessage(Repository.QuitGameMessage);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        /// <summary>
        /// Creates new game. Sets every time starting iteration = 1
        /// so that, when:
        /// 1.starting new game;
        /// 2.continuing game
        /// 3.starting new game.
        /// Iteration count would not continue to increase but also resets to 1
        /// Calls constructor to initialize an array with dimesion values
        /// and populator choice got from user input .
        /// </summary>
        public void ExecuteNewGame()
        {
            GameFieldData.iterationCount = 1;
            int rows = userComunicator.GetInputValueRanged(Repository.EnterRowsCountMessage, 5, 50);
            int colums = userComunicator.GetInputValueRanged(Repository.EnterCollumsCountMessage, 5, 50);
            int populatorChoice = userComunicator.GetInputValueRanged(Repository.ChoseCellPopulatorMessage, 1, 2);

            gameFieldData = new GameFieldData(rows, colums, populatorChoice);
     
            AdvanceExistingGame();
        }

        /// <summary>
        /// Renders GameFieldArray
        /// Based on key Press executes
        /// 1.Save; 2.Load 3.Quit comands. Quits to main menu.
        /// </summary>
        public void AdvanceExistingGame()
        {
            GameFieldData.iterationCount--;
            GameHandler gameHandler = new GameHandler();
            bool isGameOn = true;

            if (gameFieldData == null)
            {
                userComunicator.PrintErrorMessage(Repository.UnsuccessfulContinueMessage);
                Thread.Sleep(1000);
                return;
            }

            while (isGameOn)
            {
                bool isLoaded = false;
                GameFieldData.iterationCount++;
                renderer.PrintArray(gameFieldData.gameFieldArray);
                Thread.Sleep(1000);
                ConsoleKey key = userComunicator.KeyPressed();

                switch (key)
                {
                    case ConsoleKey.S:
                        gameHandler.SaveData(gameFieldData);
                        GameFieldData.iterationCount--;
                        break;
                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        isGameOn = false;
                        break;
                    case ConsoleKey.L:
                        SavedObjects savedData = gameHandler.LoadData();
                        if (savedData == null)
                        {
                            GameFieldData.iterationCount -= 1;
                            break;
                        }
                        GameFieldData.iterationCount = savedData.Iteration - 1;
                        gameFieldData = savedData.GameFieldData;
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
