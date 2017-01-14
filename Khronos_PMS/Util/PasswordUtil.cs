using System;
using System.Security.Cryptography;

namespace Khronos_PMS.Util {
    class PasswordUtil {
        private static int iterations = 1000;
        private static int hashLength = 32;
        private static int saltLength = 16;

        private PasswordUtil() {
        }

        public static bool CheckPassword(String password, String hash) {
            byte[] hashBytes = Convert.FromBase64String(hash);
            byte[] salt = new byte[saltLength];
            byte[] oldHash = new byte[hashLength];

            Array.Copy(hashBytes, 0, salt, 0, saltLength);
            Array.Copy(hashBytes, saltLength, oldHash, 0, hashLength);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] newHash = pbkdf2.GetBytes(hashLength);

            for (int i = 0; i < hashLength; i++)
                if (oldHash[i] != newHash[i])
                    return false;

            return true;
        }

        public static String GenerateHash(String password) {
            byte[] hashBytes = new byte[saltLength + hashLength];
            byte[] salt = new byte[saltLength];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider()) {
                rngCsp.GetBytes(salt);
            }
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(hashLength);

            Array.Copy(salt, 0, hashBytes, 0, saltLength);
            Array.Copy(hash, 0, hashBytes, saltLength, hashLength);

            return Convert.ToBase64String(hashBytes);
        }
    }
}