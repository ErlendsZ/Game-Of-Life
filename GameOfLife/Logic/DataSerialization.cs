using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        /// <param name="savedData">objects to serialize</param>
        /// <param name="filePath">relative location of seriliazation file</param>
        public object BinarySerialize(object savedData, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
                File.Delete(filePath);
            fileStream = File.Create(filePath);
            formatter.Serialize(fileStream, savedData);
            fileStream.Close();
            return savedData;
        }

        /// <summary>
        /// Deserializes content
        /// </summary>
        /// <param name="filePath"> Location of saved binary file</param>
        /// <param name="savedData">Saved data to deserialize</param>
        /// <returns>Deserialized object</returns>
        public object BinaryDeserialize(string filePath, object savedData)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
          
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                savedData = formatter.Deserialize(fileStream);
                fileStream.Close();
                return savedData;
            }

            return null;
        }
    }
}
