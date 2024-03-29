﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    ///Holds the traits all Monsters Have
    public abstract class Monsters
    {
        public IHealthBehaviour HealthBehaviour;        ///allows reference to the Health interface
        public WeaponBehaviour WeaponBehaviour;         ///allows reference to the Weapons interface
        public string monsterName;
        public Random rngWep = new Random();
        public int ranWep;
        public Monsters(){}
    }
    #region Non-Bosses
    /// <summary>
    /// High toughness
    /// Equal weapon weighting
    /// Fleeable
    /// </summary>
    public class Ogre : Monsters
    {
        /// <summary>
        /// Ogre
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Mercenary : Monsters
    {
        /// <summary>
        /// Merc.
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Wraith : Monsters
    {
        /// <summary>
        /// Wraith
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    /// <summary>
    /// Medium toughness 
    /// Equal weapon weighting
    /// </summary>
    public class Troll : Monsters
    {
        /// <summary>
        /// Troll
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Skeleton : Monsters
    {
        /// <summary>
        /// Skeleton
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Bandit : Monsters
    {
        /// <summary>
        /// Bandit
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    /// <summary>
    /// Low toughness
    /// Equal weapon weighting
    /// </summary>
    public class Spirit : Monsters
    {
        /// <summary>
        /// Spirit
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Goblin : Monsters
    {
        /// <summary>
        /// Goblin
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Zombie : Monsters
    {
        /// <summary>
        /// Zombie
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    #endregion
    #region Bosses
    /// <summary>
    /// Bosses differ from regular monsters as they cannot be fled from
    /// un-equal weapon weighting
    /// Cannot be fleed
    /// </summary>
    public class Swamphag : Monsters 
    {
        /// <summary>
        /// Swamphag
        /// </summary>

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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class Demon : Monsters
    {
        /// <summary>
        /// Demon
        /// </summary>
        public Demon()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Demon");
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
            { WeaponBehaviour = new Spear(); }

        }
    }
    public class SpiderQueen : Monsters
    {
        /// <summary>
        /// Spider Queen
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class SkeletonKing : Monsters
    {
        /// <summary>
        /// Skeleton King
        /// </summary>
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
            { WeaponBehaviour = new Spear(); }

        }

    }
    public class BloodOgre : Monsters
    {
        /// <summary>
        /// Blood Ogre
        /// </summary>
        public BloodOgre()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Blood Ogre");
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
            { WeaponBehaviour = new Spear(); }
        }
    }
    public class BlackKnight : Monsters
    {
        /// <summary>
        /// Black Knight
        /// </summary>
        public BlackKnight()
        {
            HealthBehaviour = new HighHealth();
            HealthBehaviour.setName("Black Knight");
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
            { WeaponBehaviour = new Spear(); }
        }
    }
}
    #endregion
