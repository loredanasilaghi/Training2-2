using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Training2_2
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestLeastCommonMultiple4and6()
        {
            Assert.AreEqual(12, CalculateLeastCommonMultiple(4, 6));
        }

        [TestMethod]
        public void TestLeastCommonMultiple1980And88()
        {
            Assert.AreEqual(3960, CalculateLeastCommonMultiple(1980, 88));
        }

        [TestMethod]
        public void TestLeastCommonMultiple24and8()
        {
            Assert.AreEqual(24, CalculateLeastCommonMultiple(24, 8));
        }

        [TestMethod]
        public void TestLeastCommonMultiple4and4()
        {
            Assert.AreEqual(4, CalculateLeastCommonMultiple(4, 4));
        }

        [TestMethod]
        public void TestLeastCommonMultiple0and4()
        {
            Assert.AreEqual(0, CalculateLeastCommonMultiple(0, 4));
        }

        [TestMethod]
        public void TestLeastCommonMultiple4and0()
        {
            Assert.AreEqual(0, CalculateLeastCommonMultiple(4, 0));
        }

        [TestMethod]
        public void TestLeastCommonMultiple11and13()
        {
            Assert.AreEqual(143, CalculateLeastCommonMultiple(11, 13));
        }

        private static int CalculateLeastCommonMultiple(int a, int b)
        {
            int leastCommonMultiple = (a / CalculateGreatestCommonFactor(a, b)) * b;
            return leastCommonMultiple;
        }

        private static int CalculateGreatestCommonFactor(int a, int b)
        {
            while (b != 0)
            {
                int aux = b;
                b = a % b;
                a = aux;
            }
            return a;
        }

        /*first solution
        public struct Multiple
        {
            public int number, exp;
            public Multiple(int number_var, int exp_var)
            {
                number = number_var;
                exp = exp_var;
            }
        }

        private static double CalculateLeastCommonMultiple(int number1, int number2)
        {
            List<Multiple> list1 = DecomposeInPrimeFactors(number1);
            List<Multiple> list2 = DecomposeInPrimeFactors(number2);
            double product = 1;
            bool list1IsBigger = false;
            int minCount = 0;
            int maxCount = 0;

            if (list1.Count > list2.Count)
            {
                list1IsBigger = true;
                minCount = list2.Count;
                maxCount = list1.Count;
            }
            else
            {
                minCount = list1.Count;
                maxCount = list2.Count;
            }

            for (int i = 0; i < minCount; i++)
            {
                if (list1[i].exp > list2[i].exp)
                    product *= Math.Pow(list1[i].number, list1[i].exp);
                else
                    product *= Math.Pow(list2[i].number, list2[i].exp);
            }
            for (int i = minCount; i < maxCount; i++)
            {
                if (list1IsBigger)
                    product *= Math.Pow(list1[i].number, list1[i].exp);
                else
                    product *= Math.Pow(list2[i].number, list2[i].exp);
            }
            return product;
        }

        private static List<Multiple> DecomposeInPrimeFactors(int number)
        {
            List<Multiple> multiples = new List<Multiple>();
            int count = (number / 2) + 1;
            for (int i = 2; i <= count; i++)
            {
                if (IsPrime(i))
                {
                    int exp = 0;
                    while (number % i == 0)
                    {
                        number = number / i;
                        exp++;
                    }
                    multiples.Add(new Multiple(i, exp));
                    if (number == 1)
                        return multiples;
                }
                else
                    continue;
            }
            return multiples;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= (number / 2) + 1; i++)
            {
                if (number != i)
                    if (number % i == 0)
                        return false;
            }
            return true;
        }*/
    }
}
