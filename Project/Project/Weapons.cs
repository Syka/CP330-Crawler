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
    ///Quarterstaff----damage = 7
    public interface WeaponBehaviour
    {
        string getName();
        int damage();
        int useWeapon();
    }
    ///Sword
    ///Sword will set damage to 5, this will then be used in the future when attacking an enemy.
    public class Sword : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 5;
        }
        public string getName()
        {
            return "Sword";
        }
        public int useWeapon()
        {
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage()) + 1;
                prog.WriteTextBox("You swing with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage()) + 1;
                prog.WriteTextBox("You swing with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage()) + 1;
                prog.WriteTextBox("You stab with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage()) + 1;
                prog.WriteTextBox("You swing with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage()) + 1;
                prog.WriteTextBox("You slap with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage() + 1);
                prog.WriteTextBox("You swing with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
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
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage() + 1);
                prog.WriteTextBox("You punch with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
            }
        }
    }
    ///Quarterstaff
    ///Quarterstaff will set damage to 7, this will then be used in the future when attacking an enemy.
    public class Quarterstaff : WeaponBehaviour
    {
        Program prog = new Program();
        Random random = new Random();
        public int damage()
        {
            return 7;
        }
        public string getName()
        {
            return "Quarterstaff";
        }
        public int useWeapon()
        {
            ///Random Generator for Sword
            if (random.Next(0, 2) == 0)
            {
                int dmg = random.Next(1, damage() + 1);
                prog.WriteTextBox("You stab with your " + getName() + "! {" + dmg + " DMG}" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return dmg;
            }
            else
            {
                prog.WriteTextBox("Your " + getName() + " misses!" +
                    Environment.NewLine + Environment.NewLine + "Press Enter to continue");
                return 0;
            }
        }
    }
}
