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
        public int Iteration = GameStateChecker.iterationCount;
        public GameFieldData Field;
    }
    public class GameHandler
    {
        DataSerialization dataSerializer = new DataSerialization();
        SavedObjects LoadState = null;
        public void SaveData(GameFieldData gameFieldData)
        {
            
            GameFieldData Field = gameFieldData;
            SavedObjects person = new SavedObjects()
            //{  Iteration = GameStateChecker.iterationCount, GameFieldData Field};
            { Iteration = GameStateChecker.iterationCount,  Field = gameFieldData };

            dataSerializer.BinarySerialize(person, Repository.DataFileName);

            //calls deserilized object
           UserComunicator.PrintErrorMessage(Repository.IteratorMessage + LoadState.Iteration);
           Console.WriteLine(LoadState.Field);
            
        }

        public void LoadGame()
        {
            LoadState = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
        }

    }
}
