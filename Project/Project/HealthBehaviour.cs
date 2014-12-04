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
    public class HighHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        public void setHealth()
        {
            valueHealth = 20 + randomHealth.Next(3,10);
        }
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        public int getHealth()
        {
            return valueHealth;
        }
        public void setName(string s)
        {
            name = s;
        }
        public string getName()
        {
            return name;
        }
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    public class MedHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        public void setHealth()
        {
            valueHealth = 10 + randomHealth.Next(1,7);
        }
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        public int getHealth()
        {
            return valueHealth;
        }
        public void setName(string s)
        {
            name = s;
        }
        public string getName()
        {
            return name;
        }
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    public class  LowHealth : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        public void setHealth()
        {
            valueHealth = 10 + randomHealth.Next(0,5);
        }
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        public int getHealth()
        {
            return valueHealth;
        }
        public void setName(string s)
        {
            name = s;
        }
        public string getName()
        {
            return name;
        }
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
    public class HeroHealthHigh : IHealthBehaviour
    {
        public string name;
        public bool canFlee;
        public int valueHealth;
        Random randomHealth = new Random();
        public void setHealth()
        { 
            valueHealth = 25 + randomHealth.Next(5,20);
        }
        public void addHealth(int hp)
        {
            valueHealth += hp;
        }
        public void subHealth(int hp)
        {
            valueHealth -= hp;
        }
        public int getHealth()
        {
            return valueHealth;
        }
        public void setName(string s)
        {
            name = s;
        }
        public string getName()
        {
            return name;
        }
        public void setFlee(bool f) { canFlee = f; }
        public bool getFlee() { return canFlee; }
    }
}
