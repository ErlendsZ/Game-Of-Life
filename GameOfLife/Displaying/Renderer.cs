
namespace GameOfLife
{
    /// <summary>
    /// Renders Iteration messages, Live cell count GameArray, quitGane message
    /// </summary>
    public class Renderer
    {
        /// <summary>
        /// Renders GameField array
        /// and related messages to it every iteration. (LiveCell count, iteration count, quit game messages)
        /// </summary>
        /// <param name="gameField">current generation of game array array</param>
        public void PrintArray(int[,] gameField)
        {
            UserComunicator userComunicator = new UserComunicator();
            Console.SetCursorPosition(0, 0);
            userComunicator.PrintHeaderMessage(String.Format(Repository.LiveCellCountMessage, GameFieldData.AliveCellsInCurrentIteration(gameField)));
            userComunicator.PrintHeaderMessage(String.Format(Repository.IteratorMessage, GameFieldData.IterationCounter()));

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] == 0 ? "." : "X");

                }
                Console.WriteLine("");
            }

            userComunicator.PrintWarningMessage(Repository.ExitSaveMessage);
        }
    }
}
