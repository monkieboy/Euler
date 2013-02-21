using System;
using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace Euler_22
{
    [TestFixture]
    public class Euler22Tests
    {
        private IDictionary<int, string> file = new Dictionary<int, string>();

        [SetUp]
        public void RunThisForAll()
        {
            const string pathToNames = @"C:\dev\Euler\Euler_22\Euler_22\names.txt";
            using (var fileReader = new StreamReader(pathToNames))
            {
                var strings = fileReader
                    .ReadToEnd()
                    .Trim(new []{'"'})
                    .Split(new[] { "\",\"" }, StringSplitOptions.None)
                    .ToList();
                
                strings.Sort();
                
                file = Enumerable.Range(0, strings.Count)
                    .Select(i =>
                        new
                        {
                            Key = i,
                            Value = strings[i]
                        })
                    .ToDictionary(r => r.Key, r => r.Value);
            }
        }

        [Test]
        public void VerifyGivenAnswerForCOLIN_At938thPosition()
        {
            Console.WriteLine("There are {0} names",file.Count());
            var name = file[938 - 1];
            name.Should().Be("COLIN");
            Console.WriteLine("{0} is the 938th name", name);
        }

        [Test]
        public void VerifyScoreOf3ForC()
        {
            var characterValue = GetCharacterValue('C');
            characterValue.Should().Be(3);
            Console.WriteLine(characterValue);
        }

        [Test]
        public void VerifyValueOf15ForO()
        {
            var characterValue = GetCharacterValue('O');
            characterValue.Should().Be(15);
            Console.WriteLine(characterValue);
        }

        [Test]
        public void VerifyTotalValueOf53ForCOLIN()
        {
            var colin = file[938 - 1].ToCharArray();

            var totalValue = colin.Sum(c => GetCharacterValue(c));
            totalValue.Should().Be(53);
            Console.WriteLine(totalValue);
        }

        [Test]
        public void VerifyTotalScoreForCOLINOf49714()
        {
            const int position = 938;
            var colin = file[position-1].ToCharArray();
            var totalScore = position*colin.Sum(c => GetCharacterValue(c));
            totalScore.Should().Be(49714);
            Console.WriteLine(totalScore);
        }

        [Test]
        public void SolveEuler22()
        {
            var totalOfAllScores = 0;
            for (var position = 1; position < file.Count+1; position++)
            {
                var name = file[position-1].ToCharArray();
                totalOfAllScores += position*name.Sum(c => GetCharacterValue(c));
            }
            Console.WriteLine(totalOfAllScores);
        }
        
        private static int GetCharacterValue(char c)
        {
            return c-64;
        }
    }
}
