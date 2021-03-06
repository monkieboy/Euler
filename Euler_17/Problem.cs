﻿using System.Collections.Generic;
using System.Linq;

namespace Euler_17
{
	public class Problem
	{
		public string GetWordForNumber(int number)
		{
			return Change.ToString(number);
		}
	}

	public class Change
	{
		public static string ToString(int number)
		{
			return number.Convert();
		}
	}

	public static class ChangeExtensions
	{
		private static readonly Dictionary<int, string> NumberWords = new Dictionary<int, string>
                                                                 {
                                                                     {1, "one "},
                                                                     {2, "two "},
                                                                     {3, "three "},
                                                                     {4, "four "},
                                                                     {5, "five "},
                                                                     {6, "six "},
                                                                     {7, "seven "},
                                                                     {8, "eight "},
                                                                     {9, "nine "},
                                                                     {10, "ten "},
                                                                     {11, "eleven "},
                                                                     {12, "twelve "},
                                                                     {13, "thirteen "},
                                                                     {14, "fourteen "},
                                                                     {15, "fifteen "},
                                                                     {16, "sixteen "},
                                                                     {17, "seventeen "},
                                                                     {18, "eighteen "},
                                                                     {19, "nineteen "},
                                                                     {20, "twenty "},
                                                                     {30, "thirty "},
                                                                     {40, "forty "},
                                                                     {50, "fifty "},
                                                                     {60, "sixty "},
                                                                     {70, "seventy "},
                                                                     {80, "eighty "},
                                                                     {90, "ninety "},
                                                                     {100, "hundred "},
                                                                     {1000, "thousand "},
                                                                 };

		public static string Convert(this int number)
		{
			if (number == 0)
			{
				return "zero";
			}

			string result = string.Empty;
			int iteration = 0;
			while (number >= 1)
			{
				//Figure out the current number

				// 16/5 = 3 r 1
				var tenth = number % 10;
				number /= 10;
				if (tenth != 0)
				{
					if (iteration == 1 && tenth > 1)
					{
						result = NumberWords[tenth * 10] + result;
					}
					else if (iteration == 1 && tenth <= 1)
					{
						var numberWord = result.Length > 0
							? NumberWords[tenth * 10 + NumberWords.Keys.ToArray().Select(x => x).Single(x => NumberWords[x] == result)]
							: "ten";
						result = numberWord;
					}
					else
					{
						result = Result(iteration, tenth, result);
					}
				}

				//if (iteration)

				iteration++;
			}
			return result.TrimEnd(new[] { ' ' });
		}

		private static string Result(int iteration, int tenth, string result)
		{
			if (iteration == 3 && tenth > 0 && result.Length > 0)
			{
				result = "thousand and " + result;
			}
			else if (iteration == 3 && tenth == 0 && result.Length > 0)
			{
				result = "and " + result;
			}
			else if (iteration == 3 && tenth != 0)
			{
				result = "thousand " + result;
			}

			if (iteration == 2 && tenth > 0 && result.Length > 0)
			{
				result = "hundred and " + result;
			}
			else if (iteration == 2 && tenth == 0)
			{
				result = "and " + result;
			}
			else if (iteration == 2 && tenth != 0)
			{
				result = "hundred " + result;
			}
			result = NumberWords[tenth] + result;
			return result;
		}
	}
}
