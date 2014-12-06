using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///This is the weapons section of the Dungeon C#rawler, included are the list of weapons to be used in the game. 
///Each weapon has it's damage counter included inside each weapons. The system takes the weapon which then sets 
///the damage to a current value.
namespace DungeonCrawler
{
    ///List of Weapons to use
    ///Sword-----------damage = 5
    ///Axe-------------damage = 8
    ///Knife-----------damage = 2
    ///Mace------------damage = 4
    ///Fish------------damage = 3
    ///Bowstaff--------damage = 6
    ///Caestus---------damage = 1
    ///Spear----damage = 7


    ///Weapon interface
    public interface WeaponBehaviour 
    {
        string getName(); //get the Name of the weapon
        int damage(); //Create a damage int variable
        int useWeapon(); //create a useWeapon
        string heroMessage(int mode, int dmg); //string for hero Message
        string monsterMessage(string mName, int mode, int dmg); //string for monster Message
    }



    ///Sword
    ///Sword will set damage to 5, this will then be used in the future when attacking an enemy.
    public class Sword : WeaponBehaviour
    {
        Program prog = new Program(); //new prog
        Random random = new Random(); //new random
        public int damage() //set damage method
        {
            return 5; //returning the swords damage of 5
        }
        public string getName() //getName method
        {
            return "Sword"; //returning the name of the weapon
        }
        public int useWeapon() //UseWeapon Method
        {
            ///Random Generator for Sword
            if (random.Next(0, 4) != 0) //Sword has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1; // if the sword is sucessful the samage will be returned
                return dmg;
            }
            else //if the sword is unsuccessful then damage will return nothing
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }



    ///Axe
    ///Axe will set damage to 8, this will then be used in the future when attacking an enemy.
    public class Axe : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 8;
        }
        public string getName()
        {
            return "Axe";
        }
        public int useWeapon()
        {
            ///Random Generator for Axe
            if (random.Next(0, 3) == 0) //Axe has a 33.33% chance of hitting, with a 66% chance of missing
            {
                int dmg = random.Next(6, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }



    ///Knife
    ///Knife will set damage to 2, this will then be used in the future when attacking an enemy.
    public class Knife : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 2;
        }
        public string getName()
        {
            return "Knife";
        }
        public int useWeapon()
        {
            ///Random Generator for Knife
            if (random.Next(0, 5) == 0) //knife has a 80% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }



    ///Mace
    ///Mace will set damage to 4, this will then be used in the future when attacking an enemy.
    public class Mace : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 4;
        }
        public string getName()
        {
            return "Mace";
        }
        public int useWeapon()
        {
            ///Random Generator for Mace
            if (random.Next(0, 4) != 0) //Mace has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }



    ///Fish
    ///Fish will set damage to 3, this will then be used in the future when attacking an enemy.
    public class Fish : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 3;
        }
        public string getName()
        {
            return "Fish";
        }
        public int useWeapon()
        {
            ///Random Generator for Fish
            if (random.Next(0, 2) != 0) //Fish has a 50% chance of hitting, with a 50% chance of missing
            {
                int dmg = random.Next(1, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }
    ///Bowstaff
    ///Bowstaff will set damage to 6, this will then be used in the future when attacking an enemy.
    public class Bowstaff : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 6;
        }
        public string getName()
        {
            return "Bowstaff";
        }
        public int useWeapon()
        {
            ///Random Generator for Bowstaff
            if (random.Next(0, 4) != 0) //Bowstaff has a 75% chance of hitting, with a 25% chance of missing
            {
                int dmg = random.Next(4, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }
    ///Caestus
    ///Caestus will set damage to 1, this will then be used in the future when attacking an enemy.
    public class Caestus : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 1;
        }
        public string getName()
        {
            return "Caestus";
        }
        public int useWeapon()
        {
            return 1;
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }
    ///Quarterstaff
    ///Quarterstaff will set damage to 7, this will then be used in the future when attacking an enemy.
    public class Spear : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 7;
        }
        public string getName()
        {
            return "Spear";
        }
        public int useWeapon()
        {
            ///Random Generator for Spear
            if (random.Next(0, 4) != 0) //Spear has a 50% chance of hitting, with a 50% chance of missing
            {
                int dmg = random.Next(5, damage()) + 1;
                return dmg;
            }
            else
            {
                return 0;
            }
        }
        public string heroMessage(int mode, int dmg)
        {
            if (mode != 0)
            {
                return " You attack with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
            else
            {
                return " You miss with your " + getName() + " and deal (" + dmg + " DMG)!";
            }
        }
        public string monsterMessage(string mName, int mode, int dmg)
        {
            if (mode != 0)
            {
                return " The " + mName + " attacks with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
            else
            {
                return " The " + mName + " misses with their " + getName() + " and deals (" + dmg + " DMG)! \n \n Press Any Key to Continue";
            }
        }
    }
}
