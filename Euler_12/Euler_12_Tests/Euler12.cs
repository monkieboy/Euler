using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_12_Tests
{
    [TestFixture]
    public class Euler12
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            var sequence = new Atkin(2000000);

            var first500ProductFound = sequence.Take(5).ToArray().Max();

            Console.WriteLine(first500ProductFound+1);
            foreach (var VARIABLE in sequence.Take(5))
            {
                Console.WriteLine(VARIABLE+1);
            }
        }

        private static readonly ulong[] First500 = new ulong[] { 2, 3, 5, 7, 11, 13, 17, };
        [Test]
        [Ignore]
        public void Should_find_the_first_triangle_number_with_500_factors()
        {
            Console.WriteLine(ForFactorCountOf(500L).GetTheFirstTriangleNumber());
        }

        [Test]
        public void Should_find_the_first_triangle_number_with_20_factors()
        {
            Console.WriteLine(ForFactorCountOf(20L).GetTheFirstTriangleNumber());
        }

        [Test]
        public void Should_find_the_first_triangle_number_with_15_factors()
        {
            Console.WriteLine(ForFactorCountOf(15L).GetTheFirstTriangleNumber());
        }

        private long ForFactorCountOf(long i)
        {
            return i;
        }

        [Test]
        public void Should_find_12_as_the_first_triangle_number_with_5_factors()
        {
            ForFactorCountOf(5L).GetTheFirstTriangleNumber().Should().Be(12);
        }

        [Test]
        public void Should_produce_sum_to_28_for_7_and_5_products_of_28()
        {
            7L.GetTriangleNumber().GetFactorCountForLong().Count().Should().Be(5);
        }

        [Test]
        public void Should_produce_sum_to_28_for_7_numbers()
        {
            7L.GetTriangleNumber().Should().Be(28);
        }

        [Test]
        public void Should_count_the_triangle_numbers_for_28_to_7_numbers()
        {
            28L.GetTriangleNumberCount().Should().Be(7);
        }

        [Test]
        public void Should_count_the_triangle_numbers_for_55_to_10_numbers()
        {
            55L.GetTriangleNumberCount().Should().Be(10);
        }

        [Test]
        public void Should_return_5_factors_for_triangle_number_28()
        {
            var factorCountForLong = 28L.GetFactorCountForLong();
            var countForLong = factorCountForLong as List<long> ?? factorCountForLong.ToList();
            foreach (var i in countForLong)
            {
                Console.WriteLine(i);
            }
            countForLong.Count().Should().Be(5);
        }

        [Test]
        public void Should_return_3_factors_for_triangle_number_55()
        {
            var factorCountForLong = 55L.GetFactorCountForLong();
            var countForLong = factorCountForLong as long[] ?? factorCountForLong.ToArray();
            foreach (var i in countForLong)
            {
                Console.WriteLine(i);
            }
            countForLong.Count().Should().Be(3);
        }
    }
}