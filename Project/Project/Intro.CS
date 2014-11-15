using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Intro
    {
        public void OpeningCrawl()
        {
            //Creates the Header Graphic
            //Header starts at 0,0
            //Header ends at 7,97
            Console.SetWindowSize(97, 60);
            //Width 95, Height 60
            //59 is the max lines up/down 
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            Console.WriteLine(" ┌─────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine(" │   ___                                 _____  ____                  __                       │");
            Console.WriteLine(" │  / _ \\__ _____  ___ ____ ___  ___    / ___/_/ / /________ __    __/ /__ ____                │");
            Console.WriteLine(" │ / // / // / _ \\/ _ `/ -_) _ \\/ _ \\  / /__/_  . __/ __/ _ `/ |/|/ / / -_) __/                │");
            Console.WriteLine(" │/____/\\_,_/_//_/\\_, /\\__/\\___/_//_/  \\___/_    __/_/  \\_,_/|__,__/_/\\__/_/                   │");
            Console.WriteLine(" │               /___/                      /_/_/                                              │");
            Console.WriteLine(" └─────────────────────────────────────────────────────────────────────────────────────────────┘");

             //Creating Vertical Bar
            Console.SetCursorPosition(51, 6);
            Console.Write("┬");            
            for (int j = 1; j < 48; j++)
            {
                Console.SetCursorPosition(51, 6 + j);
                Console.WriteLine("│");
            }

            //Creating Horizontal Bar under the Map
            Console.SetCursorPosition(51, 40);
            Console.Write("┤");
            Console.SetCursorPosition(0, 40);
            for (int j = 0; j < 51; j++)
            {
                Console.Write("─");
            }
            //Creating input box
            Console.SetCursorPosition(0, 58);
            for (int j = 0; j < 51; j++)
            {
                Console.Write("─");                
            }
            Console.SetCursorPosition(0, 59);
            Console.Write("Input: ");

            

            







                #region Loading Bar
            //    //This is the Loading Bar
            //    Console.Write("Loading: ");
            //for (int i = 99; i < 101; i++)
            //{
                
            //    if (i < 10)
            //    {
            //        Console.Write("{0}", i);
            //        Console.Write("\b");
            //        System.Threading.Thread.Sleep(100);
            //    }
            //    else if (i < 100)
            //    {
            //        Console.Write("{0}", i);
            //        Console.Write("\b");
            //        Console.Write("\b");
            //        System.Threading.Thread.Sleep(100);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Complete");
            //        Console.WriteLine("Press Enter To begin your Journey");
            //        Console.ReadLine();
            //    }
            //};
            #endregion
        }
    }
}