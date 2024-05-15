using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of multiple of 3 or 5 under 1000: "+EulerMaths.GetSumOfMultipleOfThreeOrFive());
            Console.WriteLine("Sum of even numbers in the Fibonacci sequence under the value : 4000000" + EulerMaths.GetSumOfEvenFibonacciNumbers());
            Console.WriteLine("The largest prime factor of 600851475143 is: " + EulerMaths.GetLargestPrimeFactor());
            Console.WriteLine("The Largest Palindrome Product for 2 digit is: " + EulerMaths.GetLargestPalindromeProduct());
            Console.WriteLine("Smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is: " + EulerMaths.SmallestMultiple());
        }
    }
}
