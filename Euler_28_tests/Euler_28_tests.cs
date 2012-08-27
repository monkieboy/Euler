using System;
using Euler_28;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_28_tests
{
    [TestFixture]
    public class Euler_28_tests
    {
        private string SampleGrid = @"
73 74 75 76 77 78 79 80 81
72 43 44 45 46 47 48 49 50
71 42 21 22 23 24 25 26 51
70 41 20  7  8  9 10 27 52
69 40 19  6  1  2 11 28 53
68 39 18  5  4  3 12 29 54
67 38 17 16 15 14 13 30 55
66 37 36 35 34 33 32 31 56
65 64 63 62 61 60 59 58 57";

        [Test]
        public void Should_evaluate_full_diagonal_to_57()
        {
            var p = new Problem();

            var result = p.EvaluateGrid(5);

            Console.WriteLine(result);
            result.Should().Be(57);
        }

        [Test]
        public void Should_evaluate_to_143()
        {
            var p = new Problem();

            var result = p.EvaluateGrid(6);

            Console.WriteLine(result);
            result.Should().Be(143);
        }

    }
}
