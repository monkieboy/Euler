using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProblem59
{
    public class Xor
    {
        public string Encrypt(string statement, char[] stripe)
        {
            var charArray = statement.ToCharArray();

            var encryptedValue = new StringBuilder();
            
            for (var i = 0; i < charArray.Length; i++)
            {
                encryptedValue.Append((char)(charArray[i] ^ GeneratePadding(stripe, i)));
            }

            return encryptedValue.ToString();
        }

        public string Decrypt(string statement, char[] stripe)
        {
            var charArray = statement.ToCharArray();

            var decryptedValue = new StringBuilder();
            
            for (var i = 0; i < charArray.Length; i++)
            {
                decryptedValue.Append((char) (charArray[i] ^ GeneratePadding(stripe, i)));
            }

            return decryptedValue.ToString();
        }

        private static char GeneratePadding(IList<char> stripe, int i)
        {
            var index = 0;
            var stripeLength = stripe.Count;
            if (stripeLength > 1)
            {
                var modulo = (i + 1) % stripeLength;
                index = (modulo == 0 ? stripeLength : modulo)-1;
            }
            var c = stripe[index];
            return c;
        }
    }
}
