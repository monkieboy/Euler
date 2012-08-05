using System.Collections.Generic;
using System.Linq;

namespace Euler_12_Tests
{
    public static class MathExtensions
    {
        public static IEnumerable<long> GetFactorCountForLong(this long product)
        {
            var factors = new List<long>();
            for (var i = product - 1; i >= 1; i--)
            {
                if (product % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }

        public static long GetTriangleNumberCount(this long seed)
        {
            var i = 1;
            var previous = 1;
            for (; i + previous <= seed; i++)
            {
                previous += i;
            }
            return i;
        }

        public static long GetTriangleNumber(this long count)
        {
            var result = 0;
            for (var i = 1; i <= count; i++)
            {
                result += i;
            }
            return result;
        }

        public static long GetTheFirstTriangleNumber(this long factorCount)
        {
            var i = 1L;
            var count = 1L;
            do
            {
                i+=count;
                count = i.GetFactorCountForLong().Count();
            } while (count != factorCount);
            return i;
        }
    }
}