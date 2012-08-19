using System.Numerics;

namespace Euler_20
{
    public class Euler20Calculator
    {
        public BigInteger GetMultipleCalculation(int seed)
        {
            var result = new BigInteger(1);
            for (int i = 2; i <= seed; i++)
            {
                result *= i;
            }

            return result;
        }

        public BigInteger GetSumCalculation(BigInteger seed)
        {
           var sum = new BigInteger(0);

            while (seed > 0)
            {
                sum += seed % 10;
                seed /= 10;
            }

           return sum;

        }
    }
}
