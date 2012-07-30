using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> primeNumbers = new List<double>();
			for (double i = 1; i <= 10000; i++)
			{
				var primeFound = CompilePrimeNumbers(i);
				if (primeFound != 0)
				{
					primeNumbers.Add(primeFound);
				}
			}
			double result = 1;
			primeNumbers.Reverse();
			foreach (var primeNumber in primeNumbers)
			{
				if (600851475143 % primeNumber == 0)
				{
					result = primeNumber;
					break;
				}
			}

			Console.WriteLine("result: " + result.ToString());
			Console.WriteLine("Last value: " + primeNumbers[primeNumbers.Count-1]);
			Console.ReadKey();
		}

		private static double CompilePrimeNumbers(double i)
		{
			if (i == 1) return i;
			for (var j = 2; j <= i; j++)
			{
				if (i % j == 0)
				{
					return j != i ? 0 : i;
				}
			}
			return 0;
		}
	}
}
