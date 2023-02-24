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
            Bread newBread = new Bread();
            //Act
            //Assert
            Assert.AreEqual(typeof(Bread), newBread.GetType());


        }



    }
}


//Arrange
//Act
//Assert