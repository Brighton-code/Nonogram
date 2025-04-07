using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nonogram.Models
{
    public class User
    {
        private const int _keySize = 64;
        private const int _iterations = 350000;
        private static readonly HashAlgorithmName s_hashAlgorithm = HashAlgorithmName.SHA512;

        public string Name { get; private set; }
        public DPassword Password { get; private set; }
        public List<GameHistory> History { get; private set; } = [];

        [JsonConstructor]
        public User(string name, DPassword password, List<GameHistory> history)
        {
            Name = name;
            Password = password;
            History = history ?? [];
        }

        // https://code-maze.com/csharp-hashing-salting-passwords-best-practices/
        public static DPassword HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(_keySize); 

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                _iterations,
                s_hashAlgorithm,
                _keySize
            );

            return new DPassword(Convert.ToBase64String(hash), Convert.ToBase64String(salt));
        }

        public static bool VerifyPassword(string password, DPassword dPassword)
        {
            byte[] hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                password,
                Convert.FromBase64String(dPassword.Salt),
                _iterations,
                s_hashAlgorithm,
                _keySize
            );

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromBase64String(dPassword.Hash));
        }
    }
}
