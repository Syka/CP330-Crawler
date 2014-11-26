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
            //Map Initialzer

            //Character Initializer


            //Render the Gui
            Intro Start = new Intro();
            Start.ScreenRender();
            

            WriteTextBox("Press Enter To Start");
            Console.ReadKey();

            
            WriteTextBox(" We follow our faithful Mute Protangnist as he enters the treachous Dungeon" + Environment.NewLine+" Press Any Key" );
            ClearTextbox();
            WriteTextBox("What Race are you?" + Environment.NewLine + "Elf, Human or Orc?");
            Console.ReadLine();

            //Console.WriteLine("What Race are you young Adventurer?");
            Map map = new Map(6, 19);

            bool dead = false;
            while(!dead)
            {
                map.movement();
            }
            //GameOver End = new GameOver();
            //End.Died();
            //ConsoleKeyInfo Input = Console.ReadKey();
            //switch (Input.Key)
            //{
            //    case ConsoleKey.Y:
            //        Main();
            //        break;
            //    case ConsoleKey.N:
            //        Environment.Exit(0);
            //        break;
            //}           



            //Need a loop here

            //Show map


            //Movement

            //Events

            //Characters

            //Enemies

            //Loot

            //Inventory

            //Weapons
            

            //Map

        }
        static void ClearTextbox()
        {
            //Console.BackgroundColor = ConsoleColor.Blue; --Uncomment to Debug Textbox Size
            Console.SetCursorPosition(0, 41);
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine("                                                      ");
            }
        }
        static void WriteTextBox(string value)
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
