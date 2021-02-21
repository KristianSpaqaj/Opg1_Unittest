using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeerClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Beer Beer { get; set; }

        [TestInitialize]
        public void Init()
        {
            Beer = new Beer(1,"Carlsberg",12.5,4.5);
        }
        [TestMethod]
        public void TestName_TooShort_throwException()
        {
            Assert.ThrowsException<ArgumentException>(() => Beer.Navn = "bo");
        }
        
        [TestMethod]
        public void TestName_Valid()
        {
            Assert.AreEqual("Carlsberg", Beer.Navn);
        }

        [TestMethod]
        public void TestPrice_TooSmall_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Pris = -1);
        }

        [TestMethod]
        public void TestPrice_AtZero_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Pris = 0);
        }

        [TestMethod]
        public void TestAbv_TooSmall_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Abv = -1);
        }

        [TestMethod]
        public void TestAbv_AtZero_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Abv = 0);
        }

        [TestMethod]
        public void TestAbv_TooLarge_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Abv = 101);
        }

        [TestMethod]
        public void TestAbv_AtHundred_throwException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Abv = 100);
        }

        [TestMethod]
        public void Abv_Valid()
        {
            Assert.AreEqual(4.5,Beer.Abv);
        }
    }
}
