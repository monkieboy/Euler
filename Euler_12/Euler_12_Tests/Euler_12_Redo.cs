using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_12_Tests
{
	[TestFixture]
	class Euler_12_Redo
	{
		[Test]
		public void Get_divisors_for_1()
		{
			1.GetDivisors().Should().Be(1);
		}
		[Test]
		public void Get_divisors_for_3()
		{
			3.GetDivisors().Should().Be(2);
		}
		[Test]
		public void Get_divisors_for_6()
		{
			6.GetDivisors().Should().Be(4);
		}
		[Test]
		public void Get_divisors_for_10()
		{
			10.GetDivisors().Should().Be(4);
		}
		[Test]
		public void Get_divisors_for_15()
		{
			15.GetDivisors().Should().Be(4);
		}
		[Test]
		public void Get_divisors_for_21()
		{
			21.GetDivisors().Should().Be(4);
		}
		[Test]
		public void Get_divisors_for_28()
		{
			28.GetDivisors().Should().Be(6);
		}
		[Test]
		public void Get_divisors_for_100()
		{
			100.GetDivisors().Should().Be(9);
		}

		[Test]
		public void Get_divisors_for_576()
		{
			576.GetDivisors().Should().Be(21);
		}
		[Test]
		public void test()
		{
			int number = 0;
			int i = 1;

			while (number.GetDivisors() <= 500)
			{
				number += i;
				i++;
			}

			Console.WriteLine(number);
		}
	}

	public static class PrimeExtensions
	{
		public static int GetDivisors(this int product)
		{
			var nod = 0;
			var sqrt = (int)Math.Sqrt(product);

			for (var i = 1; i <= sqrt; i++)
			{
				if (product % i == 0)
				{
					nod += 2;
				}
			}
			//Correction if the number is a perfect square
			if (sqrt * sqrt == product)
			{
				nod--;
			}

			return nod;
		}
	}
}
