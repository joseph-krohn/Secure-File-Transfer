using System;
using System.IO;
using System.Security.Cryptography;

namespace SecureFileTransfer
{
    public static class Encryptor
    {
        private static readonly string key = "YourEncryptionKey123"; // Replace with a key of your choice (32 bytes for AES-256)

        public static byte[] EncryptFile(byte[] fileContent)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                aes.GenerateIV();

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(fileContent, 0, fileContent.Length);
                    }
                    return ms.ToArray();
                }
            }
        }

        public static byte[] DecryptFile(byte[] encryptedContent)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                using (var ms = new MemoryStream(encryptedContent))
                {
                    byte[] iv = new byte[16];
                    ms.Read(iv, 0, iv.Length);
                    aes.IV = iv;

                    using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var output = new MemoryStream())
                    {
                        cs.CopyTo(output);
                        return output.ToArray();
                    }
                }
            }
        }
    }
}
