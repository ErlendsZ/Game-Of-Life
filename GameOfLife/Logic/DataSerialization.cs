using System.Runtime.Serialization.Formatters.Binary;

namespace GameOfLife
{
    /// <summary>
    ///  Wraper to encapsulate serialization code
    /// </summary>
    public class DataSerialization
    {
        /// <summary>
        /// Serializes file into file path
        /// </summary>
        /// <param name="savedData">objects to serialize</param>
        /// <param name="filePath">relative location of seriliazation file</param>
        public T? BinarySerialize<T>(T savedData, string filePath)
        {

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();

            using (fileStream = File.Create(filePath))
            {
                formatter.Serialize(fileStream, savedData);
            }
            return savedData;
        }

        /// <summary>
        /// Deserializes content
        /// </summary>
        /// <param name="filePath"> Location of saved binary file</param>
        /// <param name="savedData">Saved data to deserialize</param>
        /// <returns>Deserialized object</returns>
        public T? BinaryDeserialize<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileStream fileStream;
                BinaryFormatter formatter = new BinaryFormatter();

                using (fileStream = File.OpenRead(filePath))
                {
                    var savedData = (T)formatter.Deserialize(fileStream);
                    return savedData;
                }
            }

            return default;
        }
    }
}
