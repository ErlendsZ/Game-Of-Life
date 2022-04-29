namespace GameOfLife
{
    /// <summary>
    /// Handles game loading and saving.
    /// </summary>
    public class GameHandler
    {
        private readonly DataSerialization dataSerialization = new DataSerialization();

        /// <summary>
        /// Saves current gameData
        /// </summary>
        /// <param name="gameFieldData">Game field data in current iteration</param>
        public void SaveData(GameFieldData gameFieldData)
        {
            SavedObjects savedObjects = new SavedObjects()
            { Iteration = GameFieldData.iterationCount, GameFieldData = gameFieldData };

            dataSerialization.BinarySerialize(savedObjects, Repository.DataFileName);
            UserComunicator.PrintWarningMessage(Repository.SavedIterationMessage, savedObjects.Iteration);
        }

        /// <summary>
        /// Loads serilized data
        /// </summary>
        /// <returns>SavedObjects which contains GameField (array of cells) and current iteration number</returns>
        public SavedObjects LoadData()
        {
            SavedObjects savedObjects = dataSerialization.BinaryDeserialize<SavedObjects>(Repository.DataFileName);
            if (savedObjects == null)
                UserComunicator.PrintErrorMessage(Repository.UnsuccessfulDeserializationMessage);
            else
                UserComunicator.PrintWarningMessage(Repository.LoadedIterationMessage, savedObjects.Iteration);
            return savedObjects;
        }
    }
}
