using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// If we list all the natural numbers below that are multiples of or, we get and.The sum of these multiples is 
    /// .Find the sum of all the multiples of or below.
    /// </summary>
    public static class EulerMaths
    {
        public static int GetSumOfMultipleOfThreeOrFive(int upperLimit= 1000)
        {
            int sum = 0;

            for(int i = 0; i<upperLimit; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int GetSumOfEvenFibonacciNumbers(int limit = 4000000)
        {
            int sum = 0;
            int first = 1;
            int second = 2;

            if (second % 2 == 0)
            {
                sum += second;
            }
            while (second < limit)
            {
                //find the even number
                if (second % 2 == 0)
                {
                    sum += second;
                }
                int next = first + second;
                first = second;
                second = next;
            }
            return sum;
        }

        public static long GetLargestPrimeFactor(long n= 600851475143)
        {
            for (long i = 2; i < n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                }
            }

            return n;
        }
    }
}
