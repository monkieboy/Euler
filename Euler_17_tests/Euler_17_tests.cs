using Euler_17;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_17_tests
{
    [TestFixture]
    public class Euler_17_tests
    {
        [Test]
        public void Should_return_the_word_one_when_supplied_with_1()
        {
            var p = new Problem();

            p.GetWordForNumber(1).Should().Be("one");
        }

        [Test]
        public void Should_return_the_words_one_hundred_and_one_when_supplied_with_101()
        {
            var p = new Problem();

            p.GetWordForNumber(101).Should().Be("one hundred and one");
        }
        [Test]
        public void Should_return_the_words_two_hundred_and_one_when_supplied_with_201()
        {
            var p = new Problem();

            p.GetWordForNumber(201).Should().Be("two hundred and one");
        }
        [Test]
        public void Should_return_the_words_three_hundred_and_fifty_four_when_supplied_with_354()
        {
            var p = new Problem();

            p.GetWordForNumber(354).Should().Be("three hundred and fifty four");
        }
        [Test]
        public void Should_return_the_words_one_thousand_three_hundred_and_fifty_four_when_supplied_with_1354()
        {
            var p = new Problem();

            p.GetWordForNumber(1354).Should().Be("one thousand three hundred and fifty four");
        }
    }
}
