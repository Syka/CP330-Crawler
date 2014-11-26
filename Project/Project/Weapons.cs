using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    public interface WeaponBehaviour
    {

    }

    public class Sword : WeaponBehaviour
    {
        int durability = 8;
        int damage = 5;

        public void useWeapon()
        {



        }


    }

    public class Sword : WeaponBehaviour
    {
        int durability = 8;
        int damage = 5;

        public void useWeapon()
        {
            Console.WriteLine("Sword Durability: {0}", durability);
            if (durability > 0)
            {
                Console.WriteLine("You slash with the sword!");
                durability = durability - 2;
                damage = 5;
            }

            else
            {
                Console.WriteLine("Your Sword broke!!!");
            }


        }


    }
    
}
