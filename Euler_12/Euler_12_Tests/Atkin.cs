using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler_12_Tests
{

    public class Atkin : IEnumerable<ulong>
    {
        private readonly List<ulong> primes;
        private readonly ulong limit;

        public Atkin(ulong limit)
        {
            this.limit = limit;
            primes = new List<ulong>();
        }

        static List<int> FindPrimesBySieveOfAtkins(int max)
        {
            //  var isPrime = new BitArray((int)max+1, false); 
            //  Can't use BitArray because of threading issues.

            var isPrime = new bool[max + 1];
            var sqrt = (int)Math.Sqrt(max);

            Parallel.For(1, sqrt, x =>
            {
                var xx = x * x;
                for (int y = 1; y <= sqrt; y++)
                {
                    var yy = y * y;
                    var n = 4 * xx + yy;
                    if (n <= max && (n % 12 == 1 || n % 12 == 5))
                        isPrime[n] ^= true;

                    n = 3 * xx + yy;
                    if (n <= max && n % 12 == 7)
                        isPrime[n] ^= true;

                    n = 3 * xx - yy;
                    if (x > y && n <= max && n % 12 == 11)
                        isPrime[n] ^= true;
                }
            });

            var primes = new List<int>() { 2, 3 };
            for (int n = 5; n <= sqrt; n++)
            {
                if (isPrime[n])
                {
                    primes.Add(n);
                    int nn = n * n;
                    for (int k = nn; k <= max; k += nn)
                        isPrime[k] = false;
                }
            }

            for (int n = sqrt + 1; n <= max; n++)
                if (isPrime[n])
                    primes.Add(n);

            return primes;
        }
        
        private void FindPrimes()
        {
            var isPrime = new bool[limit + 1];
            var sqrt = Math.Sqrt(limit);

            for (ulong x = 1; x <= sqrt; x++)
                for (ulong y = 1; y <= sqrt; y++)
                {
                    var n = 4 * x * x + y * y;
                    if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                        isPrime[n] ^= true;

                    n = 3 * x * x + y * y;
                    if (n <= limit && n % 12 == 7)
                        isPrime[n] ^= true;

                    n = 3 * x * x - y * y;
                    if (x > y && n <= limit && n % 12 == 11)
                        isPrime[n] ^= true;
                }

            for (ulong n = 5; n <= sqrt; n++)
                if (isPrime[n])
                {
                    ulong nSquared = n*n;
                    for (ulong k = nSquared; k <= limit; k += nSquared)
                        isPrime[k] = false;
                }
            primes.Add(2);
            primes.Add(3);
            for (ulong n = 5; n <= limit; n++)
                if (isPrime[n])
                    primes.Add(n);
        }


        public IEnumerator<ulong> GetEnumerator()
        {
            if (!primes.Any())
                FindPrimes();


            foreach (var p in primes)
                yield return p;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
