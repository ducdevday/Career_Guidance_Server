using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Shared.Util
{
    public class SecretUtil
    {
        public static byte[] HashPassword(string value)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(value);
            byte[] hashedBytes = Encoding.UTF8.GetBytes(hashedPassword);
            return hashedBytes;
        }


        public static bool ValidatePassword(string raw, byte[] hashedBytes)
        {
            string hashedPassword = Encoding.UTF8.GetString(hashedBytes);
            return BCrypt.Net.BCrypt.Verify(raw, hashedPassword);
        }

        public static string HashToken(string token)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(token));
            return Convert.ToBase64String(bytes);
        }
    }
}
