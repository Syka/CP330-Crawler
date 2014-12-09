using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DungeonCrawler
{
    /// <summary>
    /// This is a Dungeon Crawler Game, Created by Evan, Dave, Jordan, and Nolan
    /// </summary>
    class Program
    {
        static void Main()
        {
            ///Render the GUI
            Program prog = new Program();
            Intro Start = new Intro();
            Start.ScreenRender();
            #region Map Creation
            ///Starts the map
            Map map = new Map();
            
            bool dead = false;
            while(!dead)
            {
                map.movement();
            }
            #endregion
        }
        public void ClearTextbox()
        {
            ///Console.BackgroundColor = ConsoleColor.Blue; --Uncomment to Debug Textbox Size
            Console.SetCursorPosition(0, 41);
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine("                                                      ");
            }
            Console.SetCursorPosition(7, 59);
        }
        public void WriteTextBox(string value)
        {
            StringBuilder newSentence = new StringBuilder();
            ClearTextbox(); ///Clears the area
            Console.SetCursorPosition(0, 41);///Sets the Cursor to the Top of the TextBox
            int MaxLength = 47; ///Horizontal Width of the Textbox
            string sentence = value;
            string[] words = sentence.Split(' ');
            string line = "";

            foreach (string word in words)
            {
                //if ((line + word).Length > myLimit)
                //{
                //    newSentence.AppendLine(line);
                //    line = " ";
                //}               
                if(Console.CursorLeft >= MaxLength)
                {
                    Console.WriteLine();
                    Console.Write(" ");
                }
                foreach(char c in word)
                {
                    System.Threading.Thread.Sleep(25);
                    line += c;                    
                    Console.Write(c);
                }
                //line += string.Format(" ");
                //line += string.Format("{0} ", word);
                Console.Write(" ");
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);
            //Console.WriteLine(newSentence.ToString());
            Console.SetCursorPosition(7, 59);
        }
        public void MonsterHealthBox(string value)
        {
            Console.SetCursorPosition(59, 13);
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
                    line = " ";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);
            Console.WriteLine(newSentence.ToString());
            Console.SetCursorPosition(7, 59);
        }
        public void MonsterWeaponBox(string value)
        {
            Console.SetCursorPosition(59, 14);
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
                    line = " ";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);
            Console.WriteLine(newSentence.ToString());
            Console.SetCursorPosition(7, 59);
        }
        public void MonsterNameBox(string value)
        {
            Console.SetCursorPosition(59, 12);
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
                    line = " ";
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
