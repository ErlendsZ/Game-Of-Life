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
