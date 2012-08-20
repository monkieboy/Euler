using System.Collections.Generic;
using System.Numerics;

namespace Euler_25
{
    public class Problem
    {
        private readonly List<BigInteger> sequence = new List<BigInteger>();

        public Problem()
        {
            Seed = 1;
            Start = 1;
        }

        public int Start { get; set; }

        public int Seed { get; set; }
        
        public BigInteger GetFibonacciElementFor(int i)
        {
            GenerateFibonacciUpToLimit(i);

            return sequence[i-1];
        }

        public IList<BigInteger> GenerateTestSequence()
        {
            GenerateFibonacciUpToLimit(10);

            return sequence;
        }

        private void GenerateFibonacciUpToLimit(int limit)
        {
            var count = 1;
            var current = 1;
            var next = 1;
            sequence.Add(1);
            sequence.Add(1);
            while (count <= limit)
            {
                var temp = current + next;
                current = next;
                next = temp;
                sequence.Add(temp);
                count++;
            }
        }

        public BigInteger LocateFirstFibonacciWithNumberGreaterThan(BigInteger limit)
        {
            BigInteger current = 1;
            BigInteger next = 1;
            int count = 2;
            while (next <= limit)
            {
                current = current + next;
                count+=2;
                next = current + next;
            }
            return count;
        }
    }
}
