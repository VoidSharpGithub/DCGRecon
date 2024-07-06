using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DCGRecon.Classes
{
    public static class Helper
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("0TFY5nvt5Xjw7TyU"); // Must be 16 bytes for AES-128
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("mUY7vaTiJ6fnNWqU"); // Must be 16 bytes

        public static string EncryptString(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string DecryptString(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
        public static string DateToEpoch(DateTime date)
        {
            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (date - epochStart).TotalSeconds.ToString();
        }
        public static DateTime EpochToDate(string epochString)
        {
            if (long.TryParse(epochString, out long epoch))
            {
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(epoch);
                return dateTimeOffset.DateTime;
            }
            else
            {
                return DateTime.Today.AddDays(3);
            }
        }
        public static int GetIpAddressValue(string address, ref IPAddress ipvalue)
        {
            int index1 = 0;
            int[] numArray = new int[3];
            for (int index2 = 0; index2 < address.Length; ++index2)
            {
                if (address[index2] == '.')
                {
                    if (index1 == 3)
                        return -1;
                    numArray[index1] = index2;
                    ++index1;
                }
            }
            if (index1 != 3)
                return -1;
            string[] strArray = new string[4]
            {
                address.Substring(0, numArray[0]).Trim(),
                address.Substring(numArray[0] + 1, numArray[1] - numArray[0] - 1).Trim(),
                address.Substring(numArray[1] + 1, numArray[2] - numArray[1] - 1).Trim(),
                address.Substring(numArray[2] + 1, address.Length - numArray[2] - 1).Trim()
            };
            byte[] address1 = new byte[4];
            for (int index3 = 0; index3 < 4; ++index3)
            {
                if (strArray[index3].Length == 0)
                    return -2;
                for (int index4 = 0; index4 < strArray[index3].Length; ++index4)
                {
                    if (strArray[index3][index4] < '0' || strArray[index3][index4] > '9')
                        return -3;
                }
                int num = int.Parse(strArray[index3]);
                if (num < 0 || num > (int)byte.MaxValue)
                    return -4;
                address1[index3] = (byte)num;
            }
            ipvalue = new IPAddress(address1);
            return 0;
        }
    }
}
