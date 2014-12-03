using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    ///Holds the traits all Monsters Have
    public abstract class Monsters
    {
        public IHealthBehaviour HealthBehaviour;
        public WeaponBehaviour WeaponBehaviour;
        public string monsterName;
        public Monsters(){}
    }
    public class Ogre : Monsters
    {
        ///Ogre's Specific traits
        public Ogre()
        {
            HealthBehaviour = new HighHealth();
            monsterName = HealthBehaviour.name("Ogre");
            WeaponBehaviour = new Axe();
        }
    }
    public class Troll : Monsters
    {
        ///Troll's Specific traits
        public Troll()
        {
            HealthBehaviour = new MedHealth();
            monsterName = HealthBehaviour.name("Troll");
            WeaponBehaviour = new Mace();
        }
    }
    public class Spirit : Monsters
    {
        ///Spirit's Specific traits
        public Spirit()
        {
            HealthBehaviour = new LowHealth();
            monsterName = HealthBehaviour.name("Spirit");
            WeaponBehaviour = new Caestus();
        }
    }
    public class Swamphag : Monsters 
    {
        ///Swamphag's Specific traits    -- Boss
        public Swamphag()
        {
            HealthBehaviour = new HighHealth();
            monsterName = HealthBehaviour.name("Swamghag");
            WeaponBehaviour = new Quarterstaff();
        }
    }
}
