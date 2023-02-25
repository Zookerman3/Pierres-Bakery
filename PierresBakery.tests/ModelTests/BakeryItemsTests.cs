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
            newBread.TotalLoaves += loaves;
            int totalPrice = newBread.GetBreadTotalPrice();
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
            int totalPrice1 = newBread.GetBreadTotalPrice();
            int totalPrice2 = newBread2.GetBreadTotalPrice();
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
        [TestMethod] // 9
        public void GetPrice_ReturnsThePriceOfPastryOrder_Int()
        {
            //Arrange
            int pastries = 1;
            int PricePerPastry = 2;
            Pastry newPastry = new Pastry(pastries);
            //Act
            newPastry.TotalPastries += pastries;
            int totalPrice = newPastry.GetPastryTotalPrice();
            Assert.AreEqual(PricePerPastry, totalPrice);
            //Assert
        }
        [TestMethod] // 10
        public void GetSalePrice_ReturnstheSalePriceOfLoaves_Int()
        {
            //Arrange
            int pastries = 3;
            int pastries2 = 4;
            Pastry newPastry = new Pastry(pastries);
            Pastry newPastry2 = new Pastry(pastries2);
            //Act
            int totalPrice1 = newPastry.GetPastryTotalPrice();
            int totalPrice2 = newPastry2.GetPastryTotalPrice();
            //Assert
            Assert.AreEqual(totalPrice1, totalPrice2);
        }
    }
}

//Arrange
//Act
//Assert
