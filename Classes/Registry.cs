using Microsoft.Win32;
using System;

namespace Classes
{
    internal class Registry
    {
        private const string DEFAULT_REG_KEY = "Software\\CyberCtrl\\Server";
        private static string SubKey = string.Empty;
        private static RegistryKey AppKey;
        private static RegistryKey RegKey
        {
            get { return Forms.Server.IsAdminRole ? Microsoft.Win32.Registry.LocalMachine : Microsoft.Win32.Registry.CurrentUser; }
        }

        internal static void SaveIPEndPoint(int PtNo)
        {
            SubKey = DEFAULT_REG_KEY + "\\EndPoint";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppKey.SetValue("PtNo", PtNo, RegistryValueKind.String);
            AppKey.Close();
        }
        private static void SaveKeyData(string Username, string Password, string UserGUID)
        {
            SubKey = DEFAULT_REG_KEY + "\\KeyData";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppKey.SetValue("Username", Username, RegistryValueKind.String);
            AppKey.SetValue("Password", Password, RegistryValueKind.String);
            AppKey.SetValue("UserGUID", UserGUID, RegistryValueKind.String);
            AppKey.Close();
        }
        internal static void SavePricing(decimal Price, decimal Minimum, decimal Start, decimal Extra = 0.00M)
        {
            SubKey = DEFAULT_REG_KEY + "\\Pricing";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppKey.SetValue("Price", Price, RegistryValueKind.String);
            AppKey.SetValue("Minimum", Minimum, RegistryValueKind.String);
            AppKey.SetValue("Start", Start, RegistryValueKind.String);
            AppKey.SetValue("Extra", Extra, RegistryValueKind.String);
            AppKey.Close(); ReadRegData();
        }
        public static string GetAppID()
        {
            AppKey = RegKey.CreateSubKey(DEFAULT_REG_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppData.AppGUID = Convert.ToString(AppKey.GetValue("AppID", AppData.AppGUID));
            AppKey.SetValue("AppID", AppData.AppGUID, RegistryValueKind.String);
            AppKey.Close(); AppKey = null;
            return AppData.AppGUID;
        }
        internal static void ReadRegData()
        {
            SubKey = DEFAULT_REG_KEY + "\\KeyData";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppData.Security.UserName = Convert.ToString(AppKey.GetValue("Username", AppData.Security.UserName));
            AppData.Security.Password = Convert.ToString(AppKey.GetValue("Password", AppData.Security.Password));
            AppData.Security.UserGUID = Convert.ToString(AppKey.GetValue("UserGUID", AppData.Security.UserGUID));
            AppKey.Close();
            SubKey = DEFAULT_REG_KEY + "\\Pricing";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppData.Pricing.Price = Convert.ToDecimal(AppKey.GetValue("Price", AppData.Pricing.Price));
            AppData.Pricing.Minimum = Convert.ToDecimal(AppKey.GetValue("Minimum", AppData.Pricing.Minimum));
            AppData.Pricing.Start = Convert.ToDecimal(AppKey.GetValue("Start", AppData.Pricing.Start));
            AppData.Pricing.Extra = Convert.ToDecimal(AppKey.GetValue("Extra", AppData.Pricing.Extra));
            AppKey.Close();
            SubKey = DEFAULT_REG_KEY + "\\EndPoint";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppData.IPEndPoint.PtNo = Convert.ToInt32(AppKey.GetValue("PtNo", AppData.IPEndPoint.PtNo));
            AppKey.Close();
            SubKey = DEFAULT_REG_KEY + "\\Company";
            AppKey = RegKey.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
            AppData.Company.CompanyName = Convert.ToString(AppKey.GetValue("Name", AppData.Company.CompanyName));
            AppData.Company.MessageTitle = Convert.ToString(AppKey.GetValue("Title", AppData.Company.MessageTitle));
            AppData.Company.StatusMessage = Convert.ToString(AppKey.GetValue("Message", AppData.Company.StatusMessage));
            AppData.Company.DenyUnlock = Convert.ToBoolean(AppKey.GetValue("DenyUnlock", AppData.Company.DenyUnlock));
            AppKey.Close();
        }
        internal static void SetKeyData(string UserName, string Password)
        {
            string userguid = Guid.NewGuid().ToString();
            AppData.Security.UserName = Encryptor.EncryptText(UserName, Keygen.ComputeSHA512(userguid + Password));
            AppData.Security.Password = Encryptor.EncryptText(Password, Keygen.ComputeSHA512(userguid + UserName));
            AppData.Security.UserGUID = Encryptor.EncryptText(userguid, Keygen.ComputeSHA512(UserName + Password));
            SaveKeyData(AppData.Security.UserName, AppData.Security.Password, AppData.Security.UserGUID);
        }
        internal static System.Collections.Generic.IEnumerable<string> GetKeyData(string UserName, string Password)
        {
            string userguid, username, password = string.Empty;
            userguid = Encryptor.DecryptText(AppData.Security.UserGUID, Keygen.ComputeSHA512(UserName + Password));
            yield return userguid;
            username = Encryptor.DecryptText(AppData.Security.UserName, Keygen.ComputeSHA512(userguid + Password));
            yield return username;
            password = Encryptor.DecryptText(AppData.Security.Password, Keygen.ComputeSHA512(userguid + UserName));
            yield return password;
        }
    }
}
