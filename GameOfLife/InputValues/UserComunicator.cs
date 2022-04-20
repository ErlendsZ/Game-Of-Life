using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class UserComunicator
    {
        private const string PressKeyMessage = "Press any key to continue.";
        public static int GetInputValue(string request)
        {
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
                    IncorrectInputMessage();
                    Console.WriteLine(PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }
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
                    NumberTooHighOrLow();
                    Console.WriteLine(PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }
        public static void IncorrectInputMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input must be a number!");
            Console.ResetColor();
        }

        public static void NumberTooHighOrLow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Selected number is too high or low!");
            Console.ResetColor();
        }
    }
}
