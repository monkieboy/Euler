using System;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_9_Tests
{
	public class PythagoreanTriplet
	{
		[TestCase(3, 4, 5)]
		public void Should_check_pythagorean_triplicity(int first, int second, int third)
		{
			CheckTriplicity(first, second, third).Should().BeTrue();
		}

		[Test]
		public void test()
		{
			// 9 + 16 + 25 = 50
		}


		private bool CheckTriplicity(int first, int second, int third)
		{
			var product1 = Square(first);
			var product2 = Square(second);
			var product3 = Square(third);

			product1.Should().BeLessThan(product2);
			product2.Should().BeLessThan(product3);
			Console.WriteLine(product1 * product2 * product3);
			return product1 + product2 == product3;
		}

		private int Square(int first)
		{
			return first * first;
		}
	}
}
