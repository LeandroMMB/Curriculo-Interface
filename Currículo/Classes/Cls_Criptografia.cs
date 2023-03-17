using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Currículo.Classes
{
    public class Cls_Criptografia
    {
        readonly static string hash = "o1Q2ib*Dj4VEIvWWu";

        public static string EncriptarUsuario(string texto) //One-Way
        {
            byte[] data = Encoding.UTF8.GetBytes(texto);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripleDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] cipherText = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(cipherText, 0, cipherText.Length);
                }
            }
        }

        public static string EncriptarSenha(string texto, string hash)
        {
            byte[] data = Encoding.UTF8.GetBytes(texto);
            byte[] iv = new byte[8];
            new RNGCryptoServiceProvider().GetBytes(iv);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripleDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, IV = iv }) //CipherMode.CBC, IV = iv
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] cipherText = transform.TransformFinalBlock(data, 0, data.Length);
                    byte[] results = new byte[iv.Length + cipherText.Length];
                    Array.Copy(iv, results, iv.Length);
                    Array.Copy(cipherText, 0, results, iv.Length, cipherText.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string DecriptarSenha(string texto, string hash)
        {
            byte[] data = Convert.FromBase64String(texto);
            byte[] iv = new byte[8];
            byte[] cipherText = new byte[data.Length - iv.Length];

            Array.Copy(data, iv, iv.Length);
            Array.Copy(data, iv.Length, cipherText, 0, cipherText.Length);

            try
            {
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                    using (var tripleDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, IV = iv }) //CipherMode.CBC, IV = iv
                    {
                        ICryptoTransform transform = tripleDES.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(cipherText, 0, cipherText.Length);

                        return Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch (CryptographicException)
            {
                return "false";
            }
        }
    }
}
