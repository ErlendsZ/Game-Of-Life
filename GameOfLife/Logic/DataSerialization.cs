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
        /// <param name="data">objects to serialize</param>
        /// <param name="filePath">relative location of seriliazation file</param>
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

        /// <summary>
        /// Deserializes content
        /// </summary>
        /// <param name="filePath"> Location of saved binary file</param>
        /// <returns></returns>
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
