using System;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_5
{
	[TestFixture]
	public class Class1
	{
		private const int TheValue = 2520;

		[Test]
		public void Should_divide_2520_by_all_integers_from_1_to_10()
		{
			CheckValue(TheValue, 10).Should().BeTrue();
		}

		[Test]
		public void Should_locate_the_first_integer_that_can_be_divided_by_all_numbers_from_1_to_20()
		{
			int valueFound = 0;
			bool passed = false;
			do
			{
				valueFound++;

				passed = CheckValue(valueFound, 20);
			} while (!passed);

			Console.WriteLine(valueFound);
		}

		private static bool CheckValue(int valueToCheck, int iterations)
		{
			const bool valuesPass = true;
			for (var i = 1; i <= iterations; i++)
			{
				if (valueToCheck % i == 0) continue;
				return false;
			}
			return valuesPass;
		}
	}
}
