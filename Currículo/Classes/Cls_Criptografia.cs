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
        public string Encriptar(string texto, string senha)
        {
            byte[] data = Encoding.UTF8.GetBytes(texto);
            byte[] iv = new byte[8];
            new RNGCryptoServiceProvider().GetBytes(iv);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

                using (var tripleDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, IV = iv })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] finalBlock = transform.TransformFinalBlock(data, 0, data.Length);
                    byte[] results = new byte[iv.Length + finalBlock.Length];
                    Array.Copy(iv, results, iv.Length);
                    Array.Copy(finalBlock, 0, results, iv.Length, finalBlock.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public string Decriptar(string texto, string senha)
        {
            byte[] data = Convert.FromBase64String(texto);
            byte[] iv = new byte[8];
            byte[] cipherText = new byte[data.Length - iv.Length];

            
            Array.Copy(data, iv, iv.Length);
            Array.Copy(data, iv.Length, cipherText, 0, cipherText.Length);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

                using (var tripleDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7, IV = iv })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(cipherText, 0, cipherText.Length);

                    return Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
