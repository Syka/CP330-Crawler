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
        public void Health()
        {
            valueHealth = 20;
        }
    }

    public class MedHealth : IHealthBehaviour
    {
        public int valueHealth;

        public void Health()
        {
            valueHealth = 10;
        }
    }

    public class LowHealth : IHealthBehaviour
    {
        public int valueHealth;

        public void Health()
        {
            valueHealth = 10;
        }
    }

    public class HeroHealthHigh : IHealthBehaviour
    {
        public int valueHealth;

        public void Health()
        { 
            valueHealth = 25;
        }
    }

    public class HeroHealthLow : IHealthBehaviour
    {
        public int valueHealth;

        public void Health()
        {
            valueHealth = 15;
        }

    }
}
