using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(10);
            while (!map.dead)
            {
                Console.Clear();
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
        }
    }
}
