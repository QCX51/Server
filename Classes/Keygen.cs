using System;
using System.Text;
using System.Security.Cryptography;

namespace Classes
{
    internal static class Keygen
    {
        internal static string ComputeSHA512(string Input)
        {
            using (SHA512CryptoServiceProvider CryptoSrv = new SHA512CryptoServiceProvider())
            { return BuildString(CryptoSrv.ComputeHash(Encoding.Unicode.GetBytes(Input))); }
        }

        internal static string ComputeSHA384(string Input)
        {
            using (SHA384CryptoServiceProvider CryptoSrv = new SHA384CryptoServiceProvider())
            { return BuildString(CryptoSrv.ComputeHash(Encoding.Unicode.GetBytes(Input))); }
        }

        internal static string ComputeSHA256(string Input)
        {
            using (SHA256CryptoServiceProvider CryptoSrv = new SHA256CryptoServiceProvider())
            { return BuildString(CryptoSrv.ComputeHash(Encoding.Unicode.GetBytes(Input))); }
        }

        internal static string ComputeSHA1(string Input)
        {
            using (SHA1CryptoServiceProvider CryptoSrv = new SHA1CryptoServiceProvider())
            { return BuildString(CryptoSrv.ComputeHash(Encoding.Unicode.GetBytes(Input))); }
        }

        internal static string ComputeMD5(string Input)
        {
            using (MD5CryptoServiceProvider CryptoSrv = new MD5CryptoServiceProvider())
            { return BuildString(CryptoSrv.ComputeHash(Encoding.Unicode.GetBytes(Input))); }
        }

        private static string BuildString(byte[] Input)
        { return BitConverter.ToString(Input).Replace("-", ""); }
    }
}
