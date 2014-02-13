using System;
using System.IO;
using System.Linq;

namespace EulerProblem59.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const char a = ((char) 'a');
            const int z = a + 26;
            var xor = new Xor();
            const string statement = "5\nA\b\bA\0\rA\f";
            var cipherTxt = string.Concat(File
                                              .ReadAllText(@"C:\dev\Kata\Euler\EulerProblem59.App\cipher1.txt")
                                              .Split(new[] {","}, StringSplitOptions.None)
                                              .Select(x => Convert.ToString((char)Convert.ToInt32(x))));
            bool matchFound = false;
            for (var i = a; i < z; i++)
            {
                for (var j = a; j < z; j++)
                {
                    for (var k = a; k < z; k++)
                    {
                        var result = xor.Decrypt(cipherTxt, new[] { i, j, k });
                        if (!result.ToLower().Contains("there")) continue;
                        var sum = result.ToCharArray().Sum(x => (int) x);
                        Console.WriteLine("The key is: {0}{1}{2}", i, j, k);
                        Console.WriteLine("The sum of the ascii values are: {0}", sum);
                        Console.WriteLine("The text is as follows:\r\n\r\n{0}\r\n\r\n", result);
                        matchFound = true;
                        break;
                    }
                }
            }
            Console.WriteLine(matchFound ? "Finished." : "No match found.");
            Console.ReadKey();
        }
    }
}
