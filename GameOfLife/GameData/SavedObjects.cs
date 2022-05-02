
namespace GameOfLife
{
    /// <summary>
    /// Objects to serialize in binary format.
    /// </summary>
    [Serializable]
    public class SavedObjects
    {
        public GameFieldData? GameFieldData;
        public int Iteration = GameFieldData.iterationCount;
    }

}
