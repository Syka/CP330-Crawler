using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DungeonCrawler
{
    ///Base Health values for Heroes and Bosses
    
    public interface IHealthBehaviour
    {
        void setHealth();
        void addHealth(int hp);
        void subHealth(int hp);
        int getHealth();
        void setName(string s);
        string getName();
        void setFlee(bool f);
        bool getFlee();
    }
    /// <summary>
    /// Derives from IHealthBehaviour, Sets a High base health value plus a random amount. Sets flee type as well as controls health changes from combat
    /// </summary>
    public class HighHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        /// <summary>
        /// Sets base health + random value between 3 and 9.
        /// </summary>
        public void setHealth()
        {
            valueHealth = 20 + randomHealth.Next(3,10);
        }
        /// <summary>
        /// Takes in a value to add to HP
        /// </summary>
        /// <param name="hp"></param>
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        /// <summary>
        /// Takes in a value to subract from HP
        /// </summary>
        /// <param name="hp"></param>
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        /// <summary>
        /// Returns the current health value of the assign monster 
        /// </summary>
        /// <param name="hp"></param>
        public int getHealth()
        {
            return valueHealth;
        }
        /// <summary>
        /// Sets the name value
        /// </summary>
        /// <param name="s"></param>
        public void setName(string s)
        {
            name = s;
        }
        /// <summary>
        /// Returns the name value
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Sets the flee value
        /// </summary>
        /// <param name="f"></param>
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    /// <summary>
    /// Derives from IHealthBehaviour, Sets a Medium base health value plus a random amount. Sets flee type as well as controls health changes from combat
    /// </summary>
    public class MedHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        /// <summary>
        /// Sets base health + random value between 1 and 7
        /// </summary>
        public void setHealth()
        {
            valueHealth = 10 + randomHealth.Next(1,7);
        }
        /// <summary>
        /// Takes in a value to add to HP
        /// </summary>
        /// <param name="hp"></param>
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        /// <summary>
        /// Takes in a value to subtract from HP
        /// </summary>
        /// <param name="hp"></param>
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        /// <summary>
        /// Returns the current health value of the assign monster or hero
        /// </summary>
        /// <param name="hp"></param>
        public int getHealth()
        {
            return valueHealth;
        }
        /// <summary>
        /// Sets the name value
        /// </summary>
        /// <param name="s"></param>
        public void setName(string s)
        {
            name = s;
        }
        /// <summary>
        /// Returns the name value
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Sets the flee value
        /// </summary>
        /// <param name="f"></param>
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    /// <summary>
    /// Derives from IHealthBehaviour, Sets a Low base health value plus a random amount. Sets flee type as well as controls health changes from combat
    /// </summary>
    public class  LowHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        /// <summary>
        /// Sets base health + random value between 0 and 5
        /// </summary>
        public void setHealth()
        {
            valueHealth = 10 + randomHealth.Next(0,5);
        }
        /// <summary>
        /// Takes in a value to add to HP
        /// </summary>
        /// <param name="hp"></param>
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        /// <summary>
        /// Takes in a value to subtract from HP
        /// </summary>
        /// <param name="hp"></param>
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        /// <summary>
        /// Returns the current health value of the assign monster or hero
        /// </summary>
        /// <param name="hp"></param>
        public int getHealth()
        {
            return valueHealth;
        }
        /// <summary>
        /// Sets the name value
        /// </summary>
        /// <param name="s"></param>
        public void setName(string s)
        {
            name = s;
        }
        /// <summary>
        /// Returns the name value
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Sets the flee value
        /// </summary>
        /// <param name="f"></param>
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    /// <summary>
    /// Derives from IHealthBehaviour, Sets The hero's base health value plus a random amount. controls health changes from combat. Has flee since it derives from the Ihealth.
    /// </summary>
    public class HeroHealthHigh : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        /// <summary>
        /// Sets base health + random value between 5 and 19
        /// </summary>
        public void setHealth()
        { 
            valueHealth = 25 + randomHealth.Next(5,20);
        }
        /// <summary>
        /// Takes in a value to add to HP
        /// </summary>
        /// <param name="hp"></param>
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        /// <summary>
        /// Takes in a value to subtract from HP
        /// </summary>
        /// <param name="hp"></param>
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        /// <summary>
        /// Returns the current health value of the assign hero
        /// </summary>
        /// <param name="hp"></param>
        public int getHealth()
        {
            return valueHealth;
        }
        /// <summary>
        /// Unused until multiple character DLC
        /// </summary>
        /// <returns></returns>
        public void setName(string s)
        {
            name = s;
        }
        /// <summary>
        /// Unused until multiple character DLC
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
}
