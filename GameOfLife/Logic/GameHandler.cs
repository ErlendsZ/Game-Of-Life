using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class GameHandler
    {
        //DataSerialization dataSerializer = new DataSerialization();
        //SavedObjects LoadState = null;
        public static void SaveData(GameFieldData gameFieldData)
        {

            //GameFieldData Field = gameFieldData;
            //SavedObjects person = new SavedObjects()
            ////{  Iteration = GameStateChecker.iterationCount, GameFieldData Field};
            //{ Iteration = GameStateChecker.iterationCount, Field = gameFieldData };

            ////dataSerializer.BinarySerialize(person, Repository.DataFileName);

        }

        public static GameFieldData LoadGame()
        {
            GameFieldData gameFieldData = new GameFieldData();

            ///// read from file object 
            //LoadState = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            //UserComunicator.PrintErrorMessage(Repository.IteratorMessage + LoadState.Iteration);
            //Console.WriteLine(LoadState.Field);
            return gameFieldData;
        }

    }
}
