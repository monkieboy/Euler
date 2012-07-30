using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_4
{
	class Program
	{
		static void Main(string[] args)
		{
			var first = 999;

			var result = new List<int>();
			do
			{
				var second = 999;
				do
				{
					var test = first * second;
					if (Test(test))
					{
						result.Add(test);
						break;
					}
					second--;

				} while (second > 99);
				first--;
			} while (first > 99);

			int checker = 0;
			foreach (var i in result)
			{
				if (i > checker)
				{
					checker = i;
				}
			}

			Console.WriteLine(checker);
			Console.ReadKey();
		}

		private static bool Test(int i)
		{
			//string str = string.Empty;
			//foreach (var ch in charArr)
			//{
			//    str += ch;
			//}

			//Console.WriteLine(Convert.ToInt32(str));
			return string.Join("", i.ToString().ToCharArray().Reverse()) == i.ToString();
		}
	}
}
