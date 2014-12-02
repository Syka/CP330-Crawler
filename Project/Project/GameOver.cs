using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The standard class from when the character has died in the game and must start over.
namespace Project
{
    class GameOver
    {
        public void Died()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 25);
            
            Console.WriteLine("                                _____                 ____      ");
            Console.WriteLine("                               / ___/__ ___ _  ___   / __ \\_  _____ ____");
            Console.WriteLine("                              / (_ / _ `/  ' \\/ -_) / /_/ / |/ / -_) __/");
            Console.WriteLine("                              \\___/\\_,_/_/_/_/\\__/  \\____/|___/\\__/_/  ");
            Console.Write(Environment.NewLine+"                                   Would You Like to Continue?(Y/N)");      
        }
        public void Victory()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 25);

            Console.WriteLine("                                        _        _                       ");
            Console.WriteLine("                               /\\   /\\ (_)  ___ | |_   ___   _ __  _   _ ");
            Console.WriteLine("                               \\ \\ / / | | / __|| __| / _ \\ | '__|| | | |");
            Console.WriteLine("                                \\ V /  | || (__ | |_ | (_) || |   | |_| |");
            Console.WriteLine("                                 \\_/   |_| \\___| \\__| \\___/ |_|    \\__, |");
            Console.WriteLine("                                                                   |___/ ");

            Console.Write(Environment.NewLine + "                                   Would You Like to Continue?(Y/N)");   
        }
    }



    
}
