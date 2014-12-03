using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    //Holds the traits all Monsters Have
    public interface Monsters
    {
        string name();
    }
    public class Ogre : Monsters
    {
        //Ogre's Specific traits
        public string name()
        {
            return "Ogre";
        }
        IHealthBehaviour health = new HighHealth();
        WeaponBehaviour weapon = new Axe();
    }
    public class Troll : Monsters
    {
        //Troll's Specific traits
        public string name()
        {
            return "Troll";
        }
        IHealthBehaviour health = new MedHealth();
        WeaponBehaviour weapon = new Mace();
    }
    public class Spirit : Monsters
    {
        //Spirit's Specific traits
        public string name()
        {
            return "Spirit";
        }
        IHealthBehaviour health = new LowHealth();
        WeaponBehaviour weapon = new Caestus();
    }
    public class Swamphag : Monsters 
    {
        //Swamphag's Specific traits    -- Boss
        public string name()
        {
            return "Swamphag";
        }
        IHealthBehaviour health = new HighHealth();
        WeaponBehaviour weapon = new Quarterstaff();
    }
}
