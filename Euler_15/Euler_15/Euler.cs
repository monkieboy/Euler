using System;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_15
{
	[TestFixture]
	public class Euler
	{
		[Test]
		public void Should_locate_6_routes_for_a_2_by_2_grid()
		{
			SquareGrid(2).Should().Be(6);
		}

		[Test]
		public void Should_locate_12_routes_for_a_3_by_3_grid()
		{
			SquareGrid(3).Should().Be(12);
		}

		[Test]
		public void Should_locate_20_routes_for_4_by_4_grid()
		{
			SquareGrid(4).Should().Be(20);
		}

		[Test]
		public void Should_locate_137846528820_routes_for_20_by_20_grid()
		{
			SquareGrid(20).Should().Be(137846528820);
		}

		[Test]
		public void Should_locate_2_routes_for_a_1_by_1_grid()
		{
			SquareGrid(1).Should().Be(2);
		}

		private long SquareGrid(long gridSize)
		{
			var result = 0L;

			result = (long)Math.Pow(gridSize+1, gridSize);

			return result;
		}
	}
}
