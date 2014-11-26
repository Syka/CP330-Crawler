using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    //List of Weapons to use
    //Sword-----------damage = 5
    //Axe-------------damage = 8
    //Knife-----------damage = 2
    //Mace
    //Fish
    //Bowstaff
    //Saestus

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
    
    
}
