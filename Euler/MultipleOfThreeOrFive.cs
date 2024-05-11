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
    public static class MultipleOfThreeOrFive
    {
        public static int GetSum(int upperLimit= 1000)
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
    }
}
