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
            UserComunicator.PrintWarningMessage(Repository.SavedIterationMessageFirstPart + savedObjects.Iteration + Repository.LoadedSavedMessageSecondPart);

            return savedObjects.Iteration;
        }

        public static GameFieldData LoadGame()
        {
            DataSerialization dataSerializer = new DataSerialization();
            SavedObjects savedObjects = null;
            savedObjects = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            UserComunicator.PrintWarningMessage(Repository.LoadedIterationMessageFirstPart + savedObjects.Iteration + Repository.LoadedSavedMessageSecondPart);

            return savedObjects.gameFieldData;
        }
    }
}
