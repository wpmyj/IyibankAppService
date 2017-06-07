using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace IyibankAppService.Utils.Encryption
{
    public static class MD5Utils
    {
        public static string GetMD5(string str)
        {
            MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                ret.Append(data[i].ToString("x2"));
            }
            return ret.ToString().ToUpper();
        }
    }
}
