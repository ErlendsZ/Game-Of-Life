namespace GameOfLife
{
    internal class OutputManager
    {
        /// <summary>
        /// Based on user choice current output in a text file or not
        /// </summary>
        public bool SelectOutputType()
        {
            GameManager gameManager = new GameManager();
            UserMessages userMessages = new UserMessages();
            bool isTextOutput;
            userMessages.OutputChoiceMessage();
            bool success = Int32.TryParse(Console.ReadLine(), out int input);

            if (success && input == 1)
            {
                isTextOutput = true;
                return isTextOutput;
            }

            if (success && input == 0)
            {
                isTextOutput = false;
                return isTextOutput;
            }

            else
            {
                return SelectOutputType();
            }
        }
    }
}
