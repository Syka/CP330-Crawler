using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DungeonCrawler;




namespace CrawlerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[ExpectedException(typeof(OverflowException))]
        public void HealthTest()
        {
            Player test = new Player();
            test.HealthBehaviour.health();
            int PlayerHealth = test.HealthBehaviour.health();
            if(PlayerHealth>45 | PlayerHealth<=0)
            {
                throw new OverflowException("Health starts at " + PlayerHealth);
            } 
        }
    }
}
