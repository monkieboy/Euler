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
            Grid(2, 2).Should().Be(6);
        }

        [Test]
        public void Should_locate_3_routes_for_a_1_by_2_grid()
        {
            Grid(1, 2).Should().Be(3);
        }

        private int Grid(int gridSizeX, int gridSizeY)
        {
            var result = 0;
            for (var i = 0; i < gridSizeY; i++)
            {
                result += gridSizeX;
            }
            return result + gridSizeY;
        }
    }
}
