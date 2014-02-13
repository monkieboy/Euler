using NUnit.Framework;

namespace EulerProblem59.Tests
{
    public class WhenEncryptingUsingXor
    {
        private readonly Xor encryptor = new Xor();

        [Test]
        public void Should_EncryptUsingStripe()
        {
            const string statement = "k";
            var stripe = new[]{'A'};
            var result = encryptor.Encrypt(statement, stripe);

            Assert.That(result, Is.EqualTo("*"));
        }

        [Test]
        public void Should_DecryptUsingStripe()
        {
            const string statement = "*";
            var stripe = new[] {'A'};
            var result = encryptor.Decrypt(statement, stripe);

            Assert.That(result, Is.EqualTo("k"));
        }

        [Test]
        public void Should_DecryptALongStringWithLongStripe()
        {
            const string statement = "The quick brown fox";
            var stripe = new[] {'a', 'b', 'c'};

            var decrypted = encryptor.Decrypt(encryptor.Encrypt(statement, stripe), stripe);

            Assert.AreEqual(decrypted, statement);
        }
    }
}
