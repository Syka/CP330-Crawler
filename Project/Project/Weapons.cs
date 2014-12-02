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
        void useWeapon();
        
    }


    //Sword
    //Sword will set damage to 5, this will then be used in the future when attacking an enemy.
    public class Sword : WeaponBehaviour
    {
        Random random = new Random();
        int damage;


        public void useWeapon()
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
                Console.WriteLine("Your sword misses!");
                Console.ReadLine();
            }
            


        }


    }

    //Axe
    //Axe will set damage to 8, this will then be used in the future when attacking an enemy.
    public class Axe : WeaponBehaviour
    {

        int damage = 8;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 8;


        }


    }

    //Knife
    //Knife will set damage to 2, this will then be used in the future when attacking an enemy.
    public class Knife : WeaponBehaviour
    {

        int damage = 2;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 2;


        }


    }

    //Mace
    //Mace will set damage to 4, this will then be used in the future when attacking an enemy.
    public class Mace : WeaponBehaviour
    {

        int damage = 4;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 4;


        }


    }

    //Fish
    //Fish will set damage to 3, this will then be used in the future when attacking an enemy.
    public class Fish : WeaponBehaviour
    {

        int damage = 3;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 3;


        }


    }


    //Bowstaff
    //Bowstaff will set damage to 6, this will then be used in the future when attacking an enemy.
    public class Bowstaff : WeaponBehaviour
    {

        int damage = 6;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 6;


        }


    }


    //Caestus
    //Caestus will set damage to 1, this will then be used in the future when attacking an enemy.
    public class Caestus : WeaponBehaviour
    {

        int damage = 1;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 1;


        }


    }

    //Quarterstaff
    //Quarterstaff will set damage to 7, this will then be used in the future when attacking an enemy.
    public class Quarterstaff : WeaponBehaviour
    {

        int damage = 7;

        public void useWeapon()
        {
            Console.WriteLine("You swing with the Axe!");
            damage = 7;


        }


    }
}
