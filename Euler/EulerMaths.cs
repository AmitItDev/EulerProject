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
        public static int GetSumOfMultipleOfThreeOrFive(int upperLimit = 1000)
        {
            int sum = 0;

            for (int i = 0; i < upperLimit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
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

        public static long GetLargestPrimeFactor(long n = 600851475143)
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

        public static long GetLargestPalindromeProduct(long digitNumber = 2)
        {
            long largestPalindrome = 0;
            int min = 1;
            int max = 10;
            for (int i = 1; i <= digitNumber; i++)
            {
                min = Convert.ToInt32(min.ToString() + "0");
                max = Convert.ToInt32(max.ToString() + "0");
            }
            var mult1 = 0;
            var mult2 = 0;
            for (int i = min; i < max; i++)
            {
                for (int j = min; j < max; j++)
                {
                    int product = i * j;
                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                        mult1 = i; mult2 = j;
                    }
                }


            }

            return largestPalindrome;
        }
        public static bool IsPalindrome(int number)
        {
            string num = number.ToString();
            char[] numArray = num.ToCharArray();
            string reversedNumber = "";

            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                reversedNumber += numArray[i].ToString();
            }

            return reversedNumber == num;

        }

        public static long SmallestMultiple(int from = 1, int to = 20)
        {
            int lcm = 1;
            for (int i = 2; i <= to; i++)
            {
                lcm = LCM(lcm, i);
            }
            return lcm;
        }
        static int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static long SumSquareDifference(int n = 100)
        {
            // Calculate the sum of the squares
            long sumOfSquares = SumOfSquares(n);

            // Calculate the square of the sum
            long squareOfSum = SquareOfSum(n);

            // Calculate the difference
            return squareOfSum - sumOfSquares;
        }

        static long SumOfSquares(int n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }

        static long SquareOfSum(int n)
        {
            long sum = n * (n + 1) / 2;
            return sum * sum;
        }

        public static long FindNthPrime(int n = 10001)
        {
            if (n == 1)
                return 2;

            int count = 1;
            int number = 3;

            while (count < n)
            {
                if (IsPrime(number))
                {
                    count++;
                }

                number += 2;
            }

            return number - 2;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
