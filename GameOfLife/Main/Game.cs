using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Game
    {
        public void Run()
        {
            GameFieldData gameFieldData = new GameFieldData();
            Renderer renderer = new Renderer();
            while (true)
            {
                renderer.PrintArray(gameFieldData.gameFieldArray);
                gameFieldData.GetNextGeneration();
                Thread.Sleep(1000);
            }
        }
    }
}
