using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
     /// <summary>
     /// Hold the traits for the Hero, allowing for multiple in the future.
     /// </summary>
    public abstract class Heros
    {
        ///implements the Health interface
        public IHealthBehaviour HealthBehaviour;
        ///Implements using a weapon
        public WeaponBehaviour WeaponBehaviour;
        public Heros()
        { 
 
        }
    }
    /// <summary>
    /// Sets the Heros Name and Health
    /// Room for multiple heros
    /// </summary>
    public class Player : Heros
    {
        ///hero1's Specific traits.
        public Player()
        {
            HealthBehaviour = new HeroHealthHigh();
            HealthBehaviour.setHealth();
            HealthBehaviour.setName("");
        }
    }

}
