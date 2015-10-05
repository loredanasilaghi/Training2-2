using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training2_2
{
    [TestClass]
    public class Anagrams
    {
        [TestMethod]
        public void CalculateNumberOfAnagramsForWordThatHasRepetedChars()
        {
            string word = "mississippi";
            Assert.AreEqual(34650, CalculateAnagrams(word));
        }

        [TestMethod]
        public void CalculateNumberOfAnagramsForWordThatHasNonRepetedChars()
        {
            string word = "math";
            Assert.AreEqual(24, CalculateAnagrams(word));
        }

        [TestMethod]
        public void CalculateNumberOfAnagramsForWordThatHasOnlyRepetedChars()
        {
            string word = "bbb";
            Assert.AreEqual(1, CalculateAnagrams(word));
        }

        private static double CalculateAnagrams(string word)
        {
            int originalNumberOfChars = word.Length;
            double product = 1;
            while(0 < word.Length)
            {
                int frequency = 1;
                for (int j = 1; j < word.Length; j++)
                {
                    if (word[0] == word[j])
                        frequency++;
                }
                word = word.Replace(word[0].ToString(),string.Empty);
                product *= CalculateFactorial(frequency);
            }
            double result = CalculateFactorial(originalNumberOfChars) / product;
            return result;
        }

        private static double CalculateFactorial(int noToBeFactored)
        {
            if (noToBeFactored == 0)
            {
                return 1;
            }

            double multiplication = 1;
            for (int i = 1; i <= noToBeFactored; i++)
            {
                multiplication *= (double)i;
            }

            return multiplication;
        }
    }
}
