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
        public Monsters()
        {
    
        }
    }

    public class Ogre : Monsters
    {
        //Ogre's Specific traits
        public Ogre()
        { 
        
        }
    }

    public class Troll : Monsters
    {
        //Troll's Specific traits

        public Troll()
        {

        }
    }

    public class Spirit : Monsters
    {
        //Spirit's Specific traits

        public Spirit()
        { 
        
        }
    }

    public class Swamphag : Monsters 
    {
        //Swamphag's Specific traits    -- Boss
        public Swamphag()
        { 
        
        }
    }
}
