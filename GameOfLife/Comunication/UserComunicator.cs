namespace GameOfLife
{
    /// <summary>
    /// Manages comunication with user onput values
    /// </summary>
    public class UserComunicator
    {
        /// <summary>
        /// Gets user entered value and check if it is an integer input,
        /// </summary>
        /// <param name="request">User presented text string from Repository</param>
        /// <returns>User entered input</returns>
        public int GetInputValue(string request)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(request);
                if (Int32.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }
                else
                {
                    PrintErrorMessage(Repository.NotNumberMessage);
                    Console.WriteLine(Repository.PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Checks if number input is within the defined bounds
        /// </summary>
        /// <param name="request">User presented text string from Repository</param>
        /// <param name="lowerLimit">Defined minimum value for number to be valid</param>
        /// <param name="upperLimit">Defined maximum,value for number input</param>
        /// <returns>User entered input if in defined bounds</returns>
        public int GetInputValueRanged(string request, int lowerLimit, int upperLimit)
        {
            while (true)
            {
                int number = GetInputValue(request);
                if (number >= lowerLimit && number <= upperLimit)
                {
                    Console.Clear();
                    return number;
                }
                else
                {
                    PrintErrorMessage(Repository.OutOfRangeMessage);
                    Console.WriteLine(Repository.PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Visualy modifies text message
        /// </summary>
        /// <param name="message">Text message passed form repository</param>
        public void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Visualy modifies text message
        /// </summary>
        /// <param name="message">Text message passed form repository</param>
        public void PrintHeaderMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Visualy modifies text message
        /// </summary>
        /// <param name="message">Text message passed form repository</param>
        /// <param name="number">Values used by String.Format; (Iteration and LiveCell count)</param>
        public void PrintWarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// While game is being rendered, checks for any key preses
        /// from user
        /// </summary>
        /// <returns>Presed key or CLEAR key if no input is given</returns>
        public ConsoleKey KeyPressed()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = System.Console.ReadKey(true);
                return keyInfo.Key;
            }
            return ConsoleKey.Clear;

        }
    }
}
