
namespace GameOfLife
{
    /// <summary>
    /// Renders Iteration messages, Live cell count GameArray, quitGane message
    /// </summary>
    public class Renderer
    {
        /// <summary>
        /// Renders GameField array
        /// and related messages to it every iteration. (LiveCell count, iteration count, quit game)
        /// </summary>
        /// <param name="gameField">current generation of game array array</param>
        public void PrintArray(int[,] gameField)
        {
            Console.SetCursorPosition(0, 0);
            UserComunicator.PrintHeaderMessage(String.Format(Repository.LiveCellCountMessage, GameFieldData.AliveCellsInCurrentIteration(gameField)));
            UserComunicator.PrintHeaderMessage(String.Format(Repository.IteratorMessage, GameFieldData.IterationCounter()));

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] == 0 ? "." : "X");

                }
                Console.WriteLine("");
            }

            UserComunicator.PrintWarningMessage(Repository.ExitSaveMessage, 0);
        }
    }
}
