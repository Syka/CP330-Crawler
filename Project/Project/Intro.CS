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
            Console.SetWindowSize(150, 60);
            Console.WriteLine(" _____                                         _____  _  _                        _           ||");
            Console.WriteLine("|  __ \\                                       / ____|| || |_                     | |          ||");
            Console.WriteLine("| |  | |_   _ _ __   __ _  ___  ___  _ __    | |   |_  __  _|  _ __ __ ___      _| | ___ _ __ ||");
            Console.WriteLine("| |  | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\   | |    _| || |_  | '__/ _` \\ \\ /\\ / / |/ _ \\ '__|||");
            Console.WriteLine("| |__| | |_| | | | | (_| |  __/ (_) | | | |  | |___|_  __  _| | | | (_| |\\ V  V /| |  __/ |   ||");
            Console.WriteLine("|_____/ \\__,_|_| |_|\\__, |\\___|\\___/|_| |_|   \\_____||_||_|   |_|  \\__,_| \\_/\\_/ |_|\\___|_|   ||");
            Console.WriteLine("                     __/ |                                                                    ||");
            Console.WriteLine("                     |___/                                                                    ||");

            Console.WriteLine("================================================================================================");

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            //This is the Loading Bar
            Console.Write("Loading: ");
            for (int i = 99; i < 101; i++)
            {
                
                if (i < 10)
                {
                    Console.Write("{0}", i);
                    Console.Write("\b");
                    System.Threading.Thread.Sleep(100);
                }
                else if (i < 100)
                {
                    Console.Write("{0}", i);
                    Console.Write("\b");
                    Console.Write("\b");
                    System.Threading.Thread.Sleep(100);
                }
                else
                {
                    Console.WriteLine("Complete");
                    Console.WriteLine("Press Enter To begin your Journey");
                    Console.ReadLine();
                }
            };
        }
    }
}