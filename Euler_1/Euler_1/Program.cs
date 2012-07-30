using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var eligibleValue = new List<int>();
			for (int i = 1; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					eligibleValue.Add(i);
				}
			}

			var result = 0;
			foreach (var i in eligibleValue)
			{
				result += i;
			}

			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
