using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This is the weapons section of the Dungeon C#rawler, included are the list of weapons to be used in the game. 
//Each weapon has it's damage counter included inside each weapons. The system takes the weapon which then sets 
//the damage to a current value.
namespace Project
{

    //List of Weapons to use
    //Sword-----------damage = 5
    //Axe-------------damage = 8
    //Knife-----------damage = 2
    //Mace------------damage = 4
    //Fish------------damage = 3
    //Bowstaff--------damage = 6
    //Caestus---------damage = 1
    //Quarterstaff----damage = 7

    public interface WeaponBehaviour
    {
        int useWeapon();
        
    }


    //Sword
    //Sword will set damage to 5, this will then be used in the future when attacking an enemy.
    public class Sword : WeaponBehaviour
    {
        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Sword
            if (random.Next(0, 2)== 0)
            {
                damage = 5;
                Console.WriteLine("You slash with the Sword! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;
            


        }


    }

    //Axe
    //Axe will set damage to 8, this will then be used in the future when attacking an enemy.
    public class Axe : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 8;
                Console.WriteLine("You swing with the Axe! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }

    //Knife
    //Knife will set damage to 2, this will then be used in the future when attacking an enemy.
    public class Knife : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 2;
                Console.WriteLine("You stab with the Knife! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }

    //Mace
    //Mace will set damage to 4, this will then be used in the future when attacking an enemy.
    public class Mace : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 4;
                Console.WriteLine("You swing with your knife! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }

    //Fish
    //Fish will set damage to 3, this will then be used in the future when attacking an enemy.
    public class Fish : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 3;
                Console.WriteLine("You slap with the Fish! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }


    //Bowstaff
    //Bowstaff will set damage to 6, this will then be used in the future when attacking an enemy.
    public class Bowstaff : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 6;
                Console.WriteLine("You swing with the Bowstaff! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }


    //Caestus
    //Caestus will set damage to 1, this will then be used in the future when attacking an enemy.
    public class Caestus : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 1;
                Console.WriteLine("You punch with your Caestus! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }

    //Quarterstaff
    //Quarterstaff will set damage to 7, this will then be used in the future when attacking an enemy.
    public class Quarterstaff : WeaponBehaviour
    {

        Random random = new Random();
        int damage;


        public int useWeapon()
        {

            //Random Generator for Axe
            if (random.Next(0, 2) == 0)
            {
                damage = 7;
                Console.WriteLine("You stab with the QuarterStaff! Causing {0} damage!", damage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your attack misses!");
                Console.ReadLine();
            }
            return damage;


        }


    }
}
