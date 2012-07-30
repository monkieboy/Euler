using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var eligibleValues = new List<int>();
			int previous = 1;
			int current = 1;
			int next = 2;

			do
			{
				
				if ( current % 2 == 0)
				{
					eligibleValues.Add(current);
				}
				next = previous + current;
				previous = current;
				current = next;

			} while (current < 4000000);


			int result = 0;
			foreach (var eligibleValue in eligibleValues)
			{
				result += eligibleValue;
			}

			Console.ReadKey();
		}
	}
}
