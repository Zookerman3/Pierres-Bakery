using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceofBread_Bread()
        {
            //Arrange
            Bread newBread = new Bread(2);
            //Act
            //Assert
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetLoaves_ReturnsLoaves_Int()
        {
            
            //Arrange
            int loaves = 1;
            Bread newBread = new Bread(loaves);
            //Act
            int result = newBread.Loaves;
            //Assert
            Assert.AreEqual(loaves, result);
        }


    }
}


//Arrange
//Act
//Assert
