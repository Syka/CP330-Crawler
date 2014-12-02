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
    public class Sword : WeaponBehaviour
    {
        
        int damage = 5;

        public void useWeapon()
        {
            Console.WriteLine("You slash with the Sword!");
            damage = 5;


        }


    }

    //Axe
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
