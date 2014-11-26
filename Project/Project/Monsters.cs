using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    //Holds the traits all Monsters Have
    public abstract class Monsters
    {
        //implements the Health interface
        public IHealthBehaviour mHealthBehaviour;
        //implements the Weapon Damage interface
        //public WeaponBehaviour mWeaponBehaviour
        public Monsters()
        {

        }
    }

    public class Ogre : Monsters
    {
        //Ogre's Specific traits
        public Ogre()
        {
            mHealthBehaviour = new HighHealth();
            //mWeaponBehaviour = new ***();
        }
    }

    public class Troll : Monsters
    {
        //Troll's Specific traits

        public Troll()
        {
            mHealthBehaviour = new MedHealth();
            //mWeaponBehaviour = new ***();
        }
    }

    public class Spirit : Monsters
    {
        //Spirit's Specific traits

        public Spirit()
        {
            mHealthBehaviour = new LowHealth();
            //mWeaponBehaviour = new ***();
        }
    }

    public class Swamphag : Monsters 
    {
        //Swamphag's Specific traits    -- Boss
        public Swamphag()
        {
            mHealthBehaviour = new HighHealth();
            //mWeaponBehaviour = new ***();
        }
        
    }
}
