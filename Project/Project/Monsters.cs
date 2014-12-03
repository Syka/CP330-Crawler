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
        public Random rngWep = new Random();
        public int ranWep;
        public Monsters(){}
    }
    public class Ogre : Monsters
    {
        ///Ogre's Specific traits
        public Ogre()
        {
            HealthBehaviour = new HighHealth();
            monsterName = HealthBehaviour.name("Ogre");
            ranWep = rngWep.Next(0, 8);
            if (ranWep==0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe();}
            else if (ranWep==2)
            { WeaponBehaviour = new Knife();}
            else if (ranWep==3)
            { WeaponBehaviour = new Mace();}
            else if (ranWep==4)
            { WeaponBehaviour = new Fish();}
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff();}
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus();}
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
                
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
