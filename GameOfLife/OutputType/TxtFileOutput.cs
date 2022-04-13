using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Output
    {
        public void TxtFileOutput()
        {
         
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            GameManager gameManager = new GameManager();
            try
            {
                ostrm = new FileStream("./GameOfLifeOutput.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Cannot open GameOfLifeOutput.txt for writing");
                //Console.WriteLine(e.Message);
                //return;
            }
            Console.SetOut(writer);
            gameManager.CreateNewGame();
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done writing file");
            Environment.Exit(0);
        }
    }
}
