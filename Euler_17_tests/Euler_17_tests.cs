using Euler_17;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_17_tests
{
    [TestFixture]
    public class Euler_17_tests
    {
        [Test]
        public void Should_return_the_word_zero_when_supplied_with_0()
        {
            var p = new Problem();
            p.GetWordForNumber(0).Should().Be("zero");
        }

        [Test]
        public void Should_return_the_word_one_when_supplied_with_1()
        {
            var p = new Problem();
            p.GetWordForNumber(1).Should().Be("one");
        }

		[Test]
		public void Should_return_the_word_twenty_three_when_supplied_with_23()
		{
			var p = new Problem();
			p.GetWordForNumber(23).Should().Be("twenty three");
		}

		[Test]
		public void Should_return_the_word_nine_thousand_nine_hundred_and_ninety_nine_when_supplied_with_9999()
		{
			var p = new Problem();
			p.GetWordForNumber(9999).Should().Be("nine thousand nine hundred and ninety nine");
		}

		[Test]
		public void Should_return_the_word_ninety_nine_when_supplied_with_99()
		{
			var p = new Problem();
			p.GetWordForNumber(99).Should().Be("ninety nine");
		}

		[Test]
		public void Should_return_the_word_three_hundred_and_ninety_nine_when_supplied_with_399()
		{
			var p = new Problem();
			p.GetWordForNumber(399).Should().Be("three hundred and ninety nine");
		}

		[Test]
		public void Should_return_the_word_one_hundred_and_twenty_three_when_supplied_with_123()
		{
			var p = new Problem();
			p.GetWordForNumber(123).Should().Be("one hundred and twenty three");
		}

		[Test]
		public void Should_return_the_word_one_thousand_and_twenty_three_when_supplied_with_1023()
		{
			var p = new Problem();
			p.GetWordForNumber(1023).Should().Be("one thousand and twenty three");
		}

		[Test]
		public void Should_return_the_word_thirteen_when_supplied_with_13()
		{
			var p = new Problem();
			p.GetWordForNumber(13).Should().Be("thirteen");
		}

		[Test]
		public void Should_return_the_word_one_hundred_and_thirteen_when_supplied_with_113()
		{
			var p = new Problem();
			p.GetWordForNumber(113).Should().Be("one hundred and thirteen");
		}

		[Test]
		public void Should_return_the_word_one_thousand_and_thirteen_when_supplied_with_1013()
		{
			var p = new Problem();
			p.GetWordForNumber(1013).Should().Be("one thousand and thirteen");
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
