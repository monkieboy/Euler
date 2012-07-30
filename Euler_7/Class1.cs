using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_7
{
	[TestFixture]
	public class Class1
	{
		[Test]
		public void Should_locate_prime_numbers_2_3_5_7_11_13()
		{
			GetPrimes(5)[5].Should().Be(13);
		}

		[Test]
		public void Should_locate_the_10001_prime_number()
		{
			var primes = GetPrimes(10001);
			Console.WriteLine(primes[primes.Count-1]);
		}

		public List<int> GetPrimes(int maximumToReturn)
		{
			var i = 1;
			var primeNumbers = new List<int>();
			do
			{
				var primeFound = CompilePrimeNumbers(i);
				if (primeFound != 0)
				{
					primeNumbers.Add(primeFound);
				}
				i++;
			} while (primeNumbers.Count < maximumToReturn);

			return primeNumbers;
		}

		private static int CompilePrimeNumbers(int i)
		{
			
			if (i == 1) return 0;
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
