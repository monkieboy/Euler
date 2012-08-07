using System;
using SieveOfEratosthenes;

namespace SieveHarness
{
	class Program
	{
		static void Main(string[] args)
		{
			GeneratePrimesUpToButNotIncluding80();

			Console.ReadKey();
		}

		private static void GeneratePrimesUpToButNotIncluding80()
		{
			var p = new PrimeLocator(80);
			p.GenerateListOfPrimesForLimit();
			foreach (var prime in p.ListOfPrimesForLimit)
			{
				Console.WriteLine(prime);
			}
		}
	}
}
