using System.Numerics;

namespace Euler_28
{
    public class Problem
    {
        public BigInteger EvaluateGrid(long gridSize)
        {
            return Evaluate(gridSize);
        }

        private BigInteger Evaluate(long gridSize)
        {
            var positiveXy = CalculateSquares(gridSize);
            var negativeXy = CalculateDiagonal(gridSize, Direction.BottomLeft);
            var positiveXNegativeY = CalculateDiagonal(gridSize, Direction.BottomRight);
            var negativeXPositiveY = CalculateDiagonal(gridSize, Direction.TopLeft);

            return negativeXy + positiveXy + negativeXPositiveY + positiveXNegativeY;
        }

        private BigInteger CalculateSquares(long gridSize)
        {
            var result = new BigInteger(0);
            for (var i = 1; i < gridSize; i += 2)
            {
                result += BigInteger.Pow(i + 2, 2);
            }
            return result;
        }

        private BigInteger CalculateDiagonal(long gridSize, Direction direction)
        {
            var current = 0;
            var temp = 0;
            var seed = 0;
            switch (direction)
            {
                case Direction.BottomRight:
                    current = 3;
                    temp = 10;
                    seed = 3;
                    break;
                case Direction.BottomLeft:
                    current = 5;
                    temp = 12;
                    seed = 6;
                    break;
                case Direction.TopLeft:
                    current = 7;
                    temp = 14;
                    seed = 7;
                    break;
            }

            var result = CalculateResult(gridSize, temp, seed, current);

            return result;
        }

        private BigInteger CalculateResult(long gridSize, BigInteger temp, BigInteger seed, BigInteger current)
        {
            for (var i = 1; i < gridSize/2; i++)
            {
                var next = current + temp;

                temp += 8;

                current = next;

                seed += current;
            }
            return seed;
        }
    }

    public enum Direction
    {
        BottomRight = 3,
        BottomLeft = 5,
        TopLeft = 7
    }
}
