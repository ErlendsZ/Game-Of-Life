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
            Console.Clear();
            int choice = UserComunicator.GetInputValueRanged(UserMessages.DisplayMainMenu(), 1, 3);

            switch (choice)
            {
                case 1:
                    GameFieldData gameFieldData = new GameFieldData();
                    Renderer renderer = new Renderer();
                    while (!Console.KeyAvailable)
                    {
                        renderer.PrintArray(gameFieldData.gameFieldArray);
                        gameFieldData.GetNextGeneration();
                        Console.WriteLine("Press any key to exit");
                        Thread.Sleep(1000);
                    }
                    Run();
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
