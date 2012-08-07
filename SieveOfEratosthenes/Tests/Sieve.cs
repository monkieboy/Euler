using FluentAssertions;
using NUnit.Framework;
using SieveOfEratosthenes;

namespace Tests
{
	[TestFixture]
	public class Sieve
	{
		[Test]
		public void Should_return_2_3_when_limit_is_up_to_but_not_including_5()
		{
			var p = new PrimeLocator(5);
			p.GenerateListOfPrimesForLimit();
			p.ListOfPrimesForLimit.Should().Contain(new[] { 2, 3 });
		}


		[Test]
		public void Should_return_2_3_and_5_when_limit_is_up_to_but_not_including_7()
		{
			var p = new PrimeLocator(7);
			p.GenerateListOfPrimesForLimit();
			p.ListOfPrimesForLimit.Should().BeEquivalentTo(2, 3, 5);
		}


	}
}
