using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class GameHandler
    {
        public static int SaveData(GameFieldData gameFieldData)
        {
            DataSerialization dataSerializer = new DataSerialization();
            GameFieldData Field = gameFieldData;
            SavedObjects savedObjects = new SavedObjects()
            { Iteration = GameStateChecker.iterationCount, gameFieldData = Field };

            dataSerializer.BinarySerialize(savedObjects, Repository.DataFileName);
            UserComunicator.PrintWarningMessage(Repository.SavedIterationMessage + savedObjects.Iteration);

            return savedObjects.Iteration;
        }

        public static GameFieldData LoadGame()
        {
            DataSerialization dataSerializer = new DataSerialization();
            SavedObjects savedObjects = null;
            savedObjects = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            UserComunicator.PrintWarningMessage(Repository.LoadedIterationMessage + savedObjects.Iteration);

            return savedObjects.gameFieldData;
        }
    }
}
