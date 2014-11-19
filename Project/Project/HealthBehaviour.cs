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
        public void Health()
        {
            //Health = 20
        }
    }

    public class MedHealth : IHealthBehaviour
    {
        public void Health()
        { 
            //Health = 15
        }
    }

    public class LowHealth : IHealthBehaviour
    { 
        public void Health()
        {
            //Health 10
        }
    }

    public class HeroHealthHigh : IHealthBehaviour
    {
        public void Health()
        { 
            //Health 25
        }
    }

    public class HeroHealthLow : IHealthBehaviour
    {
        public void Health()
        {
            //Health 15
        }

    }
}
