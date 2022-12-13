using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AISCarwash
{
    class HashPassword
    {
        public string Text;
        public HashPassword(string passwd)
        {
            Text = getHash(passwd);
        }

        string getHash(string str)
        {
            var sha2 = SHA256.Create();
            var hbyte = sha2.ComputeHash(Encoding.UTF8.GetBytes(str));

            return BitConverter.ToString(hbyte).Replace("-", "").ToLower();
        }
    }
}
