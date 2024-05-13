using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public static class LargestPrimeFactor
    {
        public static long GetForNumber(long n)
        {
            for(long i=2; i<n;i++)
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
