using Microsoft.VisualStudio.TestTools.UnitTesting;
using thirdLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdLab.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void ShowTest()
        {
            var Vector1 = new Vector(3, 5, 7);
            Assert.AreEqual("Вектор: (3, 5, 7)", Vector1.ToString());
        }


        [TestMethod()]
        public void AddNumbersTest()
        {
            var Vector1 = new Vector(3, 5, 7);
            var Vector2 = new Vector(1, 2, 3);
            var Vector0 = Vector1 + Vector2;
            Vector Answer = new Vector(4, 7, 10);
            Assert.AreEqual(Answer, Vector0);
        }

        [TestMethod()]
        public void SubNumbersTest()
        {
            var Vector1 = new Vector(3, 5, 7);
            var Vector2 = new Vector(1, 2, 3);
            var Vector0 = Vector1 - Vector2;
            Vector Answer = new Vector(2, 3, 4);
            Assert.AreEqual(Answer, Vector0);
        }

        [TestMethod()]
        public void VecMulByNumbersTest()
        {
            var Vector1 = new Vector(3, 5, 7);
            var Vector2 = new Vector(1, 2, 3);
            var Vector0 = Vector1 * Vector2;
            Vector Answer = new Vector(1, -2, 1);
            Assert.AreEqual(Answer, Vector0);
        }

        [TestMethod()]
        public void ScalarMulByNumbersTest()
        {
            var Vector1 = new Vector(3, 5, 7);
            var Vector2 = new Vector(1, 2, 3);
            var Vector0 = Vector1 & Vector2;
            Assert.AreEqual(34, Vector0);
        }

        [TestMethod()]
        public void CalculationLengthTest()
        {
            var Vector1 = new Vector(3, 4, 0);
            Assert.AreEqual(5, Vector1.Length());
        }

      
    }
}