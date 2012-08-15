using System;
using System.Linq;
using System.Numerics;

namespace Euler_16
{
	class Program
	{
		static void Main(string[] args)
		{
			new Action(() =>
			{
				Console.WriteLine(BigInteger
					.Pow(2, 1000)
					.ToString()
					.Aggregate<char, double>(0, (current1, c) => current1 + (int)Char.GetNumericValue(c)));
				Console.ReadKey();
			}).Invoke();
		}
	}
}
