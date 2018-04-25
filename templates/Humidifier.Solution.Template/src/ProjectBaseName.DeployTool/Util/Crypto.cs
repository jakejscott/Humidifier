using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ProjectBaseName.DeployTool.Util
{
    public static class Crypto
    {
        public static void FileEncrypt(string inputFile, string outputFile, string password)
        {
            byte[] salt = GenerateRandomSalt();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (var fsCrypt = new FileStream(outputFile, FileMode.Create))
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;

                    using (var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000))
                    {
                        aes.Key = key.GetBytes(aes.KeySize / 8);
                        aes.IV = key.GetBytes(aes.BlockSize / 8);
                        aes.Mode = CipherMode.CBC;

                        fsCrypt.Write(salt, 0, salt.Length);

                        using (var cs = new CryptoStream(fsCrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (var fsIn = new FileStream(inputFile, FileMode.Open))
                            {
                                byte[] buffer = new byte[1048576];
                                int read;
                                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cs.Write(buffer, 0, read);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            using (var fsCrypt = new FileStream(inputFile, FileMode.Open))
            {
                fsCrypt.Read(salt, 0, salt.Length);

                using (var aes = new RijndaelManaged())
                {
                    using (var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000))
                    {
                        aes.KeySize = 256;
                        aes.BlockSize = 128;
                        aes.Key = key.GetBytes(aes.KeySize / 8);
                        aes.IV = key.GetBytes(aes.BlockSize / 8);

                        aes.Padding = PaddingMode.PKCS7;
                        aes.Mode = CipherMode.CBC;

                        using (var cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (var fsOut = new FileStream(outputFile, FileMode.Create))
                            {
                                int read;
                                byte[] buffer = new byte[1048576];
                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }
            return data;
        }
    }
}