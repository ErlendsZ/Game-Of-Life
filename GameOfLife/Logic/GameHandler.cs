using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class GameHandler
    {
        public static void SaveData(GameFieldData gameFieldData)
        {
            DataSerialization dataSerializer = new DataSerialization();
            GameFieldData Field = gameFieldData;
            SavedObjects savedObjects = new SavedObjects()
            { Iteration = GameStateChecker.iterationCount, gameFieldData = Field };

            dataSerializer.BinarySerialize(savedObjects, Repository.DataFileName);
            UserComunicator.PrintWarningMessage(Repository.SavedIterationMessageFirstPart + savedObjects.Iteration + Repository.LoadedSavedMessageSecondPart);
        }

        public static GameFieldData LoadGame()
        {
            DataSerialization dataSerializer = new DataSerialization();
            SavedObjects? savedObjects = null;
            savedObjects = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            UserComunicator.PrintWarningMessage(Repository.LoadedIterationMessageFirstPart + savedObjects?.Iteration + Repository.LoadedSavedMessageSecondPart);
            
            return savedObjects.gameFieldData;
        }

        public static int LoadIteration()
        {
            DataSerialization dataSerializer = new DataSerialization();
            SavedObjects? savedObjects = null;
            savedObjects = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            return savedObjects.Iteration;
        }
    }
}
