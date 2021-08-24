using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HumanResourceSuite.Common.Framework
{
    /// <summary>
    ///  Handles Encryption/Decryption
    /// </summary>
    public class EncryptorDecryptor
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="securityKey"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        public static string EncryptData(string toEncrypt, string securityKey, bool useHashing = true)
        {
            if (string.IsNullOrWhiteSpace(toEncrypt)) return toEncrypt;

            byte[] keyArray = Encoding.UTF8.GetBytes(securityKey);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(keyArray);
                hashmd5.Clear();
            }

            var tdes = new TripleDESCryptoServiceProvider { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cipherString"></param>
        /// <param name="securityKey"></param>
        /// <param name="useHashing"></param>
        /// <returns></returns>
        public static string DecryptData(string cipherString, string securityKey, bool useHashing = true)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(securityKey);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(keyArray);
                hashmd5.Clear();
            }

            var tdes = new TripleDESCryptoServiceProvider { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
