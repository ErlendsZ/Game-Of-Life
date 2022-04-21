using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class UserComunicator
    {
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
                    PrintErrorMessage(Repository.NotNumberMessage);
                    Console.WriteLine(Repository.PressKeyMessage);
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
                    PrintErrorMessage(Repository.OutOfRangeMessage);
                    Console.WriteLine(Repository.PressKeyMessage);
                    Console.ReadKey();
                }
            }
        }

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

        public static void PrintOrdinaryMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
