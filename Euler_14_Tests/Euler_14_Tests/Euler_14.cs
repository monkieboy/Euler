using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Euler_14_Tests
{
    [TestFixture]
    public class Euler_14
    {
        /*
            n  n/2 (n is even)
            n  3n + 1 (n is odd)
         */

        [Test]
        public void Starting_with_13_should_generate_10_terms()
        {
            //GenerateTermsForSeed(13).Count().Should().Be(10);
        }

        [Test]
        public void Should_return_50_terms()
        {
            var i = 1;
            var termsFound = 0;
            while (termsFound != 50 && i < 1000000)
            {
                //termsFound = GenerateTermsForSeed(i).Count();
                i++;
            }

            Console.WriteLine(i--);
        }

        [Test]
        public void Should_return_500_terms()
        {
            var i = 992166;
            var termsFoundForPass = 0;
            var terms = new List<int>();
            while (termsFoundForPass != 50000)
            {
                termsFoundForPass = GenerateTermsForSeed(i, terms).Count();
                i++;
            }

            Console.WriteLine(i--);
        }

        private static IEnumerable<int> GenerateTermsForSeed(int seed, IList<int> terms)
        {
            if (!terms.Contains(seed))
            {
                terms.Add(seed);
            }

            var current = seed;
            while (current != 1)
            {
                if (current < 0)
                {
                    break;
                }
                // 256 128 64 32 16 8 4 2 1
                if (current % 2 == 0)
                {
                    current = current / 2;
                }
                else
                {
                    current = (3 * current) + 1;
                }
                if (terms.Contains(current)) break;
                terms.Add(current);
            }

            return terms;
        }

        //private static IEnumerable<int> GenerateTermsForSeed(int seed)
        //{
        //    var terms = new List<int>();
        //    terms.Add(seed);

        //    var current = seed;
        //    while (current != 1)
        //    {
        //        if (current % 2 == 0)
        //        {
        //            current = current / 2;
        //        }
        //        else
        //        {
        //            current = (3 * current) + 1;
        //        }
        //        terms.Add(current);
        //    }

        //    return terms;
        //}
    }
}
