using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Diagnostics;

namespace Euler_11_Test
{
	[TestFixture]
	public class QuadChecker
	{
		#region globals
		static string sample =
@"08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";

		//@"04 56 94 33 05 62 22 10 17 38 21 20 13 74 29 42 14 66 94 32
		//05 62 21 10 16 36 21 20 16 44 28 41 04 54 94 33 03 62 22 10
		//16 36 24 20 17 74 29 41 05 56 98 33 05 65 22 10 14 36 21 20
		//17 74 29 41 04 26 94 33 04 62 28 10 16 36 21 20 15 74 29 41
		//04 56 94 33 05 82 22 10 13 36 28 20 17 77 29 41 06 56 94 33
		//05 62 25 10 16 16 21 20 12 74 28 41 04 58 94 33 07 62 22 10
		//16 36 26 20 17 94 29 20 21 10 18 36 17 79 29 41 28 20 17 74
		//04 26 94 33 04 62 28 10 16 36 21 20 12 18 36 17 79 29 54 45";

		int startXPosition = 0;
		int startYPosition = 0;

		string[] sampleArray = sample.Split(new[] { "\r\n" }, StringSplitOptions.None);
		#endregion

		#region BackwardDiagonals
		[Test]
		public void CheckBackwardDiagonal()
		{
			int startXPosition = 3;
			var result = CalculateBackwardDiagonalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 424116);
		}
		[Test]
		public void CheckBackwardDiagonalPlusOne()
		{
			int startXPosition = 1;

			var result = CalculateBackwardDiagonalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(-1, result);
		}

		private int CalculateBackwardDiagonalQuad(string sample, int startXPosition, int startYPosition)
		{
			if (startXPosition < 3)
			{
				return -1;
			}
			var iterator = 0;
			var result = 1;
			var arr1 = sampleArray[startYPosition].Split(new[] { " " }, StringSplitOptions.None);
			var arr2 = sampleArray[startYPosition + 1].Split(new[] { " " }, StringSplitOptions.None);
			var arr3 = sampleArray[startYPosition + 2].Split(new[] { " " }, StringSplitOptions.None);
			var arr4 = sampleArray[startYPosition + 3].Split(new[] { " " }, StringSplitOptions.None);
			result *=
				(Convert.ToInt32(arr1[startXPosition])
				* Convert.ToInt32(arr2[startXPosition - 1])
				* Convert.ToInt32(arr3[startXPosition - 2])
				* Convert.ToInt32(arr4[startXPosition - 3]));

			return result;
		}
		#endregion

		#region Diagonals
		[Test]
		public void PrescribedResult()
		{
			var result = CalculateDiagonalQuad(sample, 8, 6);

			Assert.AreEqual(1788696, result);
		}

		[Test]
		public void CheckDiagonal()
		{
			var result = CalculateDiagonalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 244032);
		}
		[Test]
		public void CheckDiagonalPlusOne()
		{
			int startXPosition = 1;

			var result = CalculateDiagonalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 94080);
		}

		private int CalculateDiagonalQuad(string sample, int startXPosition, int startYPosition)
		{
			if (startXPosition > 15)
			{
				return -1;
			}
			var iterator = 0;
			var result = 1;
			var arr1 = sampleArray[startYPosition].Split(new[] { " " }, StringSplitOptions.None);
			var arr2 = sampleArray[startYPosition + 1].Split(new[] { " " }, StringSplitOptions.None);
			var arr3 = sampleArray[startYPosition + 2].Split(new[] { " " }, StringSplitOptions.None);
			var arr4 = sampleArray[startYPosition + 3].Split(new[] { " " }, StringSplitOptions.None);
			result *=
				(Convert.ToInt32(arr1[startXPosition])
				* Convert.ToInt32(arr2[startXPosition + 1])
				* Convert.ToInt32(arr3[startXPosition + 2])
				* Convert.ToInt32(arr4[startXPosition + 3]));

			return result;
		}
		#endregion

		#region Verticals
		[Test]
		public void CheckVertical()
		{
			var result = CalculateVerticalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 5440);
		}

		[Test]
		public void CheckVerticalPlusOne()
		{
			int startXPosition = 1;

			var result = CalculateVerticalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 9249408);
		}

		[Test]
		public void CheckVerticalPlus16()
		{
			int startXPosition = 16;

			var result = CalculateVerticalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(result, 8820);
		}

		private int CalculateVerticalQuad(string sample, int startXPosition, int startYPosition)
		{
			var iterator = 0;
			var result = 1;
			var span = 20;

			var arr1 = sampleArray[startYPosition].Split(new[] { " " }, StringSplitOptions.None);
			var arr2 = sampleArray[startYPosition + 1].Split(new[] { " " }, StringSplitOptions.None);
			var arr3 = sampleArray[startYPosition + 2].Split(new[] { " " }, StringSplitOptions.None);
			var arr4 = sampleArray[startYPosition + 3].Split(new[] { " " }, StringSplitOptions.None);
			result *=
				(Convert.ToInt32(arr1[startXPosition])
				* Convert.ToInt32(arr2[startXPosition])
				* Convert.ToInt32(arr3[startXPosition])
				* Convert.ToInt32(arr4[startXPosition]));

			return result;
		}
		#endregion

		#region Horizontals
		[Test]
		public void CheckHorizontal()
		{
			var result = CalculateHorizontalQuad(sample, startXPosition, startYPosition);
			Assert.AreEqual(694848, result);
		}

		[Test]
		public void CheckHorizontalPlusOne()
		{
			int startXPosition = 1;
			var result = CalculateHorizontalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(868560, result);
		}

		[Test]
		public void CheckHorizontalPlus16()
		{
			int startXPosition = 16;
			var result = CalculateHorizontalQuad(sample, startXPosition, startYPosition);

			Assert.AreEqual(-1, result);
		}

		private int CalculateHorizontalQuad(string sample, int startXPosition, int startYPosition)
		{
			if (startXPosition > 15)
			{
				return -1;
			}
			var result = 1;
			var arr = sampleArray[startYPosition].Split(new [] { " " }, StringSplitOptions.None);
			for (var i = 0; i < 4; i++)
			{
				result *= Convert.ToInt32(arr[startXPosition + i]);
			}

			return result;
		}
		#endregion
	}
}
