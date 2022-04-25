using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace GameOfLife
{
    // object to serialize in binary format
    [Serializable]
    public class SavedObjects 
    {
        public GameFieldData? gameFieldData;
        public int Iteration = GameStateChecker.iterationCount;
    }
   
}
