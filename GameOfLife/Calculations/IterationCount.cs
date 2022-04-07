using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class InterationCount
    {
        public int SelectIterationCount()
        {
            Console.WriteLine("Enter Width");
            int iterationCount = Convert.ToInt32(Console.ReadLine());
            return iterationCount;

        }
    }

}
