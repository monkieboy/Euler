using System.Collections.Generic;
using System.Linq;

namespace Euler_10
{
    public static class MathExtensions
    {

        public static long GetPrimeForMax(this long i)
        {
            var prime = GetPrimes(i).Sum();
            return prime;
        }

        private static IEnumerable<long> GetPrimes(long maximumToReturn)
        {
            var i = 1;
            var primeNumbers = new List<long>();
            do
            {
                var item = IsPrime(i) ? i : 0;
                if (item != 0)
                {
                    primeNumbers.Add(item);
                }
                i++;
            } while (maximumToReturn >= i);
            return primeNumbers;
        }

        public static bool IsPrime(long candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the very end.
            for (var i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

    }
}
