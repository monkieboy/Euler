using System;
using System.Diagnostics;
using System.Numerics;
using Euler_28;

namespace Euler_28_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            Console.WriteLine(new Problem().EvaluateGrid(1000));
            Console.WriteLine("Calculations took: {0}ms", s.ElapsedMilliseconds);
            s.Stop();
            Console.ReadKey();
        }
    }
}
