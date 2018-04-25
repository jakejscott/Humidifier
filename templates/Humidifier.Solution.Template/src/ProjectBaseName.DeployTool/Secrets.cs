using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using ProjectBaseName.DeployTool.Util;
using Serilog;

namespace ProjectBaseName.DeployTool
{
    public static class Secrets
    {
        public static async Task<bool> Upload(ILogger log, Context context)
        {
            log.Information("Uploading secrets");
            await Task.CompletedTask;
            return true;
        }

        static async Task PutParameterAsync(IAmazonSimpleSystemsManagement ssm, string name, string value)
        {
            var request = new PutParameterRequest
            {
                Name = name,
                Value = value,
                Type = ParameterType.SecureString,
                Overwrite = true
            };
            await ssm.PutParameterAsync(request).ConfigureAwait(false);
        }

        public static async Task<bool> Encrypt(ILogger log, Context context)
        {
            await Task.CompletedTask;

            var path = Path.Combine(context.Config.BuildPath, "secrets");

            var file = Directory.GetFiles(path, $".{context.Config.Env}.secret", SearchOption.TopDirectoryOnly).FirstOrDefault();
            if (file == null)
            {
                log.Error("Secret file already encrypted");
                return false;
            }

            log.Information("Enter password to encrypt the file:");
            var password = GetConsolePassword();
            if (string.IsNullOrWhiteSpace(password))
            {
                log.Error("Password cannot be empty");
                return false;
            }

            log.Information("Encrypting: {file}", file);
            var dest = file + ".aes";
            Crypto.FileEncrypt(file, dest, password);
            File.Delete(file);

            return true;
        }

        public static async Task<bool> Decrypt(ILogger log, Context context)
        {
            await Task.CompletedTask;

            var path = Path.Combine(context.Config.BuildPath, "secrets");
            var file = Directory.GetFiles(path, $".{context.Config.Env}.secret.aes", SearchOption.TopDirectoryOnly).FirstOrDefault();
            if (file == null)
            {
                log.Error("Secret file already decrypted");
                return false;
            }

            log.Information("Enter password to decrypt the file:");
            var password = GetConsolePassword();

            log.Information("Decrypting: {file}", file);
            var dest = file.Replace(".aes", "");
            try
            {
                Crypto.FileDecrypt(file, dest, password);
            }
            catch
            {
                log.Error("Unable to decrypt file");
                if (File.Exists(dest)) File.Delete(dest);
                return false;
            }

            File.Delete(file);
            return true;
        }

        private static string GetConsolePassword()
        {
            var sb = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        sb.Length--;
                    }

                    continue;
                }

                Console.Write('*');
                sb.Append(cki.KeyChar);
            }

            return sb.ToString();
        }
    }
}