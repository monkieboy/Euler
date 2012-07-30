using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_11_Functions
{
	public class Quads
	{
		public int CalculateBackwardDiagonalQuad(string[] sampleArray, int startXPosition, int startYPosition)
		{
			if (startXPosition < 3 || startYPosition > sampleArray.Length - 4)
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

		public int CalculateDiagonalQuad(string[] sampleArray, int startXPosition, int startYPosition)
		{
			if (startXPosition > 15 || startYPosition > sampleArray.Length - 4)
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

		public int CalculateVerticalQuad(string[] sampleArray, int startXPosition, int startYPosition)
		{
			if (startYPosition > sampleArray.Length - 4)
			{
				return -1;
			}
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

		public int CalculateHorizontalQuad(string[] sampleArray, int startXPosition, int startYPosition)
		{
			if (startXPosition > 15)
			{
				return -1;
			}
			var result = 1;
			var arr = sampleArray[startYPosition].Split(new[] { " " }, StringSplitOptions.None);
			for (var i = 0; i < 4; i++)
			{
				result *= Convert.ToInt32(arr[startXPosition + i]);
			}

			return result;
		}
	}
}
