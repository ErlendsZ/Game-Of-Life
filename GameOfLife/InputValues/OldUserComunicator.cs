using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class OldUserComunicator
    {
        private const string PressKeyMessage = "Press any key to continue.";
        public int GetInputValue(string request)
        {
            UserMessages userMessages = new UserMessages();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(request);
                bool success = Int32.TryParse(Console.ReadLine(), out int input);
                if (success)
                {
                    return input;
                }
                else
                {
                    userMessages.IncorrectInputMessage();
                    Console.WriteLine(PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }
        public int GetInputValueRanged(string request, int lowerLimit, int upperLimit)
        {
            UserMessages userMessages = new UserMessages();
            while (true)
            {
                int number = GetInputValue(request);
                if (number >= lowerLimit && number <= upperLimit)
                {
                    return number;
                }
                else
                {
                    userMessages.NumberTooHighOrLow();
                    Console.WriteLine(PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }

        //public bool GetOutputValueChoice()
        //{
        //    UserMessages userMessages = new UserMessages();
        //    GameMenu gameMenuSelection = new GameMenu();

        //    bool isTextOutput;
        //    userMessages.OutputChoiceMessage();
        //    bool success = Int32.TryParse(Console.ReadLine(), out int input);

        //    if (success && input == 1)
        //    {
        //        isTextOutput = true;
        //        return isTextOutput;
        //    }

        //    if (success && input == 0)
        //    {
        //        isTextOutput = false;
        //        return isTextOutput;
        //    }

        //    else
        //    {
        //        return GetOutputValueChoice();
        //    }
        //}

        //public int GetInputToExitOngoingGame()
        //{
        //    UserMessages userMessages = new UserMessages();
        //    userMessages.ExitOngoingGame();
        //    bool success = Int32.TryParse(Console.ReadLine(), out int input);

        //    if (success)
        //    {
        //        return input;
        //    }

        //    else
        //    {
        //        userMessages.IncorrectInputMessage();
        //        return GetInputValue();
        //    }
        //}
    }
}
