using System;

namespace LearnDSAlgorithms
{
    internal class Recursion
    {
        // time complexity o(n)
        public void CalculateTailRecursion(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateTailRecursion(n--);
            }
        }

        // time complexity o(n)
        public void CalculateHeadRecursion(int n)
        {
            if (n > 0)
            {
                CalculateHeadRecursion(n--);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        // time complexity o( exp(n) )
        public void CalculateTreeRecursion(int n)
        {
            if (n > 0)
            {
                CalculateTreeRecursion(n--);
                int k = n * n;
                Console.WriteLine(k);
                CalculateTreeRecursion(n--);
            }
        }

        #region Indirect
        public void CalculateARecursion(int n)
        {
            if (n > 0)
            {
                CalculateBRecursion(n--);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        public void CalculateBRecursion(int n)
        {
            if (n > 0)
            {
                CalculateARecursion(n--);
                int k = n * n;
                Console.WriteLine(k);
            }
        }
        #endregion

        // time complexity o(n+1)
        public void CalculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                --n;
            }
        }
    }
}
