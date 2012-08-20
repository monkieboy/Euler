using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Euler_25;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_25_tests
{
    [TestFixture]
    public class Tests
    {
        private Problem problem = new Problem();

        [Test]
        public void Should_generate_Fibonacci_sequences()
        {
            var generateTestSequence = problem.GenerateTestSequence();
            generateTestSequence.Should().ContainInOrder(new BigInteger[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 });
            generateTestSequence.ToList().ForEach(x => Console.Write("{0} ", x));

        }

        [Test]
        public void The_seventh_element_in_the_Fibonacci_sequence_is_13()
        {
            problem.GetFibonacciElementFor(7).Should().Be(13);
        }

        [Test]
        public void The_twelth_element_in_the_Fibonacci_sequence_is_144()
        {
            problem.GetFibonacciElementFor(12).Should().Be(144);
        }

        [Test]
        public void Get_the_first_fibonacci_with_3_digits()
        {
            var number = problem.LocateFirstFibonacciWithNumberGreaterThan(100);

            number.Should().Be(12);
        }

        [Test]
        public void Get_the_first_fibonacci_with_2_digits()
        {
            var number = problem.LocateFirstFibonacciWithNumberGreaterThan(10);

            number.Should().Be(8);
        }

        [Test]
        public void Get_the_first_fibonacci_with_over_10_digits()
        {
            var number = problem.LocateFirstFibonacciWithNumberGreaterThan(BigInteger.Pow(10, 9));

            number.Should().BeGreaterOrEqualTo(46);

            Console.WriteLine(number);
        }

        [Test]
        public void Get_the_first_fibonacci_with_over_1000_digits()
        {
            var bigInteger = BigInteger.Pow(10, 999);
            var number = problem.LocateFirstFibonacciWithNumberGreaterThan(bigInteger);

            Console.WriteLine(number);
        }
    }
}
