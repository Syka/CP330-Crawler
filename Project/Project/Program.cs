using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DungeonCrawler
{
    class Program
    {
        static void Main()
        {
            ///Render the GUI
            Program prog = new Program();
            Intro Start = new Intro();
            Start.ScreenRender();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sound/Music.wav");
            player.Play();

            ///Waiting to start game
            prog.WriteTextBox("Press Enter To Start");
            Console.ReadKey();

            ///Starts the map
            Map map = new Map();
            
            bool dead = false;
            while(!dead)
            {
                map.movement();
            }
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
            ClearTextbox();
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
        public void MonsterHealthBox(string value)
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
                    line = "";
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
                    line = "";
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
            Console.SetCursorPosition(59, 11);
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
