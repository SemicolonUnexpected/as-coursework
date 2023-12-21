using System.Text;
using System.Security.Cryptography;

namespace AS_Coursework.Model.Security;
internal static class HashManager {

    private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;
    private const int ITERATIONS = 100000;
    private const int SIZE = 64;

    public static byte[] GetHash(string text, out byte[] salt) {
        salt = RandomNumberGenerator.GetBytes(SIZE);
        byte[] textBytes = Encoding.UTF8.GetBytes(text);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(textBytes, salt, ITERATIONS, _hashAlgorithm, SIZE);

        return hash;
    }

    public static bool VerifyHashEquality(string text, byte[] hash, byte[] salt) {
        byte[] textBytes = Encoding.UTF8.GetBytes(text);

        byte[] hashedText = Rfc2898DeriveBytes.Pbkdf2(textBytes, salt, ITERATIONS, _hashAlgorithm, SIZE);

        return CryptographicOperations.FixedTimeEquals(hash, hashedText);
    }
}
