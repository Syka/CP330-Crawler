using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
       //Holds all the traits all heros will have
    public abstract class Heros
    {
        
        //implements the Health interface
        public IHealthBehaviour HealthBehaviour;
        //Implements using a weapon
        public WeaponBehaviour WeaponBehaviour;
        public Heros()
        { 
 
        }
    }

    public class Player : Heros
    {
        //hero1's Specific traits.
        public Player()
        {
            HealthBehaviour = new HeroHealthHigh();
            HealthBehaviour.name("");
        }
    }

}
