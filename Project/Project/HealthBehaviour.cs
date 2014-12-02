using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project
{
    //Base Health values for Heroes and Bosses
    public interface IHealthBehaviour
    {
        int Health();
        
    }

    public class HighHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public int Health()
        {
            
            int valueHealth = 20 + randomHealth.Next(3,10);
            return valueHealth;
        }
    }

    public class MedHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public int Health()
        {
            int valueHealth = 10 + randomHealth.Next(1,7);
            return valueHealth;
        }   
    }

    public class  LowHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public int Health()
        {
            int valueHealth = 10 + randomHealth.Next(0,5);
            return valueHealth;
        }
    }

    public class HeroHealthHigh : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public int Health()
        { 
            int valueHealth = 25 + randomHealth.Next(5,20);
            return valueHealth;
        }
    }

    public class HeroHealthLow : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public int Health()
        {
            int valueHealth = 15 + randomHealth.Next(0,10);
            return valueHealth;
        }

    }
}
