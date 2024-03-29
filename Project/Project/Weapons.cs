﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///This is the weapons section of the Dungeon C#rawler, included are the list of weapons to be used in the game. 
///Each weapon has it's damage counter included inside each weapons. The system takes the weapon which then sets 
///the damage to a current value.
///
///List of Weapons to use
///Sword-----------damage = 5
///Axe-------------damage = 8
///Knife-----------damage = 2
///Mace------------damage = 4
///Fish------------damage = 3
///Bowstaff--------damage = 6
///Caestus---------damage = 1
///Spear----damage = 7
namespace DungeonCrawler
{
   



    /// <summary>
    ///Weapons Interface
    /// </summary>
    public interface WeaponBehaviour 
    {
        string getName(); ///get the Name of the weapon
        int damage(); ///Create a damage int variable
        int useWeapon(); ///create a useWeapon
        string heroMessage(int mode, int dmg); ///string for hero Message
        string monsterMessage(string mName, int mode, int dmg); ///string for monster Message
    }




    /// <summary>
    ///Sword
    ///Sword will set damage to 5, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Sword : WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random(); ///new random
        public int damage() ///set damage method
        {
            return 5; ///returning the swords damage of 5
        }
        public string getName() ///getName method
        {
            return "Sword"; ///returning the name of the weapon
        }
        public int useWeapon() ///UseWeapon Method
        {
            ///Random Generator for Sword
            if (random.Next(0, 4) != 0) ///Sword has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1; /// if the sword is sucessful the samage will be returned
                return dmg;
            }
            else /// if the sword is unsuccessful then damage will return nothing
            {
                return 0;
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) /// Hero message, takes mode and damage
        {
            if (mode != 0) ///this is where we learn if a hero hits or not
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///this is where he will do damage
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///this is where he misses
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster message, takes current arguments and mName
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///this controls the monsters hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///this controls the monsters miss
            }
        }
    }
    


    
    /// <summary>
    ///Axe
    ///Axe will set damage to 8, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Axe : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random();///new random
        public int damage() ///set damage method
        {
            return 8; ///returning the axe damage of 8
        }
        public string getName() /// getName method
        {
            return "Axe"; /// return the name Axe
        }
        public int useWeapon() ///use weapon method
        {
            ///Random Generator for Axe
            if (random.Next(0, 3) == 0) ///Axe has a 33.33% chance of hitting, with a 66% chance of missing
            {
                int dmg = random.Next(6, damage()) + 1; ///return the damage of 6
                return dmg;
            }
            else
            {
                return 0; ///returns damage of 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///Hero message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; /// if gets hit option
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///if not hit  option
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) /// Monster Message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster hits
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses
            }
        }
    }



    /// <summary>
    ///Knife
    ///Knife will set damage to 2, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Knife : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program();///new prog
        Random random = new Random();///new random
        public int damage() ///set damage method
        {
            return 2; ///returning the knife damage of 2
        }
        public string getName() ///getName message
        {
            return "Knife"; ///return name Knife
        }
        public int useWeapon() ///useWeapon method
        {
            ///Random Generator for Knife
            if (random.Next(0, 5) == 0) ///knife has a 80% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1; ///return damage
                return dmg;
            }
            else
            {
                return 0; ///if misses return 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///hero message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if hit
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; /// return if missed
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if misses
            }
        }
    }



    /// <summary>
    ///Mace
    ///Mace will set damage to 4, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Mace : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random();///new random
        public int damage() ///set damage method
        {
            return 4; ///returning the mace damage of 4
        }
        public string getName() ///getName method
        {
            return "Mace"; ///return name as mace
        }
        public int useWeapon() ///useWeapon method
        {
            ///Random Generator for Mace
            if (random.Next(0, 4) != 0) ///Mace has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1; ///return the damage
                return dmg;
            }
            else
            {
                return 0;///return 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///Hero Message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if hit
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if missed
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster Message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; /// return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if missed
            }
        }
    }



    /// <summary>
    ///Fish
    ///Fish will set damage to 3, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Fish : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random(); ///new random
        public int damage() ///set damage method
        {
            return 3; ///returning the fish damage of 3
        }
        public string getName() ///getName method
        {
            return "Fish"; ///return name fish
        }
        public int useWeapon() ///useWeapon method
        {
            ///Random Generator for Fish
            if (random.Next(0, 2) != 0) ///Fish has a 50% chance of hitting, with a 50% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1; ///return damage
                return dmg;
            }
            else
            {
                return 0; ///return 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///Hero message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if hit
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if missed
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if missed
            } 
        }
    }
    /// <summary>
    ///Bowstaff
    ///Bowstaff will set damage to 6, this will then be used in the future when attacking an enemy.
    /// </summary>
    
    public class Bowstaff : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random(); ///new random
        public int damage() ///set damage method
        {
            return 6; ///returning the bowstaff damage of 6
        }
        public string getName() ///getName method
        {
            return "Bowstaff"; ///return the name Bowstaff
        }
        public int useWeapon() ///useWeapon method
        {
            ///Random Generator for Bowstaff
            if (random.Next(0, 4) != 0) ///Bowstaff has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(4, damage()) + 1; ///reutn damage
                return dmg;
            }
            else
            {
                return 0; ///return 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///hero message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if hit
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///returned if missed
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";///return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if missed
            }
        }
    }


    /// <summary>
    ///Caestus
    ///Caestus will set damage to 1, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Caestus : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random();///new random
        public int damage() ///set damage method
        {
            return 1; ///returning the caestus damage of 1
        }
        public string getName() ///getName method
        {
            return "Caestus"; ///set name to Caestus
        }
        public int useWeapon() ///useWeapon method
        {
            return 1; ///always return 1
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///Hero Message
        {
            
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!"; ///Always returns the attack, never misses
            
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///Monster message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if missed
            }
        }
    }



    /// <summary>
    ///Spear
    ///Spear will set damage to 7, this will then be used in the future when attacking an enemy.
    /// </summary>
    public class Spear : WeaponBehaviour ///the weapon is created and uses the interface of WeaponBehaviour
    {
        Program prog = new Program(); ///new prog
        Random random = new Random(); ///new random
        public int damage() ///set damage method
        {
            return 7; ///returning the spear damage of 7
        }
        public string getName() ///getName method
        {
            return "Spear"; ///return name Spear
        }
        public int useWeapon() ///useWeapon method
        {
            ///Random Generator for Spear
            if (random.Next(0, 4) != 0) ///Spear has a 50% chance of hitting, with a 50% chance of missing
            {
                int dmg = random.Next(5, damage()) + 1; ///return damage value
                return dmg;
            }
            else
            {
                return 0; ///return 0
            }
        }
        /// <summary>
        /// This is the message returned for hero
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" You attack with your " + getName() + " and deal (" + dmg + " DMG)!" ///if hero misses</returns>
        public string heroMessage(int mode, int dmg) ///Hero message
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";///return if hit
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!"; ///return if missed
            }
        }
        /// <summary>
        /// This is the message returned for monsters
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="mode"></param>
        /// <param name="dmg"></param>
        /// <returns>" The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///if the monster misses</returns>
        public string monsterMessage(string mName, int mode, int dmg) ///monster message
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";///return if hit
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue"; ///return if missed
            }
        }
    }
}
