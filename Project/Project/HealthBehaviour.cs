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
        int setHealth();
        int addHealth(int hp);
        int subHealth(int hp);
        int getHealth();
        string name(string s);
    }
    public class HighHealth : IHealthBehaviour
    {
        public string name(string s)
        {
            return s;
        }
        public int valueHealth;
        Random randomHealth = new Random();
        public int setHealth()
        {
            valueHealth = 20 + randomHealth.Next(3,10);
            return valueHealth;
        }
        public int addHealth(int hp)
        {
            valueHealth += hp;
            return valueHealth;
        }
        public int subHealth(int hp)
        {
            valueHealth -= hp;
            return valueHealth;
        }
        public int getHealth()
        {
            return valueHealth;
        }
    }
    public class MedHealth : IHealthBehaviour
    {
        public string name(string s)
        {
            return s;
        }
        public int valueHealth;
        Random randomHealth = new Random();
        public int setHealth()
        {
            valueHealth = 10 + randomHealth.Next(1,7);
            return valueHealth;
        }
        public int addHealth(int hp)
        {
            valueHealth += hp;
            return valueHealth;
        }
        public int subHealth(int hp)
        {
            valueHealth -= hp;
            return valueHealth;
        }
        public int getHealth()
        {
            return valueHealth;
        }
    }
    public class  LowHealth : IHealthBehaviour
    {
        public string name(string s)
        {
            return s;
        }
        public int valueHealth;
        Random randomHealth = new Random();
        public int setHealth()
        {
            valueHealth = 10 + randomHealth.Next(0,5);
            return valueHealth;
        }
        public int addHealth(int hp)
        {
            valueHealth += hp;
            return valueHealth;
        }
        public int subHealth(int hp)
        {
            valueHealth -= hp;
            return valueHealth;
        }
        public int getHealth()
        {
            return valueHealth;
        }
    }
    public class HeroHealthHigh : IHealthBehaviour
    {
        public string name(string s)
        {
            return s;
        }
        public int valueHealth;
        Random randomHealth = new Random();
        public int setHealth()
        { 
            valueHealth = 25 + randomHealth.Next(5,20);
            return valueHealth;
        }
        public int currentHealth()
        {
            return valueHealth;
        }
        public int addHealth(int hp)
        {
            valueHealth += hp;
            return valueHealth;
        }
        public int subHealth(int hp)
        {
            valueHealth -= hp;
            return valueHealth;
        }
        public int getHealth()
        {
            return valueHealth;
        }
    }
}
