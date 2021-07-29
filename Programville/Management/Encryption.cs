using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programville
{
    static class Encryption
    {
        public static string Encrypt(string input)
        {
            string msg = "";
            byte[] encode = new byte[input.Length];
            encode = Encoding.UTF8.GetBytes(input);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

    }
}
