using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace KinoProjektNikolaTrogrlic.Classes
{
    public class EncryptionManager
    {
        public static byte[] EncryptString(string toEncrypt, string encryptionKey)
        {
            if (string.IsNullOrEmpty(toEncrypt)) throw new ArgumentException("toEncrypt");
            if (encryptionKey == null || encryptionKey.Length == 0) throw new ArgumentException("encryptionKey");
            var toEncryptBytes = Encoding.UTF8.GetBytes(toEncrypt);
            encryptionKey = ComputeMd5Hash(encryptionKey);
            var encryptionKeyBytes = Encoding.UTF8.GetBytes(encryptionKey);
            using (var provider = new AesCryptoServiceProvider())
            {
                provider.Key = encryptionKeyBytes;
                provider.Mode = CipherMode.CBC;
                provider.Padding = PaddingMode.PKCS7;
                using (var encryptor = provider.CreateEncryptor(provider.Key, provider.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(provider.IV, 0, 16);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(toEncryptBytes, 0, toEncryptBytes.Length);
                            cs.FlushFinalBlock();
                        }
                        return ms.ToArray();
                    }
                }
            }
        }

        public static string DecryptString(byte[] encryptedString, string encryptionKey)
        {
            using (var provider = new AesCryptoServiceProvider())
            {
                encryptionKey = ComputeMd5Hash(encryptionKey);
                var encryptionKeyBytes = Encoding.UTF8.GetBytes(encryptionKey);
                try
                {
                    provider.Key = encryptionKeyBytes;
                    provider.Mode = CipherMode.CBC;
                    provider.Padding = PaddingMode.PKCS7;
                    using (var ms = new MemoryStream(encryptedString))
                    {
                        byte[] buffer = new byte[16];
                        ms.Read(buffer, 0, 16);
                        provider.IV = buffer;
                        using (var decryptor = provider.CreateDecryptor(provider.Key, provider.IV))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {

                                byte[] decrypted = new byte[encryptedString.Length];
                                var byteCount = cs.Read(decrypted, 0, encryptedString.Length);
                                return Encoding.UTF8.GetString(decrypted, 0, byteCount);

                            }
                        }
                    }
                }
                catch
                {
                    return "Bad key";
                }
            }
        }

        public static string ComputeMd5Hash(string message)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.ASCII.GetBytes(message);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static byte[] CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return buff;
        }

        public static byte[] GenerateSaltedHash(string plainText,byte[] salt)
        {
            byte[] byteplaintext = Encoding.ASCII.GetBytes(plainText);
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[byteplaintext.Length + salt.Length];

            for (int i = 0; i < byteplaintext.Length; i++)
            {
                plainTextWithSaltBytes[i] = byteplaintext[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[byteplaintext.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static bool CheckHashMatch(string storedHash, string enteredText,string salt)
        {
            try
            {
                byte[] array1 = Convert.FromBase64String(storedHash);
                byte[] array2 = GenerateSaltedHash(enteredText, Convert.FromBase64String(salt));
                if (array1.Length != array2.Length)
                {
                    return false;
                }

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void SignXml(XmlDocument xmlDoc, RSA rsaKey)
        {
            if (xmlDoc == null)
                throw new ArgumentException(nameof(xmlDoc));
            if (rsaKey == null)
                throw new ArgumentException(nameof(rsaKey));

            SignedXml signedXml = new SignedXml(xmlDoc);

            signedXml.SigningKey = rsaKey;

            Reference reference = new Reference();
            reference.Uri = "";

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            signedXml.AddReference(reference);

            signedXml.ComputeSignature();


            XmlElement xmlDigitalSignature = signedXml.GetXml();

            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));
        }

        public static bool VerifyXml(XmlDocument xmlDoc, RSA key)
        {

            if (xmlDoc == null)
                throw new ArgumentException("xmlDoc");
            if (key == null)
                throw new ArgumentException("key");


            SignedXml signedXml = new SignedXml(xmlDoc);


            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");


            if (nodeList.Count <= 0)
            {
                throw new CryptographicException("Verification failed: No Signature was found in the document.");
            }


            if (nodeList.Count >= 2)
            {
                throw new CryptographicException("Verification failed: More that one signature was found for the document.");
            }


            signedXml.LoadXml((XmlElement)nodeList[0]);


            return signedXml.CheckSignature(key);
        }
    }
}
