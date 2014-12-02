using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main()
        {  
  
            
            
            
            //Render the Gui
            Program prog = new Program();
            Intro Start = new Intro();
            Start.ScreenRender();

            
            //Waiting to start game
            prog.WriteTextBox("Press Enter To Start");
            Console.ReadKey();
            
            //Starts the map
            Map map = new Map();

            bool dead = false;
            while(!dead)
            {
                map.movement();
            }

            //Win Circumstances
            //GameOver End = new GameOver();
            //if (Win == true)
            //{
            //    End.Victory();
            //    ConsoleKeyInfo Input = Console.ReadKey();
            //    switch (Input.Key)
            //    {
            //        case ConsoleKey.Y:
            //            Main();
            //            break;
            //        case ConsoleKey.N:
            //            Environment.Exit(0);
            //            break;
            //    }
            //}
            //else
            //{
            //    End.Died();
            //    ConsoleKeyInfo Input = Console.ReadKey();
            //    switch (Input.Key)
            //    {
            //        case ConsoleKey.Y:
            //            Main();
            //            break;
            //        case ConsoleKey.N:
            //            Environment.Exit(0);
            //            break;
            //    }
            //}      

        }
        public void ClearTextbox()
        {
            //Console.BackgroundColor = ConsoleColor.Blue; --Uncomment to Debug Textbox Size
            Console.SetCursorPosition(0, 41);
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine("                                                      ");
            }
            Console.SetCursorPosition(7, 59);
        }
        public void WriteTextBox(string value)
        {
            Console.SetCursorPosition(0, 41);
            int myLimit = 51;
            string sentence = value;
            string[] words = sentence.Split(' ');

            StringBuilder newSentence = new StringBuilder();


            string line = "";
            foreach (string word in words)
            {
                if ((line + word).Length > myLimit)
                {
                    newSentence.AppendLine(line);
                    line = "";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);

            Console.WriteLine(newSentence.ToString());
            Console.SetCursorPosition(7, 59);
        }
    }
}
