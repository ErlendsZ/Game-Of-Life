namespace GameOfLife
{
    public static class UserComunicator
    {
        /// <summary>
        /// Gets user entered value and check if it is an integer input,
        /// </summary>
        /// <param name="request">User presented text string from Repository</param>
        /// <returns>User entered input</returns>
        public static int GetInputValue(string request)
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
        public static int GetInputValueRanged(string request, int lowerLimit, int upperLimit)
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
        /// Visualy modifies text messages based on their use.
        /// </summary>
        /// <param name="message">Text message passed form repository</param>
        public static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintHeaderMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintWarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintOrdinaryMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static ConsoleKey KeyPressed()
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
