using System;
using System.Numerics;
using Euler_20;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_20_tests
{
    [TestFixture]
    public class Euler_20_tests
    {
        private BigInteger result;
        private Euler20Calculator euler20Calculator;

        [SetUp]
        public void SetUp()
        {
            result = 1;
            euler20Calculator = new Euler20Calculator();
        }

        [Test]
        public void Should_calculate_the_composite_integer_multiples_of_10_to_3628800()
        {
            result = euler20Calculator.GetMultipleCalculation(10);

            result.Should().Be(3628800);
        }

        [Test]
        public void Should_calculate_the_composite_integer_sum()
        {
            result = 3628800;

            var sum = euler20Calculator.GetSumCalculation(result);

            sum.Should().Be(27);

        }

        [Test]
        public void Should_get_the_answer_for_euler_20()
        {
            const int seed = 100;

            Console.WriteLine(euler20Calculator.GetSumCalculation(euler20Calculator.GetMultipleCalculation(seed)));
        }
    }
}
