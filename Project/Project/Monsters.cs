using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
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
    /// <summary>
    /// High toughness
    /// </summary>
    public class Ogre : Monsters
    {
        public Ogre()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Dungeon Ogre");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
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
    public class Mercenary : Monsters
    {
        public Mercenary()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Mercenary");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Wraith : Monsters
    {
        public Wraith()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Wraith");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    /// <summary>
    /// Medium toughness 
    /// </summary>
    public class Troll : Monsters
    {
        public Troll()
        {
            HealthBehaviour = new MedHealth();
            HealthBehaviour.setName("Troll");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Skeleton : Monsters
    {
        public Skeleton()
        {
            HealthBehaviour = new MedHealth();
            HealthBehaviour.setName("Skeleton");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Bandit : Monsters
    {
        public Bandit()
        {
            HealthBehaviour = new MedHealth();
            HealthBehaviour.setName("Bandit");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    /// <summary>
    /// Low toughness
    /// </summary>
    public class Spirit : Monsters
    {
        public Spirit()
        {
            HealthBehaviour = new LowHealth();
            HealthBehaviour.setName("Spirit");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Goblin : Monsters
    {
        public Goblin()
        {
            HealthBehaviour = new LowHealth();
            HealthBehaviour.setName("Goblin");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Zombie : Monsters
    {
        public Zombie()
        {
            HealthBehaviour = new LowHealth();
            HealthBehaviour.setName("Zombie");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(true);
            ranWep = rngWep.Next(0, 8);
            if (ranWep == 0)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep == 1)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep == 2)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep == 3)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep == 4)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep == 5)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep == 6)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep == 7)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    /// <summary>
    /// Bosses differ from regular monsters as they cannot be fled from
    /// </summary>
    public class Swamphag : Monsters 
    {
        public Swamphag()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Swamghag");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 150)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 150 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 305)
            { WeaponBehaviour = new Fish(); }
            else if (ranWep >= 305 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 431)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >=431 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class Swamphag : Monsters
    {
        ///Swamphag's Specific traits    -- Boss
        public Swamphag()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Swamghag");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 150)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 150 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 431)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >= 431 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class UndeadKing : Monsters
    {
        public UndeadKing()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Undead King");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 160)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 160 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 471)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >= 471 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }

        }
    }
    public class SpiderQueen : Monsters
    {
        public SpiderQueen()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Spider Queen");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 160)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 160 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 471)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >= 471 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
    public class SkeletonKing : Monsters
    {
        SkeletonKing()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Skeleton King");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 160)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 160 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 471)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >= 471 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }

        }

    }
    public class OgreKing : Monsters
    {
        OgreKing()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Ogre King");
            HealthBehaviour.setHealth();
            HealthBehaviour.setFlee(false);
            ranWep = rngWep.Next(0, 500);
            if (ranWep >= 0 && ranWep < 100)
            { WeaponBehaviour = new Sword(); }
            else if (ranWep >= 100 && ranWep < 160)
            { WeaponBehaviour = new Axe(); }
            else if (ranWep >= 160 && ranWep < 175)
            { WeaponBehaviour = new Knife(); }
            else if (ranWep >= 175 && ranWep < 300)
            { WeaponBehaviour = new Mace(); }
            else if (ranWep >= 300 && ranWep < 430)
            { WeaponBehaviour = new Bowstaff(); }
            else if (ranWep >= 430 && ranWep < 471)
            { WeaponBehaviour = new Caestus(); }
            else if (ranWep >= 471 && ranWep <= 499)
            { WeaponBehaviour = new Quarterstaff(); }
        }
    }
}
