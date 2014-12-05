using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Resources;

///The standard class from when the character has died in the game and must start over.
namespace DungeonCrawler
{
    class GameOver
    {
        public void Died()
        {
            Program prog = new Program();
            prog.ClearTextbox();
            ClearMapBox();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(7, 20);
            
            Console.WriteLine("  _____                 ____      ");
            Console.SetCursorPosition(7, 21);
            Console.WriteLine(" / ___/__ ___ _  ___   / __ \\_  _____ ____");
            Console.SetCursorPosition(7, 22);
            Console.WriteLine("/ (_ / _ `/  ' \\/ -_) / /_/ / |/ / -_) __/");
            Console.SetCursorPosition(7, 23);
            Console.WriteLine("\\___/\\_,_/_/_/_/\\__/  \\____/|___/\\__/_/  ");
            Console.SetCursorPosition(7, 24);
            Console.Write(Environment.NewLine+"                 Better luck next time!");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sound/Death.wav");
            player.Play();
            Console.ReadLine();
            Environment.Exit(1);
        }
        public void Victory()
        {
            Program prog = new Program();
            prog.ClearTextbox();
            ClearMapBox();
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("            _        _                       ");
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("   /\\   /\\ (_)  ___ | |_   ___   _ __  _   _ ");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("   \\ \\ / / | | / __|| __| / _ \\ | '__|| | | |");
            Console.SetCursorPosition(3, 23);
            Console.WriteLine("    \\ V /  | || (__ | |_ | (_) || |   | |_| |");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("     \\_/   |_| \\___| \\__| \\___/ |_|    \\__, |");
            Console.SetCursorPosition(3, 25);
            Console.WriteLine("                                       |___/ ");
            Console.SetCursorPosition(3, 26);

            Console.Write(Environment.NewLine + "             YOU ARE WINNER! CONGRATULATIONS!");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"../../Sound/VictoryFanfare.wav");
            player.Play();
            Console.ReadLine();
            Environment.Exit(1);
        }
        public void ClearMapBox()
        {
            //Console.BackgroundColor = ConsoleColor.Blue; //Uncomment to Debug Textbox Size
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < 33; i++)
            {
                Console.WriteLine("                                                       ");
            }
            Console.SetCursorPosition(0, 7);
        }
    }    
}
