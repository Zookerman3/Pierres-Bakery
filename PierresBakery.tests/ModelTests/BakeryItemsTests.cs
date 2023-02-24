using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod] // 1
        public void BreadConstructor_CreatesInstanceofBread_Bread()
        {
            //Arrange
            Bread newBread = new Bread(2);
            //Act
            //Assert
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod] //2
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

        [TestMethod] //3
        public void SetLoaves_SetsValueofLoaves_Void()
        {
            //Arrange
            Bread newBread = new Bread(2);
            int newLoaves = 10;
            //Act
            newBread.Loaves = newLoaves;
            //Assert
            Assert.AreEqual(newLoaves, newBread.Loaves);
        }
    }
}


//Arrange
//Act
//Assert
