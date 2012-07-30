using System;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_6
{
	[TestFixture]
	public class Class1
	{
		[Test]
		public void Should_sum_the_squares_of_1_and_2()
		{
			var result = 0;

			for (int i = 1; i <= 2; i++)
			{
				result += Square(i);
			}

			result.Should().Be(5);
		}

		[Test]
		public void Should_sum_the_squares_of_each_number_between_1_to_10()
		{
			var result = 0;

			for (int i = 1; i <= 10; i++)
			{
				result += Square(i);
			}

			result.Should().Be(385);
		}

		[Test]
		public void Should_square_the_sum_of_each_number_between_1_to_10()
		{
			var result = 0;
			var sum = 0;
			for (int i = 1; i <= 10; i++)
			{
				sum += i;
			}
			result = Square(sum);
			result.Should().Be(3025);
		}

		[Test]
		public void Should_return_the_difference_between_the_sum_and_the_Square_for_all_numbers_between_1_and_10()
		{
			var difference = Difference(10);
			difference.Should().Be(2640);
		}

		[Test]
		public void Should_return_the_difference_between_the_sum_and_the_Square_for_all_numbers_between_1_and_100()
		{
			Console.WriteLine(Difference(100));
		}

		private int Difference(int iterations)
		{
			var square = 0;
			var sum = 0;
			for (var i = 1; i <= iterations; i++)
			{
				square += Square(i);
				sum += i;
			}

			return Square(sum) - square;
		}

		private int Square(int valueToSquare)
		{
			return valueToSquare * valueToSquare;
		}
	}
}
