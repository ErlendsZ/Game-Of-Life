
namespace GameOfLife
{
    public class Renderer
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="gameField"></param>
        public void PrintArray(int[,] gameField)
        {
            Console.SetCursorPosition(0, 0);
            UserComunicator.PrintHeaderMessage(Repository.LiveCellCountMessageFirstPart + GameStateChecker.AliveCellsInCurrentIteration(gameField) + Repository.LiveCellCountMessageSecondPart);
            UserComunicator.PrintHeaderMessage(Repository.IteratorMessage + GameStateChecker.IterationCounter());

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j] == 0 ? "." : "X");

                }
                Console.WriteLine("");
            }
        }
    }
}
