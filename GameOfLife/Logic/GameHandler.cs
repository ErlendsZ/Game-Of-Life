using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameHandler
    {
        private readonly DataSerialization dataSerialization = new DataSerialization();
        public void SaveData(GameFieldData gameFieldData)
        {
            SavedObjects savedObjects = new SavedObjects()
            { Iteration = GameStateChecker.iterationCount, GameFieldData = gameFieldData };

            dataSerialization.BinarySerialize(savedObjects, Repository.DataFileName);
            UserComunicator.PrintWarningMessage(Repository.SavedIterationMessageFirstPart + savedObjects.Iteration + Repository.LoadedSavedMessageSecondPart);
        }

        /// <summary>
        /// Loads serilized data
        /// </summary>
        /// <returns>SavedObjects which contains GameField (array of cells) data to be passed
        /// for next iterations and current iteration number</returns>
        public object LoadData()
        {
            SavedObjects savedObjects = dataSerialization.BinaryDeserialize(Repository.DataFileName, dataSerialization) as SavedObjects;
            UserComunicator.PrintWarningMessage(Repository.LoadedIterationMessageFirstPart + savedObjects?.Iteration + Repository.LoadedSavedMessageSecondPart);
            
            return savedObjects;
        }
    }
}
