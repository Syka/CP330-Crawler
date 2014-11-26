using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Intro
    {
        public void ScreenRender()
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
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" ┌─────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine(" │   ___                                 _____  ____                  __                       │");
            Console.WriteLine(" │  / _ \\__ _____  ___ ____ ___  ___    / ___/_/ / /________ __    __/ /__ ____                │");
            Console.WriteLine(" │ / // / // / _ \\/ _ `/ -_) _ \\/ _ \\  / /__/_  . __/ __/ _ `/ |/|/ / / -_) __/                │");
            Console.WriteLine(" │/____/\\_,_/_//_/\\_, /\\__/\\___/_//_/  \\___/_    __/_/  \\_,_/|__,__/_/\\__/_/                   │");
            Console.WriteLine(" │               /___/                      /_/_/                                              │");
            Console.WriteLine(" └─────────────────────────────────────────────────────────────────────────────────────────────┘");

             //Creating Vertical Bar
            Console.SetCursorPosition(54, 6);
            Console.Write("┬");            
            for (int j = 1; j < 54; j++)
            {
                Console.SetCursorPosition(54, 6 + j);
                Console.WriteLine("│");
            }

            //Creating Horizontal Bar under the Map
            Console.SetCursorPosition(54, 40);
            Console.Write("┤");
            Console.SetCursorPosition(0, 40);
            for (int j = 0; j < 54; j++)
            {
                Console.Write("─");
            }
            //Creating input box
            Console.SetCursorPosition(54, 58);
            Console.Write("┤");
            Console.SetCursorPosition(0, 58);
            for (int j = 0; j < 54; j++)
            {
                Console.Write("─");                
            }
            Console.SetCursorPosition(0, 59);
            Console.Write("Input: ");  
      
            
        }
    }
}