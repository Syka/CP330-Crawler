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

            Console.SetCursorPosition(10, Console.CursorTop - 1);
            ClearLine();

            Console.WriteLine("We follow our faithful Mute Protangnist as he enters the treachous Dungeon");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Press Any Enter to Continue...");
            Console.ReadLine();
            ClearLine();
            Console.WriteLine("You Enter the dark Dungeon");
            Console.ReadLine();
            ClearLine();

            Map map = new Map(10);
            while (!map.dead)
            {
                map.movement();
            }
            Console.Clear();
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
            



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
                Console.Write(new string(' ', Console.WindowWidth));
               
            }
            Console.SetCursorPosition(0,0);
            Console.SetCursorPosition(0, 11);
        }

    }
}
