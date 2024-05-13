using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of multiple of 3 or 5 under 1000: "+MultipleOfThreeOrFive.GetSum());
            Console.WriteLine("Sum of even numbers in the Fibonacci sequence under the value : 4000000" + EvenFibonacciNumbers.GetSumOfEvenNumbers());
            Console.WriteLine("The largest prime factor of 600851475143 is: " + LargestPrimeFactor.GetForNumber(600851475143));
        }
    }
}
