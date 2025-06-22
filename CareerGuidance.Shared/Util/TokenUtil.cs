using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Shared.Util
{
    public static class TokenUtil
    {
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateRandomCode(int length = 6)
        {
            var buffer = new byte[length];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);

            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                var index = buffer[i] % _chars.Length;
                result[i] = _chars[index];
            }

            return new string(result);
        }
    }
}
