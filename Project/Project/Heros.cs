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
        public IHealthBehaviour hHealthBehaviour;
        //Implements using a weapon

        public Heros()
        { 
            //Chosen weapon to be placed here.
        }
    }

    public class hero1 : Heros
    {
        //hero1's Specific traits.
        public hero1()
        {
            hHealthBehaviour = new HeroHealthHigh();
        }
    }
    public class hero2 : Heros 
    {
        //hero2's specific traits
        public hero2()
        {
            hHealthBehaviour = new HeroHealthLow();
        }
    }
}
