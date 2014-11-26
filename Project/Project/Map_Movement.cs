using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameWorldGen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = false;
            Map map = new Map(15);
            while (!test)
            {
                map.movement();
            }
            Console.ReadLine();
        }
    }
    public class Map
    {
        static int pRow = 0, pCol = 0, _pRow, _pCol, size = 0;
        static string[,] mask, events;
        static string player = " {X} ", unexplored = " [ ] ", explored = "  .  ",
                        enemy = " {E} ", onEnemy = "{ E }", enemyDef = "-{E}-",
                        boss = " {B} ", onBoss = "{ B }", bossDef = "-{B}-",
                        trapdoor = " {T} ", onTrap = "{ T }", trapDef = "-{T}-",
                        chest = " {C} ", onChest = "{ C }", chestOpen = "-{C}-";
        static string message = "";

        public Map(int s)
        {
            size = s;
            mask = new string[size, size]; 
            events = new string[size, size];
            generate();
            mask[pRow, pCol] = player;
            refresh();
        }
        public void generate()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mask[i, j] = unexplored;
                    events[i, j] = unexplored;
                }
            }
            populate(5, enemy, new Random());
            populate(2, trapdoor, new Random());
            populate(2, chest, new Random());
            populate(1, boss, new Random());
        }
        public void populate(int n, string type, Random rand)
        {
            for (int i = 0; i < n; i++)
            {
                int r = rand.Next(0, size);
                int c = rand.Next(0, size);
                while(mask[r, c].Equals(player) || events[r, c].Equals(enemy) || events[r, c].Equals(trapdoor) 
                    || events[r, c].Equals(chest) || events[r, c].Equals(boss))
                {
                    r = rand.Next(0, size);
                    c = rand.Next(0, size);
                }
                events[r, c] = type;
            }
        }
        public void movement()
        {
            _pRow = pRow; _pCol = pCol;
            ConsoleKeyInfo keyPress = Console.ReadKey();
            postEvent(pRow, pCol);
            switch (keyPress.Key)
            {
                case ConsoleKey.Escape: Environment.Exit(1); break;
                case ConsoleKey.UpArrow: try { pRow -= 1; mask[pRow, pCol] = player; }
                                            catch { pRow += 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.LeftArrow: try { pCol -= 1; mask[pRow, pCol] = player; }
                                            catch { pCol += 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.RightArrow: try { pCol += 1; mask[pRow, pCol] = player; }
                                            catch { pCol -= 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.DownArrow: try { pRow += 1; mask[pRow, pCol] = player; }
                                            catch { pRow -= 1; mask[pRow, pCol] = player; } break;
            }
            onEvent(pRow, pCol);
        }
        public void postEvent(int r, int c)
        {
            try
            {
                if (events[r, c].Equals(unexplored))
                {
                    mask[r, c] = explored;
                }
                if (events[r, c].Equals(enemy))
                {
                    mask[r, c] = enemy;
                }
                else if (events[r, c].Equals(enemyDef))
                {
                    mask[r, c] = enemyDef;
                }
                if (events[r, c].Equals(boss))
                {
                    mask[r, c] = boss;
                }
                else if (events[r, c].Equals(bossDef))
                {
                    mask[r, c] = bossDef;
                }
                if (events[r, c].Equals(trapdoor))
                {
                    mask[r, c] = trapdoor;
                }
                else if (events[r, c].Equals(trapDef))
                {
                    mask[r, c] = trapDef;
                }
                if (events[r, c].Equals(chest))
                {
                    mask[r, c] = chest;
                }
                else if (events[r, c].Equals(chestOpen))
                {
                    mask[r, c] = chestOpen;
                }
            }
            catch { }
        }
        public void onEvent(int r, int c)
        {
            try
            {
                if (events[r, c].Equals(enemy))
                {
                    mask[r, c] = onEnemy;
                }
                if (events[r, c].Equals(boss))
                {
                    mask[r, c] = onBoss;
                }
                if (events[r, c].Equals(trapdoor))
                {
                    mask[r, c] = onTrap;
                }
                if (events[r, c].Equals(chest))
                {
                    mask[r, c] = onChest;
                }
                refresh();
            }
            catch { }
        }
        public void refresh()
        {
            Console.Clear();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mask[i, j]);
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(message);
        }
    }
}