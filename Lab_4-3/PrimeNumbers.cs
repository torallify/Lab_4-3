using System;
using System.Collections.Generic;

namespace Lab_4_3
{
    public class PrimeNumbers
    {
        //static List<int> primeNums = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
        static List<int> primeNumbersList = new List<int>();


        public PrimeNumbers()
        {

        }
        
        static public void MakePrimeList()
        {
            primeNumbersList.Clear();
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(int.MaxValue); i++)
            {
                for (int j = 2; j <= Math.Sqrt(int.MaxValue); j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbersList.Add(i);
                }
                isPrime = true;
            }
        }
        static public int GetPrime(int num)
        {
            //return primeNums[num - 1];
            return primeNumbersList[num - 1];
        }

        
    }
}
