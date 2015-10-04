using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training2_2
{
    [TestClass]
    public class TablaSah
    {
        [TestMethod]
        public void TestWithATableOf8x8()
        {
            Assert.AreEqual(204, CalculateNumberOfSquares(8));
        }

        [TestMethod]
        public void TestWithATableOf1x1()
        {
            Assert.AreEqual(1, CalculateNumberOfSquares(1));
        }


        private static double CalculateNumberOfSquares(int length)
        {
            double sumOfSquares = 0;
            for (int i = 0; i < length; i++)
            {
                sumOfSquares += Math.Pow((double)(length - i), 2);
            }
            return sumOfSquares;
        }
    }
}
