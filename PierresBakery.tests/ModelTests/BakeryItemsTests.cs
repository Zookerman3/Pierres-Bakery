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
            int result = newBread.LoavesOrder;
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
            newBread.LoavesOrder = newLoaves;
            //Assert
            Assert.AreEqual(newLoaves, newBread.LoavesOrder);
        }
        [TestMethod] //4
        public void GetPrice_ReturnsThePriceOfLoavesOrder_Int()
        {
            //Arrange
            int loaves = 1;
            int PricePerLoaf = 5;
            Bread newBread = new Bread(loaves);
            //Act
            int totalPrice = newBread.GetBreadTotalPrice(loaves);
            Assert.AreEqual(PricePerLoaf, totalPrice);
            //Assert
        }
        [TestMethod] // 5
        public void GetSalePrice_ReturnstheSalePriceOfLoaves_Int()
        {


            //Arrange
            int loaves = 2;
            int loaves2 = 3;
            Bread newBread = new Bread(loaves);
            Bread newBread2 = new Bread(loaves2);
            //Act
            int totalPrice1 = newBread.GetBreadTotalPrice(loaves);
            int totalPrice2 = newBread2.GetBreadTotalPrice(loaves2);
            //Assert
            Assert.AreEqual(totalPrice1, totalPrice2);
        }
    }
    [TestClass]
    public class PastryTests
    {
        [TestMethod] // 6
        public void PastryConstructor_CreatesInstanceofPastry_Pastry()
        {
            //Arrange
            Pastry newPastry = new Pastry(1);
            //Assert
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
        [TestMethod] // 7
        public void Getpastries_ReturnsLPastries_Int()
        {

            //Arrange
            int pastries = 1;
            Pastry newPastry = new Pastry(pastries);
            //Act
            int result = newPastry.PastryOrder;
            //Assert
            Assert.AreEqual(pastries, result);
        }
        [TestMethod] //8
        public void SetPastries_SetsValueofPastries_Void()
        {
            //Arrange
            Pastry newPastry = new Pastry(2);
            int newPastries = 10;
            //Act
            newPastry.PastryOrder = newPastries;
            //Assert
            Assert.AreEqual(newPastries, newPastry.PastryOrder);
        }
    }
}



//Arrange
//Act
//Assert
