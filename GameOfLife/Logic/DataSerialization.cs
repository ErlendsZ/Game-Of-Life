using System.Runtime.Serialization.Formatters.Binary;

namespace GameOfLife
{
    /// <summary>
    ///  Wraper to encapsulate serialization code
    /// </summary>
    class DataSerialization
    {
        /// <summary>
        /// Serializes file into file path
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
                File.Delete(filePath);
            fileStream = File.Create(filePath);
            formatter.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeserialize(string filePath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = formatter.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }

    }
}
