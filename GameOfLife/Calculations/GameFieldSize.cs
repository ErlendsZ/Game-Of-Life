namespace GameOfLife
{


    public class GameFieldSize
    {
        public string messageWidth = "Enter Width";
        public string messageLenght = "Enter Lenght";
        public string invalidInput = "Invalid input, please try again!";

        /// <summary>
        ///  Set ups field in 2D array
        /// </summary>
        /// <param name="userMessage"></param>
        /// <param name="invalidInpuptMessage"></param>
        /// <returns></returns>
        /// 
        public int SetFielDimensions(string userMessage, string invalidInpuptMessage)
        {

            Console.WriteLine(userMessage);
            string userInputDimension = Console.ReadLine();

            bool success = Int32.TryParse(userInputDimension, out int dimension);

            if (success && dimension > 1 && dimension < 1001)
            {
                return dimension;
            }
            else
            {
                Console.WriteLine(invalidInpuptMessage);
                return SetFielDimensions(userMessage, invalidInpuptMessage);

            }
        }

    }
}

