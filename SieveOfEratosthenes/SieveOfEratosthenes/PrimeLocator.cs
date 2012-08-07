using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SieveOfEratosthenes
{
	public class PrimeLocator
	{
		private readonly long limit;
		public IList<int> ListOfPrimesForLimit = new List<int> { 2 };
		private readonly IDictionary<int, bool> checkedNumbers = new Dictionary<int, bool>();
		private bool sievingStarted;

		public PrimeLocator(long limit)
		{
			this.limit = limit;

			for (var i = 2; i < limit; i++)
			{
				checkedNumbers.Add(i, false);
			}
		}


		public void GenerateListOfPrimesForLimit()
		{
			var currentPrime = !sievingStarted 
				? new Func<int>(() => { sievingStarted = true; return 2; }).Invoke() 
				: checkedNumbers.First(x => !x.Value).Key;
			var checker = currentPrime;
			while (checker < limit)
			{
				for (var i = currentPrime; i < limit; i += currentPrime)
				{
					if (i % currentPrime == 0)
					{
						checkedNumbers[i] = true;
					}
				}
				var item = checkedNumbers.FirstOrDefault(x => !x.Value).Key;
				if (item == 0) { break; }
				ListOfPrimesForLimit.Add(item);
				currentPrime = ListOfPrimesForLimit.Max();
				checker++;
			}
		}
	}
}
