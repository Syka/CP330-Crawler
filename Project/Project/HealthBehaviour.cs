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
        int health();
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
        public int health()
        {
            int valueHealth = 20 + randomHealth.Next(3,10);
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
        public int health()
        {
            int valueHealth = 10 + randomHealth.Next(1,7);
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
        public int health()
        {
            int valueHealth = 10 + randomHealth.Next(0,5);
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
        public int health()
        { 
            int valueHealth = 25 + randomHealth.Next(5,20);
            return valueHealth;
        }
        public int currentHealth()
        {
            return valueHealth;
        }
    }
}
