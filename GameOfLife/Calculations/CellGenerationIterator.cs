using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class CellGenerationIterator
    {
       private int iterationCounter = 0;
        public int IterationCounter()
        {
           
            iterationCounter++;

            return iterationCounter;
        }
    }
}
