using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using XML.Entites;

namespace XML
{
    public class XMLManager
    {
        #region пароль
        private const int SaltLength = 16;         // Длина соли
        private const int KeyLength = 16;          // Длина ключа
        private string password = "Qg76R_Tu";       // Пароль
        #endregion

        private byte[] GetSalt()
        {
            var salt = new byte[SaltLength];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        private byte[] GetKey(byte[] salt)
        {
            var keygenerator = new Rfc2898DeriveBytes(password, salt);
            return keygenerator.GetBytes(KeyLength);
        }

        private byte[] ConvertData<T>(T xml)
        {
            byte[] data;
            var formatter = new XmlSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                formatter.Serialize(ms, xml);
                data = ms.ToArray();
            }
            return data;
        }

        //возвращает алгоритм шифрования
        private Aes GetAes(byte[] key)
        {
            var aes = Aes.Create();
            aes.GenerateIV();
            aes.Key = key;
            return aes;
        }

        public void Serialize<T>(T xml, string path, string fileName)
        {
            string file;
            if (xml.GetType() == typeof(TestEntites))
            {
                var k = Directory.GetFiles(Environment.CurrentDirectory + path).Length + 1;
                file = string.Format("{0}{1}.{2}.xml", path, k, fileName);
            }
            else if (xml.GetType() == typeof(UsersAnswersEntities))
            {
                file = string.Format("{0}{1}.xml", path, fileName);
            }
            else
            {
                throw new Exception("Недопустимый тип");
            }
            byte[] salt = GetSalt();
            var aes = GetAes(GetKey(salt));
            var iv = aes.IV;
            var encryptor = aes.CreateEncryptor();
            var data = ConvertData(xml);
            using (var fs = new FileStream(file, FileMode.Create))
            {
                fs.Write(salt, 0, salt.Length);
                fs.Write(iv, 0, iv.Length);
                using (var cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
            }
        }

        public T DeSerialize<T>(string path)
        {
            T xml;
            var file = path;
            using (var f = new FileStream(file, FileMode.Open))
            {
                byte[] salt = new byte[SaltLength];
                byte[] iv = new byte[KeyLength];
                f.Read(salt, 0, salt.Length);
                f.Read(iv, 0, iv.Length);
                var key = GetKey(salt);
                var aes = GetAes(key);
                aes.IV = iv;
                var decryptor = aes.CreateDecryptor();
                var formatter = new XmlSerializer(typeof(T));
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(f, decryptor, CryptoStreamMode.Read))
                    {
                        while (true)
                        {
                            var b = cs.ReadByte();
                            if (b == -1) break;
                            ms.WriteByte((byte) b);
                        }
                        ms.Seek(0, SeekOrigin.Begin);
                        xml = (T) formatter.Deserialize(ms);
                    }
                }
            }
            return xml;
        }

    }
}
