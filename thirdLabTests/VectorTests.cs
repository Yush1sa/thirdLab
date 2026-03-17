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
            var vector1 = new Vector(3, 5, 7);
            Assert.AreEqual("Вектор: (3, 5, 7)", vector1.ToString());
        }


        [TestMethod()]
        public void AddNumbersTest()
        {
            var vector1 = new Vector(3, 5, 7);
            var vector2 = new Vector(1, 2, 3);
            var vector0 = vector1 + vector2;
            var answer = new Vector(4, 7, 10);
            Assert.AreEqual(answer, vector0);
        }

        [TestMethod()]
        public void SubNumbersTest()
        {
            var vector1 = new Vector(3, 5, 7);
            var vector2 = new Vector(1, 2, 3);
            var vector0 = vector1 - vector2;
            Vector answer = new Vector(2, 3, 4);
            Assert.AreEqual(answer, vector0);
        }

        [TestMethod()]
        public void VecMulByNumbersTest()
        {
            var vector1 = new Vector(3, 5, 7);
            var vector2 = new Vector(1, 2, 3);
            var vector0 = vector1 * vector2;
            Vector answer = new Vector(1, -2, 1);
            Assert.AreEqual(answer, vector0);
        }

        [TestMethod()]
        public void ScalarMulByNumbersTest()
        {
            var vector1 = new Vector(3, 5, 7);
            var vector2 = new Vector(1, 2, 3);
            var vector0 = vector1 & vector2;
            Assert.AreEqual(34, vector0);
        }

        [TestMethod()]
        public void CalculationLengthTest()
        {
            var vector1 = new Vector(3, 4, 0);
            Assert.AreEqual(5, vector1.Length());
        }

      
    }
}