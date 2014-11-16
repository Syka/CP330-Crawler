using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{

    class SelectWeapon
    {

    }

    public interface WeaponBehaviour
    {
        void useWeapon();


    }
    //Axe
    public class AxeBehaviour : WeaponBehaviour
    {
        int weaponDamage = 5;
        int weaponDurability = 6;

        public void useWeapon()
        {
            if (weaponDurability > 0)
            {
                Console.WriteLine("You Swing with the Axe");
                //Weapons Damage
                weaponDamage = 5;
                //Weapons Durability
                weaponDurability = weaponDurability - 2;
            }
            else
            {
                Console.WriteLine("Your Weapon Broke");

            }

        }


    }

    //Sword
    public class SwordBehaviour : WeaponBehaviour
    {
        int weaponDamage = 3;
        int weaponDurability = 4;

        public void useWeapon()
        {
            if (weaponDurability > 0)
            {
                Console.WriteLine("You Swing with the Sword");
                weaponDamage = 3;
                weaponDurability = weaponDurability - 2;
            }
            else
            {
                Console.WriteLine("Your Weapon Broke");

            }
        }

        public class LongSwordBehaviour : WeaponBehaviour
        {
            public void useWeapon()
            {
                Console.WriteLine("You Slice with the Long Sword");
            }
        }

        public class BowAndArrow : WeaponBehaviour
        {
            public void useWeapon()
            {
                Console.WriteLine("You fire an Arrow");
            }
        }
        public class KnifeBehaviour : WeaponBehaviour
        {
            public void useWeapon()
            {
                Console.WriteLine("You Stab with the Knife");
            }
        }
        public class Mace : WeaponBehaviour
        {
            public void useWeapon()
            {
                Console.WriteLine("You Swing the Mace");
            }
        }
        public class BattleHammer : WeaponBehaviour
        {
            public void useWeapon()
            {
                Console.WriteLine("You Smash the BattleHammer");
            }
        }


    }
}
