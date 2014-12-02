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
        void Health();
        
    }

    public class HighHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public void Health()
        {
            
            valueHealth = 20 + randomHealth.Next(3,10);
        }
    }

    public class MedHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public void Health()
        {
            valueHealth = 10 + randomHealth.Next(1,7);
        }   
    }

    public class LowHealth : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public void Health()
        {
            valueHealth = 10 + randomHealth.Next(0,5);
        }
    }

    public class HeroHealthHigh : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public void Health()
        { 
            valueHealth = 25 + randomHealth.Next(5,20);
        }
    }

    public class HeroHealthLow : IHealthBehaviour
    {
        public int valueHealth;
        Random randomHealth = new Random();
        public void Health()
        {
            valueHealth = 15 + randomHealth.Next(0,10);
        }

    }
}
