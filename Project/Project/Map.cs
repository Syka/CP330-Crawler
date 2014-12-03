using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawler;

namespace DungeonCrawler
{
    public class Map
    {   ///All Map and player variables
        Program prog = new Program();
        Player hero = new Player();
        Random rand = new Random();
        ConsoleKeyInfo input;
        static string[,]    mask, events, unknown;
        static int          pRow = 0, pCol = 0, _pRow, _pCol;
        static bool         onLvl_1 = true, onLvl_2 = false, onLvl_3 = false, fight = false;
        static string       player =    " YOU ", unexplored =   " [ ] ", explored =     "     ", bound =        "▓▓▓▓▓",
                            enemy =     " {E} ", onEnemy =      "{ E }", enemyDef =     "-{E}-", onEnemyDef =   "{-E-}",
                            boss =      " {B} ", onBoss =       "{ B }", bossDef =      "-{B}-", onBossDef =    "{-B-}",
                            trapdoor =  " {T} ", onTrap =       "{ T }", trapDef =      "-{T}-", onTrapDef =    "{-T-}",
                            chest =     " {C} ", onChest =      "{ C }", chestOpen =    "-{C}-", onChestOpen =  "{-C-}",
                            door =      " {D} ", onDoor =       "{ D }", undiscovered = " ??? ";
        public Map()
        {   ///Creates new instances of Map arrays and sets player position, weapon and health
            mask = new string[17, 11];                          ///"masks" the contents of the level until explored by the player
            events = new string[17, 11];                        ///the contents of the level
            unknown = new string[17, 11];                       ///"masks" any chests, doors and trapdoors until explored by the player
            generate();
            if (onLvl_1)        setLvl(1);                      ///decides what level to create based on player progress 
            else if (onLvl_2)   setLvl(2);
            else if (onLvl_3)   setLvl(3);
            reveal(pRow, pCol);                                 ///Reveals the map around the player in a 1-block radius
            weaponSelect();
            InfoPane();                         ///Sets info pane to display player information
            refresh();                                          ///Displays arrays to reflect the player's current progress
        }
        static void setPlayer(int r, int c)
        {   ///Sets player coordinates and displays it on the Mask array
            pRow = r; pCol = c; mask[r, c] = player;
        }
        static void generate()
        {   ///Fills null arrays with "blank" spaces
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 11; j++)
                {   
                    mask[i, j] = unexplored;
                    events[i, j] = unexplored;
                    unknown[i, j] = unexplored;
                }
            }
        }
        static void setLvl(int l)
        {   ///Updates player progress when switching levels
            switch(l)
            {   case 1: onLvl_1 = true; onLvl_2 = false; onLvl_3 = false; lvl_1(); break;
                case 2: onLvl_1 = false; onLvl_2 = true; onLvl_3 = false; lvl_2(); break;
                case 3: onLvl_3 = false; onLvl_2 = false; onLvl_3 = true; lvl_3(); break;
            }   refresh();
        }
        public void movement()
        {   ///Reads user input for player movement
            _pRow = pRow; _pCol = pCol;                                     ///Saves previous player coordinates
            mask[pRow, pCol] = explored; reveal(pRow, pCol);                ///Reveals Event content on the Mask array
            input = Console.ReadKey();
            switch (input.Key)
            {   
                case ConsoleKey.Escape: Environment.Exit(1); break;         ///Quits the game upon pressing Escape (testing purposes)
                case ConsoleKey.UpArrow:                                    ///Sets player location one block upwards
                    try {   pRow -= 1;
                            if (checkBound(pRow, pCol))                     ///If 
                                    { pRow += 1; setPlayer(pRow, pCol); }   
                            else    { setPlayer(pRow, pCol); }}
                    catch { pRow += 1; setPlayer(pRow, pCol); } break;      ///In case the player 
                case ConsoleKey.LeftArrow: 
                    try {   pCol -= 1;
                            if (checkBound(pRow, pCol))
                                    { pCol += 1; setPlayer(pRow, pCol); }
                            else    { setPlayer(pRow, pCol); }}
                    catch { pCol += 1; setPlayer(pRow, pCol); } break;
                case ConsoleKey.RightArrow: 
                    try {   pCol += 1;
                            if (checkBound(pRow, pCol))
                                    { pCol -= 1; setPlayer(pRow, pCol); }
                            else    { setPlayer(pRow, pCol); }}
                    catch { pCol -= 1; mask[pRow, pCol] = player; } break;
                case ConsoleKey.DownArrow: 
                    try {   pRow += 1;
                            if (checkBound(pRow, pCol))
                                    { pRow -= 1; setPlayer(pRow, pCol); }
                            else    { setPlayer(pRow, pCol); }}
                    catch { pRow -= 1; mask[pRow, pCol] = player; } break;
            }
            reveal(pRow, pCol); 
            onEvent(pRow, pCol);
        }
        static bool checkBound(int r, int c)
        {   ///
            if (mask[r, c].Equals(bound))   
                    { return true; }
            else    { return false; }
        }
        static void reveal(int r, int c)
        {   ///
            postEvent(r - 1, c);
            postEvent(r - 1, c + 1);
            postEvent(r, c + 1);
            postEvent(r + 1, c);
            postEvent(r + 1, c + 1);
            postEvent(r + 1, c - 1);
            postEvent(r, c - 1);
            postEvent(r - 1, c - 1);
        }
        static void postEvent(int r, int c)
        {   ///
            try 
            {   
                switch (events[r, c])
                {
                    case "▓▓▓▓▓":   mask[r, c] = bound; break;
                    case " [ ] ":   mask[r, c] = explored; break;
                    case " {E} ":   mask[r, c] = enemy; break;
                    case "-{E}-":   mask[r, c] = enemyDef; break;           
                    case " {B} ":   mask[r, c] = boss; break;               
                    case "-{B}-":   mask[r, c] = bossDef; break;            
                    case " {T} ":   mask[r, c] = undiscovered; break;       
                    case "-{T}-":   mask[r, c] = trapDef; break;            
                    case " {C} ":   if (unknown[r, c].Equals(undiscovered)) ///
                                            { mask[r, c] = undiscovered; }
                                    else    { mask[r, c] = chest; } break;
                    case "-{C}-":   mask[r, c] = chestOpen; break;          ///
                    case " {D} ":   if (unknown[r, c].Equals(undiscovered)) ///
                                            { mask[r, c] = undiscovered; }
                                    else    { mask[r, c] = door; } break;
                }
            } catch { }
        }

        public void fightTriggered()
        {     ///is called when going over an enemy on the map and randomly picked one of 3 monsters to fight.
            int randomizer = rand.Next(0, 3);
            int eHealth = 0;
            string monsterName = "";
            string monsterWeapon = "Default";
            if (randomizer == 0)
            {
                Ogre enemy1 = new Ogre();
                eHealth = enemy1.HealthBehaviour.health();
                monsterName = enemy1.monsterName;
                monsterWeapon = enemy1.WeaponBehaviour.name();
            }
            else if (randomizer == 1)
            {
                Troll enemy2 = new Troll();
                eHealth = enemy2.HealthBehaviour.health();
                monsterName = enemy2.monsterName;
                monsterWeapon = enemy2.WeaponBehaviour.name();
            }
            else if (randomizer == 2)
            {
                Spirit enemy3 = new Spirit();
                eHealth = enemy3.HealthBehaviour.health();
                monsterName = enemy3.monsterName;
                monsterWeapon = enemy3.WeaponBehaviour.name();
            }

            prog.ClearTextbox();
            prog.WriteTextBox("You encounter a " + monsterName + " with a " + monsterWeapon + ". Do you fight? (Y/N)");
        }

        public void fightTriggeredBoss()
        {   //is triggered when standing on a boss on the map
            Swamphag enemyBoss = new Swamphag();
            int bHealth = enemyBoss.HealthBehaviour.health();

            prog.ClearTextbox();
            prog.WriteTextBox("You encounter a " + enemyBoss.monsterName + ". Do you fight? (Y/N)");
        }

        public void onEvent(int r, int c)
        { 
            try 
            {
                switch(events[r, c])
                {
                    case " {E} ":
                        mask[r, c] = onEnemy;
                        refresh(); prog.WriteTextBox("Will you fight the ");
                        ///trigger fight
                        fightTriggered();
                        events[r, c] = enemyDef;
                        break;
                    case "-{E}-":
                        mask[r, c] = onEnemyDef;
                        prog.WriteTextBox("You stand over the corpse of your foe, laugh heartily and move on.");
                        break;
                    case " {B} ":
                        mask[r, c] = onBoss;
                        ///trigger fight
                        fightTriggeredBoss();
                        events[r, c] = bossDef;
                        break;
                    case "-{B}-":
                        mask[r, c] = onBossDef;
                        prog.WriteTextBox("You stand over the corpse of the boss, laugh and move on.");
                        break;
                    case " {T} ":
                        mask[r, c] = onTrap;
                        prog.WriteTextBox("You fall down a trapdoor and " + randomInjury() + "! {-2 HP}");
                        ///decrease HP
                        hero.HealthBehaviour.health();
                        events[r, c] = trapDef;
                        break;
                    case "-{T}-":
                        mask[r, c] = onTrapDef; 
                        prog.WriteTextBox("You stand over the disarmed trapdoor, silently sob to yourself and move on.");
                        break;
                    case " {C} ":
                        mask[r, c] = onChest;
                        ///trigger loot
                        prog.WriteTextBox("You open the chest and find X! Holy $%&#!");
                        unknown[r, c] = events[r, c]; events[r, c] = chestOpen;
                        break;
                    case "-{C}-":
                        mask[r, c] = onChestOpen;
                        prog.WriteTextBox("You stand over the opened chest, immediately get bored and move on."); break;
                    case " {D} ":
                        unknown[r, c] = events[r, c]; mask[r, c] = onDoor;
                        refresh(); prog.WriteTextBox("Will you open the ominous door? (Y /N)");
                        input = Console.ReadKey();
                        switch(input.Key)
                        {
                            case ConsoleKey.Y:
                                if (onLvl_1)
                                {
                                    if (checkBoss(16, 7))
                                        setLvl(2);
                                    else
                                        prog.WriteTextBox("You have not defeated the boss yet.");
                                }
                                else if (onLvl_2)
                                {
                                    if (checkBoss(3, 1))
                                        setLvl(3);
                                    else
                                        prog.WriteTextBox("You have not defeated the boss yet.");
                                }
                                else if (onLvl_3)
                                {
                                    GameOver end = new GameOver();
                                    end.Victory();
                                }
                                break;
                            case ConsoleKey.N:
                                prog.WriteTextBox("You ignore your curiosity and move on.");
                                break;
                            default: break;
                        } break;
                } refresh();
            } catch { }
        }
        static bool checkBoss(int r, int c)
        {   ///
            if (events[r, c].Equals(bossDef))
                return true;
            else
                return false;
        }
        public string randomInjury()
        {   ///
            if (rand.Next(0, 6) == 0)       { return "scrape your elbow"; }
            else if (rand.Next(0, 6) == 1)  { return "pull your shoulder"; }
            else if (rand.Next(0, 6) == 2)  { return "hit your funnybone"; }
            else if (rand.Next(0, 6) == 3)  { return "scrape your knee"; }
            else if (rand.Next(0, 6) == 4)  { return "bruise your shin"; }
            else                            { return "cut your face"; }
        }
        static void refresh()
        {   ///
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < 40; i++) 
            { 
                Console.WriteLine(""); 
            }   Console.SetCursorPosition(0, 7);
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(mask[i, j]);
                }   Console.WriteLine(Environment.NewLine);
            }   Console.SetCursorPosition(7, 59);
        }
        public void weaponSelect()
        {
            ///Select weapon 
            prog.WriteTextBox("Please Select a Weapon: " + Environment.NewLine + "1-Sword" + Environment.NewLine + "2-Axe" 
                + Environment.NewLine + "3-Knife" + Environment.NewLine + "4-Mace" + Environment.NewLine + "5-Fish" 
                + Environment.NewLine + "6-Bowstaff" + Environment.NewLine + "7-Caestus" + Environment.NewLine + "8-Quarterstaff");

            ///Takes key input and assigns to weapon
            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    hero.WeaponBehaviour = new Sword();
                    break;
                case ConsoleKey.D2:
                    hero.WeaponBehaviour = new Axe();
                    break;
                case ConsoleKey.D3:
                    hero.WeaponBehaviour = new Knife();
                    break;
                case ConsoleKey.D4:
                    hero.WeaponBehaviour = new Mace();
                    break;
                case ConsoleKey.D5:
                    hero.WeaponBehaviour = new Fish();
                    break;
                case ConsoleKey.D6:
                    hero.WeaponBehaviour = new Bowstaff();
                    break;
                case ConsoleKey.D7:
                    hero.WeaponBehaviour = new Caestus();
                    break;
                case ConsoleKey.D8:
                    hero.WeaponBehaviour = new Quarterstaff();
                    break;
                default:
                    weaponSelect();
                    break;
            }
            prog.WriteTextBox("You have selected: " + hero.WeaponBehaviour.name().ToUpper());
        }
        public void InfoPane()
        {   ///
            Console.SetCursorPosition(59, 7);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("                                                      ");
            }
            Console.SetCursorPosition(59, 7);
            Console.WriteLine("Health: {0}", hero.HealthBehaviour.health());
            Console.SetCursorPosition(59, 8);
            Console.WriteLine("Current Weapon: {0}", hero.WeaponBehaviour.name().ToUpper());
            Console.SetCursorPosition(59, 9);
            Console.WriteLine("Current Damage: {0}", hero.WeaponBehaviour.damage());
        }
        public void resetLevels()
        {   ///Resets player progress
            onLvl_1 = true; onLvl_2 = false; onLvl_3 = false;
        }
        static void put(int r, int c, string type)
        {   ///Adds specific event types on a specific coordinate on the Event array
            events[r, c] = type;
            if (type.Equals(chest) || type.Equals(trapdoor) || type.Equals(door))
                unknown[r, c] = undiscovered;   ///Chests, doors and trapdoors will also be recorded in the Unknown array
        }
        static void lvl_1()
        {   ///The stupidest bit of code ever
            put(0, 0, unexplored); put(0, 1, unexplored); put(0, 2, unexplored); put(0, 3, unexplored); put(0, 4, unexplored); put(0, 5, bound); put(0, 6, bound); put(0, 7, unexplored); put(0, 8, enemy); put(0, 9, unexplored); put(0, 10, bound);
            put(1, 0, bound); put(1, 1, unexplored); put(1, 2, unexplored); put(1, 3, bound); put(1, 4, unexplored); put(1, 5, unexplored); put(1, 6, bound); put(1, 7, unexplored); put(1, 8, bound); put(1, 9, bound); put(1, 10, bound);
            put(2, 0, bound); put(2, 1, unexplored); put(2, 2, unexplored); put(2, 3, bound); put(2, 4, bound); put(2, 5, unexplored); put(2, 6, unexplored); put(2, 7, unexplored); put(2, 8, unexplored); put(2, 9, trapdoor); put(2, 10, chest);
            put(3, 0, bound); put(3, 1, unexplored); put(3, 2, unexplored); put(3, 3, bound); put(3, 4, chest); put(3, 5, enemy); put(3, 6, unexplored); put(3, 7, bound); put(3, 8, bound); put(3, 9, bound); put(3, 10, bound);
            put(4, 0, bound); put(4, 1, bound); put(4, 2, enemy); put(4, 3, bound); put(4, 4, bound); put(4, 5, unexplored); put(4, 6, unexplored); put(4, 7, bound); put(4, 8, bound); put(4, 9, unexplored); put(4, 10, bound);
            put(5, 0, trapdoor); put(5, 1, bound); put(5, 2, unexplored); put(5, 3, bound); put(5, 4, unexplored); put(5, 5, unexplored); put(5, 6, unexplored); put(5, 7, bound); put(5, 8, unexplored); put(5, 9, unexplored); put(5, 10, bound);
            put(6, 0, unexplored); put(6, 1, bound); put(6, 2, unexplored); put(6, 3, unexplored); put(6, 4, unexplored); put(6, 5, bound); put(6, 6, bound); put(6, 7, bound); put(0, 8, unexplored); put(6, 9, unexplored); put(6, 10, chest);
            put(7, 0, enemy); put(7, 1, unexplored); put(7, 2, unexplored); put(7, 3, bound); put(7, 4, unexplored); put(7, 5, bound); put(7, 6, chest); put(7, 7, enemy); put(7, 8, unexplored); put(7, 9, bound); put(7, 10, bound);
            put(8, 0, unexplored); put(8, 1, bound); put(8, 2, unexplored); put(8, 3, bound); put(8, 4, unexplored); put(8, 5, bound); put(8, 6, bound); put(8, 7, bound); put(8, 8, unexplored); put(8, 9, bound); put(8, 10, bound);
            put(9, 0, chest); put(9, 1, bound); put(9, 2, unexplored); put(9, 3, bound); put(9, 4, unexplored); put(9, 5, unexplored); put(9, 6, unexplored); put(9, 7, unexplored); put(9, 8, unexplored); put(9, 9, unexplored); put(9, 10, unexplored);
            put(10, 0, bound); put(10, 1, bound); put(10, 2, unexplored); put(10, 3, bound); put(10, 4, bound); put(10, 5, unexplored); put(10, 6, bound); put(10, 7, bound); put(10, 8, bound); put(10, 9, bound); put(10, 10, trapdoor);
            put(11, 0, unexplored); put(11, 1, unexplored); put(11, 2, unexplored); put(11, 3, bound); put(11, 4, bound); put(11, 5, unexplored); put(11, 6, bound); put(11, 7, chest); put(11, 8, bound); put(11, 9, bound); put(11, 10, bound);
            put(12, 0, unexplored); put(12, 1, bound); put(12, 2, unexplored); put(12, 3, unexplored); put(12, 4, unexplored); put(12, 5, enemy); put(12, 6, unexplored); put(12, 7, unexplored); put(12, 8, unexplored); put(12, 9, enemy); put(12, 10, unexplored);
            put(13, 0, unexplored); put(13, 1, bound); put(13, 2, bound); put(13, 3, bound); put(13, 4, bound); put(13, 5, bound); put(13, 6, unexplored); put(13, 7, unexplored); put(13, 8, unexplored); put(13, 9, bound); put(13, 10, unexplored);
            put(14, 0, unexplored); put(14, 1, unexplored); put(14, 2, unexplored); put(14, 3, unexplored); put(14, 4, bound); put(14, 5, bound); put(14, 6, unexplored); put(14, 7, unexplored); put(14, 8, unexplored); put(14, 9, bound); put(14, 10, unexplored);
            put(15, 0, enemy); put(15, 1, bound); put(15, 2, unexplored); put(15, 3, unexplored); put(15, 4, trapdoor); put(15, 5, bound); put(15, 6, bound); put(15, 7, bound); put(15, 8, bound); put(15, 9, bound); put(15, 10, unexplored);
            put(16, 0, chest); put(16, 1, bound); put(16, 2, unexplored); put(16, 3, enemy); put(16, 4, bound); put(16, 5, bound); put(16, 6, door); put(16, 7, boss); put(16, 8, unexplored); put(16, 9, unexplored); put(16, 10, unexplored);
            setPlayer(0, 0); reveal(pRow, pCol); refresh();
        }
        static void lvl_2()
        {
            generate();
            put(0, 0, chest); put(0, 1, unexplored); put(0, 2, bound); put(0, 3, unexplored); put(0, 4, chest); put(0, 5, bound); put(0, 6, chest); put(0, 7, trapdoor); put(0, 8, bound); put(0, 9, unexplored); put(0, 10, trapdoor);
            put(1, 0, chest); put(1, 1, unexplored); put(1, 2, bound); put(1, 3, unexplored); put(1, 4, bound); put(1, 5, bound); put(1, 6, bound); put(1, 7, unexplored); put(1, 8, bound); put(1, 9, unexplored); put(1, 10, unexplored);
            put(2, 0, bound); put(2, 1, unexplored); put(2, 2, bound); put(2, 3, unexplored); put(2, 4, bound); put(2, 5, door); put(2, 6, bound); put(2, 7, unexplored); put(2, 8, bound); put(2, 9, unexplored); put(2, 10, bound);
            put(3, 0, bound); put(3, 1, boss); put(3, 2, unexplored); put(3, 3, unexplored); put(3, 4, bound); put(3, 5, enemy); put(3, 6, bound); put(3, 7, unexplored); put(3, 8, unexplored); put(3, 9, enemy); put(3, 10, bound);
            put(4, 0, bound); put(4, 1, bound); put(4, 2, bound); put(4, 3, unexplored); put(4, 4, bound); put(4, 5, unexplored); put(4, 6, bound); put(4, 7, unexplored); put(4, 8, bound); put(4, 9, bound); put(4, 10, bound);
            put(5, 0, trapdoor); put(5, 1, unexplored); put(5, 2, bound); put(5, 3, enemy); put(5, 4, unexplored); put(5, 5, unexplored); put(5, 6, unexplored); put(5, 7, enemy); put(5, 8, bound); put(5, 9, unexplored); put(5, 10, chest);
            put(6, 0, bound); put(6, 1, unexplored); put(6, 2, bound); put(6, 3, bound); put(6, 4, bound); put(6, 5, unexplored); put(6, 6, bound); put(6, 7, bound); put(6, 8, bound); put(6, 9, unexplored); put(6, 10, bound);
            put(7, 0, trapdoor); put(7, 1, unexplored); put(7, 2, unexplored); put(7, 3, bound); put(7, 4, unexplored); put(7, 5, unexplored); put(7, 6, unexplored); put(7, 7, bound); put(7, 8, unexplored); put(7, 9, unexplored); put(7, 10, trapdoor);
            put(8, 0, bound); put(8, 1, bound); put(8, 2, enemy); put(8, 3, unexplored); put(8, 4, unexplored); put(8, 5, chest); put(8, 6, unexplored); put(8, 7, unexplored); put(8, 8, enemy); put(8, 9, bound); put(8, 10, bound);
            put(9, 0, chest); put(9, 1, unexplored); put(9, 2, unexplored); put(9, 3, bound); put(9, 4, unexplored); put(9, 5, unexplored); put(9, 6, unexplored); put(9, 7, bound); put(9, 8, unexplored); put(9, 9, unexplored); put(9, 10, trapdoor);
            put(10, 0, bound); put(10, 1, unexplored); put(10, 2, bound); put(10, 3, bound); put(10, 4, bound); put(10, 5, unexplored); put(10, 6, bound); put(10, 7, bound); put(10, 8, bound); put(10, 9, unexplored); put(10, 10, bound);
            put(11, 0, trapdoor); put(11, 1, unexplored); put(11, 2, bound); put(11, 3, enemy); put(11, 4, unexplored); put(11, 5, unexplored); put(11, 6, unexplored); put(11, 7, enemy); put(11, 8, bound); put(11, 9, unexplored); put(11, 10, trapdoor);
            put(12, 0, bound); put(12, 1, bound); put(12, 2, bound); put(12, 3, unexplored); put(12, 4, bound); put(12, 5, unexplored); put(12, 6, bound); put(12, 7, unexplored); put(12, 8, bound); put(12, 9, bound); put(12, 10, bound);
            put(13, 0, bound); put(13, 1, enemy); put(13, 2, unexplored); put(13, 3, unexplored); put(13, 4, bound); put(13, 5, enemy); put(13, 6, bound); put(13, 7, unexplored); put(13, 8, unexplored); put(13, 9, enemy); put(13, 10, bound);
            put(14, 0, bound); put(14, 1, unexplored); put(14, 2, bound); put(14, 3, unexplored); put(14, 4, bound); put(14, 5, chest); put(14, 6, bound); put(14, 7, unexplored); put(14, 8, bound); put(14, 9, unexplored); put(14, 10, bound);
            put(15, 0, unexplored); put(15, 1, unexplored); put(15, 2, bound); put(15, 3, unexplored); put(15, 4, bound); put(15, 5, bound); put(15, 6, bound); put(15, 7, unexplored); put(15, 8, bound); put(15, 9, unexplored); put(15, 10, unexplored);
            put(16, 0, chest); put(16, 1, unexplored); put(16, 2, bound); put(16, 3, chest); put(16, 4, trapdoor); put(16, 5, bound); put(16, 6, unexplored); put(16, 7, unexplored); put(16, 8, bound); put(16, 9, unexplored); put(16, 10, chest);
            setPlayer(16, 6); reveal(pRow, pCol); refresh();
        }
        static void lvl_3()
        {
            generate();
            put(0, 0, bound); put(0, 1, bound); put(0, 2, bound); put(0, 3, bound); put(0, 4, bound); put(0, 5, bound); put(0, 6, bound); put(0, 7, bound); put(0, 8, bound); put(0, 9, bound); put(0, 10, bound);
            put(1, 0, bound); put(1, 1, bound); put(1, 2, bound); put(1, 3, bound); put(1, 4, bound); put(1, 5, chest); put(1, 6, bound); put(1, 7, bound); put(1, 8, bound); put(1, 9, bound); put(1, 10, bound);
            put(2, 0, bound); put(2, 1, bound); put(2, 2, bound); put(2, 3, bound); put(2, 4, unexplored); put(2, 5, unexplored); put(2, 6, unexplored); put(2, 7, bound); put(2, 8, bound); put(2, 9, bound); put(2, 10, bound);
            put(3, 0, bound); put(3, 1, bound); put(3, 2, chest); put(3, 3, enemy); put(3, 4, unexplored); put(3, 5, unexplored); put(3, 6, unexplored); put(3, 7, enemy); put(3, 8, trapdoor); put(3, 9, bound); put(3, 10, bound);
            put(4, 0, bound); put(4, 1, bound); put(4, 2, bound); put(4, 3, bound); put(4, 4, unexplored); put(4, 5, unexplored); put(4, 6, unexplored); put(4, 7, bound); put(4, 8, bound); put(4, 9, bound); put(4, 10, bound);
            put(5, 0, bound); put(5, 1, bound); put(5, 2, bound); put(5, 3, unexplored); put(5, 4, unexplored); put(5, 5, unexplored); put(5, 6, unexplored); put(5, 7, unexplored); put(5, 8, bound); put(5, 9, bound); put(5, 10, bound);
            put(6, 0, bound); put(6, 1, trapdoor); put(6, 2, enemy); put(6, 3, unexplored); put(6, 4, unexplored); put(6, 5, unexplored); put(6, 6, unexplored); put(6, 7, unexplored); put(6, 8, enemy); put(6, 9, chest); put(6, 10, bound);
            put(7, 0, bound); put(7, 1, bound); put(7, 2, bound); put(7, 3, unexplored); put(7, 4, unexplored); put(7, 5, unexplored); put(7, 6, unexplored); put(7, 7, unexplored); put(7, 8, bound); put(7, 9, bound); put(7, 10, bound);
            put(8, 0, bound); put(8, 1, bound); put(8, 2, chest); put(8, 3, unexplored); put(8, 4, unexplored); put(8, 5, unexplored); put(8, 6, unexplored); put(8, 7, unexplored); put(8, 8, chest); put(8, 9, bound); put(8, 10, bound);
            put(9, 0, bound); put(9, 1, bound); put(9, 2, bound); put(9, 3, unexplored); put(9, 4, unexplored); put(9, 5, unexplored); put(9, 6, unexplored); put(9, 7, unexplored); put(9, 8, bound); put(9, 9, bound); put(9, 10, bound);
            put(10, 0, bound); put(10, 1, chest); put(10, 2, enemy); put(10, 3, unexplored); put(10, 4, unexplored); put(10, 5, unexplored); put(10, 6, unexplored); put(10, 7, unexplored); put(10, 8, enemy); put(10, 9, trapdoor); put(10, 10, bound);
            put(11, 0, bound); put(11, 1, bound); put(11, 2, bound); put(11, 3, unexplored); put(11, 4, unexplored); put(11, 5, unexplored); put(11, 6, unexplored); put(11, 7, unexplored); put(11, 8, bound); put(11, 9, bound); put(11, 10, bound);
            put(12, 0, bound); put(12, 1, bound); put(12, 2, bound); put(12, 3, bound); put(12, 4, unexplored); put(12, 5, unexplored); put(12, 6, unexplored); put(12, 7, bound); put(12, 8, bound); put(12, 9, bound); put(12, 10, bound);
            put(13, 0, bound); put(13, 1, bound); put(13, 2, bound); put(13, 3, bound); put(13, 4, unexplored); put(13, 5, unexplored); put(13, 6, unexplored); put(13, 7, bound); put(13, 8, bound); put(13, 9, bound); put(13, 10, bound);
            put(14, 0, bound); put(14, 1, bound); put(14, 2, bound); put(14, 3, bound); put(14, 4, unexplored); put(14, 5, boss); put(14, 6, unexplored); put(14, 7, bound); put(14, 8, bound); put(14, 9, bound); put(14, 10, bound);
            put(15, 0, bound); put(15, 1, bound); put(15, 2, bound); put(15, 3, bound); put(15, 4, bound); put(15, 5, door); put(15, 6, bound); put(15, 7, bound); put(15, 8, bound); put(15, 9, bound); put(15, 10, bound);
            put(16, 0, bound); put(16, 1, bound); put(16, 2, bound); put(16, 3, bound); put(16, 4, bound); put(16, 5, bound); put(16, 6, bound); put(16, 7, bound); put(16, 8, bound); put(16, 9, bound); put(16, 10, bound);
            setPlayer(4, 5); reveal(pRow, pCol); refresh();
        }
    }
}
