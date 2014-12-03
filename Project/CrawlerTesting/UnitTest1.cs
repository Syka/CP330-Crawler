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
            //Checks to make sure that the Player's Health is generated in a specific value
            Player test = new Player();
            for(int i=0;i<50;i++)
            {
                int PlayerHealth = test.HealthBehaviour.setHealth();            
            if(PlayerHealth>45 | PlayerHealth<=0)
            {
                throw new OverflowException("Health starts at " + PlayerHealth);
            } 
            }
           
        }
    }
}
