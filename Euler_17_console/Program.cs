using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Euler_17;

namespace Euler_17_console
{
	class Program
	{
		static void Main(string[] args)
		{
			Problem p = new Problem();
			var listOfWords = new List<string>();
			for (int i = 1; i <= 1000; i++)
			{
				var wordForNumber = p.GetWordForNumber(i);
				Console.WriteLine(wordForNumber);
				listOfWords.Add(wordForNumber);
			}
			var b = new StringBuilder();
			foreach (var words in listOfWords.ToArray().Select(x => x.Replace(" ", string.Empty)))
			{
				b.Append(words);
			}
			BigInteger result = 0;
			foreach (char c in b.ToString())
			{
				result++;
			}
			Console.WriteLine("finished; found {0} letters", result);
			Console.ReadKey();
		}
	}
}
