using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSpeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSpeed.Tests
{
    [TestClass()]
    public class GetSpeedTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetCurrentSpeedTest_EmptyString()
        {
            GetSpeed getSpeed = new GetSpeed();
            getSpeed.GetCurrentSpeed(String.Empty, String.Empty);
        }

        [TestMethod]
        public void GetCurrentSpeed_WithInput()
        {   //Arrange
            GetSpeed getspeed = new GetSpeed();
            //Act
           var actual = getspeed.GetCurrentSpeed("12", "3");
            var expected = 4;
            //Assert
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void GetCurrentSpeed_Comma()
        {   //Arrange
            GetSpeed getspeed = new GetSpeed();
            //Act
            var actual = getspeed.GetCurrentSpeed("4,5", "2");
            var expected = 2.25;
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}