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


            //Intro
            Intro Start = new Intro();
            Start.OpeningCrawl();
            GameOver End = new GameOver();            

            WriteTextBox("We follow our faithful Mute Protangnist as he enters the treachous Dungeon" + Environment.NewLine+"Press Any Enter to Continue..." );            
            WriteTextBox("");
            Console.ReadLine();
            //ClearLine(); "Press Any Enter to Continue...
            //Console.WriteLine("What Race are you young Adventurer?");           

            ClearLine();            
            Console.ReadLine();
            ClearLine();

            //Map map = new Map(10);
            //while (!map.dead)
            //{
            //    map.movement();
            //}            
            End.Died();
            ConsoleKeyInfo Input = Console.ReadKey();
            switch (Input.Key)
            {
                case ConsoleKey.Y:
                    Main();
                    break;
                case ConsoleKey.N:
                    Environment.Exit(0);
                    break;
            }
            



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
        static void ClearLine()
        {
            Console.SetCursorPosition(0, 11);
            for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine("{0}", i);
                Console.Write(new string(' ', Console.WindowWidth-30));
               
            }
            Console.SetCursorPosition(0,0);
            Console.SetCursorPosition(0, 11);
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