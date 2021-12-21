using Blockchain.Domain;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Blockchain.Service
{
    public class HashService
    {
        public HashService()
        {
        }

        public static string Compute(Block block)
        {
            var value = JsonSerializer.Serialize(block);

            using (var hash = SHA256.Create())
            {
                var bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(value));

                var stringBuilder = new StringBuilder();
                for (var i = 0; i < bytes.Length; i++)
                    stringBuilder.Append(bytes[i].ToString("x2"));

                var result = stringBuilder.ToString();

                return result;
            }
        }

        public static string Compute(string value)
        {
            using (var hash = SHA256.Create())
            {
                var bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(value));

                var stringBuilder = new StringBuilder();
                for (var i = 0; i < bytes.Length; i++)
                    stringBuilder.Append(bytes[i].ToString("x2"));

                var result = stringBuilder.ToString();

                return result;
            }
        }
    }
}
