﻿using Tyuiu.RadkoVO.Sprint0.Task4.V0.Lib;
namespace Tyuiu.RadkoVO.Sprin0.Task4.V0.Test
{
    [TestClass]
    public sealed class DastaServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }

}
