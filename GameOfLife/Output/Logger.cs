using System.Text;

namespace GameOfLife
{
    /// <summary>
    /// Writes output both in console and in logg file
    /// </summary>
    public static class Logger
    {
        public static StringBuilder loggerStringBuilder = new StringBuilder();

        /// <summary>
        /// Appends text in new line in loggerStringBuilder
        /// </summary>
        /// <param name="loggerString"> string that is currently being writen loggerStringBuilder</param>
        public static void WriteLine(string loggerString)
        {
            Console.WriteLine(loggerString);
            loggerStringBuilder.Append(loggerString).Append(Environment.NewLine);
        }

        public static void Write(string loggerString)
        {
            Console.Write(loggerString);
            loggerStringBuilder.Append(loggerString);
        }

        /// <summary>
        /// Appends user entered input lines into loggerStringBuilder
        /// </summary>
        /// <param name="loggerString"> string that is currently being writen int to loggerStringBuilder </param>
        public static void ReadLine(string loggerString)
        {
            loggerStringBuilder.Append(loggerString).Append(Environment.NewLine);
        }

        /// <summary>
        /// Saves loggerStringBuilder into existing text file or owerwrites it if file exists.
        /// </summary>
        /// <param name="Path">Relative path where output file is saved</param>
        public static void SaveLog(string Path = "./GameOfLifeOutput.txt")
        {
            if (loggerStringBuilder != null && loggerStringBuilder.Length > 0)
            {
                using (StreamWriter file = new StreamWriter(Path))
                {
                    file.Write(loggerStringBuilder.ToString());
                    file.Close();
                    file.Dispose();
                }

            }
        }
    }
}
