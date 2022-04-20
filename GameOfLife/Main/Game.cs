using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {
        public void Run()
        {
            int choice = UserComunicator.GetInputValueRanged(UserMessages.DisplayMainMenu(), 1, 3);

            switch (choice)
            {
                case 1:
                    GameFieldData gameFieldData = new GameFieldData();
                    Renderer renderer = new Renderer();
                    while (true)
                    {
                        renderer.PrintArray(gameFieldData.gameFieldArray);
                        gameFieldData.GetNextGeneration();
                        Thread.Sleep(1000);
                    }
                    break;

                case 2:
                    Console.WriteLine("Not Implemented");
                    break;
                case 3:
                    Console.WriteLine("dogee");
                    break;
            }
        }
    }
}
