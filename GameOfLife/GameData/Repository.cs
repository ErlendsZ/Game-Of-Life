﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Repository
    {
        public const string PressKeyMessage = "Press any key to continue.";
        public const string NotNumberMessage = "Input must be a number!";
        public const string OutOfRangeMessage = "Selected number is too high or low!";
        public const string MainMenuMessage = "1.Start New Game. \n2.Load Game. \n3.Quit Game";
        public const string IteratorMessage = "Iteration: ";
        public const string LiveCellCountMessageFirstPart = "There are currently: " ;
        public const string LiveCellCountMessageSecondPart = " Live Cells ";
        public const string QuitGameMessage = " You quit the game :( ";
        public const string DataFileName = "GameOfLife.data";
    }
}
