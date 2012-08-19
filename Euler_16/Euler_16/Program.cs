using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Euler_16
{
	class Program
	{
		static void Main(string[] args)
		{

			new EulerProcessor().DoIt(() => BigInteger
												.Pow(2, 1000)
												.ToString()
												.Aggregate(0,
															(total, next) => total + (int)Char.GetNumericValue(next)));

			new EulerProcessor().DoIt(() =>
										{
											var result = 0;

											var number = BigInteger.Pow(2, 1000);

											while (number > 0)
											{
												result += (int)(number % 10);
												number /= 10;
											}

											return result;
										});

			new EulerProcessor().DoIt(() =>
			{
				int sum = 0;

				int[] arr = new int[400];

				arr[0] = 2;
				int carry = 0;

				for (int j = 1; j < 1000; j++)
				{
					for (int i = 0; i < arr.Length; i++)
					{
						int tempno = arr[i] * 2;

						if (tempno > 9)
						{
							arr[i] = (tempno % 10) + carry;
							carry = 1;
						}
						else
						{
							arr[i] = tempno + carry;
							carry = 0;
						}
					}
				}

				for (int i = 0; i < arr.Length; i++)
				{
					sum += arr[i];
				}

				return sum;
			});
			Console.ReadKey();
		}
	}

	public class EulerProcessor
	{
		public void DoIt(Func<int> a)
		{
			var s = new Stopwatch();
			s.Start();
			var result = a();
			s.Stop();
			Console.WriteLine(string.Format("Answer is {0}\nIt took {1}", result, s.ElapsedMilliseconds));
		}
	}
}
