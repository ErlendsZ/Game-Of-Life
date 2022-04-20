
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
            UserMessages userMessages = new UserMessages();
            userMessages.LiveCellsMessage(gameField);
            userMessages.IterationMessage();

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Logger.Write(gameField[i, j] == 0 ? "." : "X");

                }
                Logger.WriteLine("");
            }

        }
    }
}
