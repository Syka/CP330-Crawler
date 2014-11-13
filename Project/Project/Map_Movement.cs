using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Map
    {
        public bool win = false, dead = false;
        static string[,] mask, events;
        static int pRow = 0, _pRow = 0, pCol = 0, _pCol = 0, mapSize = 0;
        static string
            message = "Welcome to C# Crawler! Press the arrow keys to move!",
            player = " <x> ", unexplored = " [ ] ", explored = "  .  ",
            onEnemy = "{ E }", enemy = " {E} ", onEnemyDef = "-{E}-", enemyDef = " -E- ",
            onBoss = "{ B }", boss = " {B} ", onBossDef = "-{B}-", bossDef = " -B- ",
            onTrapdoor = "{ T }", trapdoor = " {T} ";

        public Map(int size)
        {
            mapSize = size; generate();
            populate(6, enemy); populate(2, trapdoor); populate(1, boss);
            refresh();
        }
        public void generate()
        {
            mask = new string[mapSize, mapSize];
            events = new string[mapSize, mapSize];
            for (int i = 0; i < mask.GetLength(0); i++)
            {
                for (int j = 0; j < mask.GetLength(1); j++)
                {
                    mask[i, j] = unexplored;
                    events[i, j] = unexplored;
                }
            }
            mask[pRow, pCol] = player;
        }
        public void populate(int num, string type)
        {
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                int r = rand.Next(0, mapSize - 1);
                int c = rand.Next(0, mapSize - 1);
                while (events[r, c].Equals(enemy) || events[r, c].Equals(trapdoor)
                    || events[r, c].Equals(boss) || (r == 0 && c == 0))
                {
                    r = rand.Next(0, mapSize - 1);
                    c = rand.Next(0, mapSize - 1);
                }
                events[r, c] = type;
            }
        }
        public void movement()
        {
            _pRow = pRow; _pCol = pCol;
            postEventListen(pRow, pCol);
            ConsoleKeyInfo key_press = Console.ReadKey();
            switch (key_press.Key)
            {
                case ConsoleKey.Escape: Environment.Exit(1); break;
                case ConsoleKey.UpArrow: try { pRow -= 1; mask[pRow, pCol] = player; }
                    catch { pRow += 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.LeftArrow: try { pCol -= 1; mask[pRow, pCol] = player; }
                    catch { pCol += 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.DownArrow: try { pRow += 1; mask[pRow, pCol] = player; }
                    catch { pRow -= 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.RightArrow: try { pCol += 1; mask[pRow, pCol] = player; }
                    catch { pCol -= 1; mask[pRow, pCol] = player; } break;
            } eventListen(pRow, pCol); refresh();
        }
        public void eventListen(int r, int c)
        {
            refresh();
            if (events[r, c].Equals(enemy))
            {
                mask[r, c] = onEnemy;
                message = "You have encountered an enemy! \nWill you fight it? (Y / N)";
                refresh(); scenario(enemy, r, c);
            }
            else if (events[r, c].Equals(enemyDef))
            {
                mask[r, c] = onEnemyDef;
                message = "You have defeated this enemy!";
            }
            if (events[r, c].Equals(trapdoor))
            {
                mask[r, c] = onTrapdoor;
                message = "You have fallen through a trapdoor and lost health! \nClimb out? (Y / N)";
                refresh(); scenario(trapdoor, r, c);
            }
            if (events[r, c].Equals(boss))
            {
                mask[r, c] = onBoss;
                message = "You have encountered the boss of the dungeon! \nWill you fight it? (Y / N)";
                refresh(); scenario(boss, r, c);
            }
            else if (events[r, c].Equals(bossDef))
            {
                mask[r, c] = onBossDef;
                message = "You have defeated the dungeon boss!";
            }
            if (events[r, c].Equals(unexplored)
                || events[r, c].Equals(explored)) { message = "You explore more of the dungeon..."; }
        }
        public void postEventListen(int r, int c)
        {
            refresh();
            if (events[r, c].Equals(unexplored)
                || mask[r, c].Equals(unexplored)) { mask[r, c] = explored; }
            if (events[r, c].Equals(enemy)) { mask[r, c] = enemy; }
            else if (events[r, c].Equals(enemyDef)) { mask[r, c] = enemyDef; }
            if (events[r, c].Equals(trapdoor)) { mask[r, c] = trapdoor; }
            if (events[r, c].Equals(boss)) { mask[r, c] = boss; }
            else if (events[r, c].Equals(bossDef)) { mask[r, c] = bossDef; }
        }
        public void scenario(string type, int r, int c) //PLACEHOLDER FOR THE FIGHTING / SCENARIO SYSTEM
        {
            if (type.Equals(enemy))
            {
                if (Console.ReadLine().ToUpper().Equals("Y")) { events[r, c] = enemyDef; mask[r, c] = onEnemyDef; }
                else
                {
                    events[r, c] = enemy; mask[r, c] = enemy;
                    pRow = _pRow; pCol = _pCol; mask[pRow, pCol] = player;
                    eventListen(pRow, pCol);
                }
            }
            else if (type.Equals(boss))
            {
                if (Console.ReadLine().ToUpper().Equals("Y")) { events[r, c] = bossDef; mask[r, c] = onBossDef; }
                else
                {
                    events[r, c] = boss; mask[r, c] = boss;
                    pRow = _pRow; pCol = _pCol; mask[pRow, pCol] = player;
                    eventListen(pRow, pCol);
                }
            }
            else if (type.Equals(trapdoor))
            {
                if (Console.ReadLine().ToUpper().Equals("Y"))
                {
                    events[r, c] = trapdoor; mask[r, c] = trapdoor;
                    pRow = _pRow; pCol = _pCol; mask[pRow, pCol] = player;
                    eventListen(pRow, pCol);
                }
                else { dead = true; }
            }
        }
        public void display(string type)
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    switch (type)
                    {
                        case "mask": Console.Write(mask[i, j]); break;
                        default: Console.Write(events[i, j]); break;
                    }
                } Console.WriteLine(Environment.NewLine);
            } Console.WriteLine(message);
        }
        public void refresh() { Console.Clear(); display("mask"); }
    }
}