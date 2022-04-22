namespace GameOfLife
{
    // object to serialize in binary format
    [Serializable]
    public class SavedObjects
    {
        public int Iteration = GameStateChecker.iterationCount;
        public GameFieldData Field;
    }
}
