using System.IO;
using System.Text;
using System.Security.Cryptography;
using System;

namespace Classes
{
    /// <summary>
    /// Encryptor by
    /// 
    /// _<code>Alain Eus. Rivera Rios</code>_
    /// .......-._.-::: QCX51 :::-._.-.......
    /// </summary>
    internal static class Encryptor
    {
        private static string Base64Encode(string InputString)
        {
            byte[] Bytes;
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.Unicode))
            { streamWriter.Write(InputString); streamWriter.Close(); Bytes = memoryStream.ToArray(); }
            return Convert.ToBase64String(Bytes, Base64FormattingOptions.InsertLineBreaks);
        }
        private static string Base64Decode(string Base64String)
        {
            byte[] Bytes = Convert.FromBase64String(Base64String);
            using (MemoryStream memoryStream = new MemoryStream(Bytes))
            using (StreamReader streamReader = new StreamReader(memoryStream, Encoding.Unicode))
            { Base64String = streamReader.ReadToEnd(); }
            return Base64String;
        }
        private static byte[] HexStringToByteArray(string Hex)
        {
            if (Hex.Contains("-")) { Hex = Hex.Replace("-", ""); }
            byte[] Bytes = new byte[Hex.Length % 2 == 0 ? Hex.Length / 2 : 0];
            for (int Index = 0; Hex.Length % 2 == 0 && Index < Hex.Length; Index += 2)
            { Bytes[Index / 2] = Convert.ToByte(Hex.Substring(Index, 2), 16); }
            return Bytes;
        }
        private static byte[] StringToByteArray(string Input)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.Unicode))
            {
                streamWriter.Write(Input);
                return memoryStream.ToArray();
            }
        }
        public static string EncodeChars(string StringToEncode)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < StringToEncode.Length; i++)
            { sb.Append(Base64Encode(Convert.ToString(StringToEncode[i]))).Append("|").Replace('=', '$'); }
            return sb.ToString();
        }
        public static string DecodeChars(string StringToDecode)
        {
            StringBuilder sb = new StringBuilder();
            string[] Chars = StringToDecode.ToString().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in Chars) { sb.Append(Base64Decode(str.Replace('$', '='))); }
            return sb.ToString();
        }
        public static string EncryptText(string TextToEncrypt, string Password)
        {
            byte[] Input = Encrypt(TextToEncrypt, Password);
            StringBuilder Output = new StringBuilder();
            for (int i = 0; i < Input.Length; i++)
            { Output.Append(Base64Encode(Convert.ToString(Input[i], 2)) + "|"); }
            return Output.ToString().Replace('=', '$');
        }
        public static string DecryptText(string TextToDecrypt, string Password)
        {
            string[] Input = TextToDecrypt.Replace('$', '=').Split('|');
            byte[] Bytes = new byte[Input.Length - 1];
            for (int i = 0; i < Bytes.Length; i++)
            { Bytes.SetValue(Convert.ToByte(Base64Decode(Input[i]), 2), i); }
            try { return Decrypt(Bytes, Password); }
            catch { return string.Empty; }
        }
        private static RijndaelManaged CryptoTransform(string Password)
        {
            RijndaelManaged RijndaelMgd = new RijndaelManaged()
            { Mode = CipherMode.CBC, Padding = PaddingMode.ISO10126, KeySize = 256, BlockSize = 256 };
            byte[] SaltKey = Encoding.Unicode.GetBytes(Keygen.ComputeSHA256(Password));
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, SaltKey))
            { RijndaelMgd.Key = rfc2898DeriveBytes.GetBytes(32); RijndaelMgd.IV = rfc2898DeriveBytes.GetBytes(32); }
            return RijndaelMgd;
        }
        public static byte[] Encrypt(string TextToEncrypt, string Password)
        {
            byte[] EncryptedText;
            using (ICryptoTransform ICrypto = CryptoTransform(Password).CreateEncryptor())
            using (MemoryStream memoryStream = new MemoryStream())
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, ICrypto, CryptoStreamMode.Write))
            using (StreamWriter SW = new StreamWriter(cryptoStream, Encoding.Unicode))
            { SW.Write(TextToEncrypt); SW.Close(); EncryptedText = memoryStream.ToArray(); }
            return EncryptedText;
        }
        public static string Decrypt(byte[] TextToDecrypt, string Password)
        {
            string DecryptedText;
            using (ICryptoTransform ICrypto = CryptoTransform(Password).CreateDecryptor())
            using (MemoryStream memoryStream = new MemoryStream(TextToDecrypt))
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, ICrypto, CryptoStreamMode.Read))
            using (StreamReader SR = new StreamReader(cryptoStream, Encoding.Unicode))
            { DecryptedText = SR.ReadToEnd(); SR.Dispose(); ICrypto.Dispose(); }
            return DecryptedText;
        }

        private static System.Xml.Serialization.XmlSerializer XS = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
        public static void RSAKeygen(out string PrivateKey, out string PublicKey)
        {
            using (MemoryStream MStream = new MemoryStream())
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.KeySize = rsa.LegalKeySizes[0].MaxSize;
                XS.Serialize(MStream, rsa.ExportParameters(false));
                PublicKey = Convert.ToBase64String(MStream.ToArray());
                MStream.Position = 0; MStream.Flush();
                XS.Serialize(MStream, rsa.ExportParameters(true));
                PrivateKey = Convert.ToBase64String(MStream.ToArray());
            }
        }
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, string PubKey)
        {
            using (MemoryStream MStream = new MemoryStream(Convert.FromBase64String(PubKey)))
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.KeySize = rsa.LegalKeySizes[0].MaxSize;
                RSAParameters PublicKey = (RSAParameters)XS.Deserialize(MStream);
                rsa.ImportParameters(PublicKey);
                return rsa.Encrypt(DataToEncrypt, RSAEncryptionPadding.Pkcs1);
            }
        }
        public static byte[] RSADecrypt(byte[] DataToDecrypt, string PrivKey)
        {
            using (MemoryStream MStream = new MemoryStream(Convert.FromBase64String(PrivKey)))
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.KeySize = rsa.LegalKeySizes[0].MaxSize;
                RSAParameters PrivateKey = (RSAParameters)XS.Deserialize(MStream);
                rsa.ImportParameters(PrivateKey);
                return rsa.Decrypt(DataToDecrypt, RSAEncryptionPadding.Pkcs1);
            }
        }
        public static string RSAEncrypt(string DataToEncrypt, string PubKey)
        {
            using (MemoryStream MStream = new MemoryStream(Convert.FromBase64String(PubKey)))
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.KeySize = rsa.LegalKeySizes[0].MaxSize;
                RSAParameters PublicKey = (RSAParameters)XS.Deserialize(MStream);
                rsa.ImportParameters(PublicKey);
                return Convert.ToBase64String(rsa.Encrypt(Encoding.Unicode.GetBytes(DataToEncrypt), true));
            }
        }
        public static string RSADecrypt(string DataToDecrypt, string PrivKey)
        {
            using (MemoryStream MStream = new MemoryStream(Convert.FromBase64String(PrivKey)))
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.KeySize = rsa.LegalKeySizes[0].MaxSize;
                RSAParameters PrivateKey = (RSAParameters)XS.Deserialize(MStream);
                rsa.ImportParameters(PrivateKey);
                return Encoding.Unicode.GetString(rsa.Decrypt(Convert.FromBase64String(DataToDecrypt), true));
            }
        }
    }
}
