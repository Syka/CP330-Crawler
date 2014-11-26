using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
