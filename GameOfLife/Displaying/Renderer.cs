
namespace GameOfLife
{
    public class Renderer
    {
        /// <summary>
        /// Renders GameField array
        /// and related message to it every iteration
        /// </summary>
        /// <param name="gameField">current generation of game array array</param>
        public void PrintArray(int[,] gameField)
        {
            Console.SetCursorPosition(0, 0);
            UserComunicator.PrintHeaderMessage(String.Format(Repository.LiveCellCountMessage, GameStateChecker.AliveCellsInCurrentIteration(gameField)));
            UserComunicator.PrintHeaderMessage(Repository.IteratorMessageFirstPart + GameStateChecker.IterationCounter() + Repository.IteratorMessageSecondPart);

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] == 0 ? "." : "X");

                }
                Console.WriteLine("");
            }

            UserComunicator.PrintWarningMessage(Repository.ExitSaveMessage);
        }
    }
}
