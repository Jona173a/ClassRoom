using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;

namespace UnitTestStuderende
{
    [TestClass]

    public class UnitTestStuderende
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            studerende studerende = new studerende("Vinter", 12, 1);

            //Act
            string �rstid = studerende.�rstid();

            //Assert
            Assert.AreEqual("Vinter", �rstid);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            //Arrange
            studerende studerende = new studerende("Vinter", 13, 1);

            //Act
            string �rstid = studerende.�rstid();

            //Assert
            Assert.Fail();
        }
    }
}
