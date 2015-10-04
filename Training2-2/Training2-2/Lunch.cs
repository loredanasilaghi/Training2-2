using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Training2_2
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, CalculateLeastCommunMultiple(4, 6));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3960, CalculateLeastCommunMultiple(1980, 88));
        }

        public struct Multiple
        {
            public int number, exp;
            public Multiple(int number_var, int exp_var)
            {
                number = number_var;
                exp = exp_var;
            }
        }

        private static double CalculateLeastCommunMultiple(int number1, int number2)
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
                    product*= Math.Pow(list2[i].number, list2[i].exp);
            }
            return product;
        }

        private static List<Multiple> DecomposeInPrimeFactors(int number)
        {
            List<Multiple> multiples = new List<Multiple>();
            int count = (number/2) + 1;
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
                if (number!=i)
                    if (number % i == 0)
                        return false;
            }
            return true;
        }
    }
}
