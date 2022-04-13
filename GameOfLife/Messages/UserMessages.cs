using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class UserMessages
    {
        CellGenerationIterator cellGenerationIterator = new CellGenerationIterator();
        public string InputLenghtMessage()
        {
           string lenght = "Enter Lenght";
           return lenght;
        }
        public string InputWidthMessage()
        {
            string width = "Enter Width";
            return width;
        }

        public string ErrorMessage()
        {
            string errorMessage = "Invalid input, please try again!";
            return errorMessage;
        }
        public void IterationMessage()
        {
            Console.WriteLine("Iteration " + cellGenerationIterator.IterationCounter());
        }

        public void StartingMessage()
        {
            Console.WriteLine("Starting field");
        }
       
    }
}
