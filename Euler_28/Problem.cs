using System;

namespace Euler_28
{
    public class Problem
    {
        public int EvaluateGrid(int gridSize)
        {
            var negativeXy = CalculateNegativeXY(gridSize);
            var positiveXy = CalculatePositiveXY(gridSize);
            return negativeXy+positiveXy;
        }

        private int CalculatePositiveXY(int gridSize)
        {
            var result = 0D;
            for (int i = 1; i < gridSize; i += 2)
            {
                result += Math.Pow(i + 2, 2);
            }
            return (int)result;
        }

        private static int CalculateNegativeXY(int gridSize)
        {
            var current = 5;
            var next = 0;
            var result = 6;
            var temp = 12;
            for (var i = 1; i < gridSize/2; i++)
            {
                next = current + temp;

                temp += 8;

                current = next;

                result += current;
            }
            return result;
        }
    }
}
