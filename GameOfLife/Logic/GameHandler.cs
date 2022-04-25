using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class GameHandler
    {
        //DataSerialization dataSerializer = new DataSerialization();
        //SavedObjects LoadState = null;
        public static void SaveData(GameFieldData gameFieldData)
        {
            DataSerialization dataSerializer = new DataSerialization();
            GameFieldData Field = gameFieldData;

            SavedObjects savedObjects = new SavedObjects()
            { Iteration = GameStateChecker.iterationCount, gameField = GameFieldData.gameFieldArray };
            //{  Iteration = GameStateChecker.iterationCount, GameFieldData Field};
            //{ Iteration = GameStateChecker.iterationCount, Field = gameFieldData };

            dataSerializer.BinarySerialize(savedObjects, Repository.DataFileName);

        }

        public static int [,] LoadGame()
        {
            //GameFieldData gameFieldData = new GameFieldData;

            ///// read from file object 
            DataSerialization dataSerializer = new DataSerialization();
            SavedObjects LoadState = null;
            LoadState = dataSerializer.BinaryDeserialize(Repository.DataFileName) as SavedObjects;
            UserComunicator.PrintErrorMessage(Repository.IteratorMessage + LoadState.Iteration );

            for (int i = 0; i < LoadState.gameField.GetLength(0); i++)
            {
                for (int j = 0; j < LoadState.gameField.GetLength(1); j++)
                {
                    Console.Write(LoadState.gameField[i, j] == 0 ? "." : "X");

                }
                Console.WriteLine("");
            }

            return LoadState.gameField;
        }

    }
}
