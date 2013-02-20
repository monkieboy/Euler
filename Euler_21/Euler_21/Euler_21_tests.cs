using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using System.Linq;

namespace Euler_21
{
    [TestFixture]
    public class Euler_21_tests
    {
        private IDictionary<int, string> file = new Dictionary<int, string>();

        [SetUp]
        public void RunThisForAll()
        {
            var pathToNames = @"C:\dev\Euler\Euler_21\Euler_21\names.txt";
            using (var file = new StreamReader(pathToNames))
            {
                var strings = file.ReadToEnd().Split(new[] { "," }, StringSplitOptions.None).ToList();
                strings.Sort();
                this.file = Enumerable.Range(0, strings.Count)
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
        public void VerifyGivenAnswerForCOLIN()
        {
            Console.WriteLine(file[938-1]);
        }
    }
}
