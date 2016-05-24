using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MercadoEnvio.Utils
{
    class EncriptadorSHA
    {
        public static string encodear(string input)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(input), 0, Encoding.UTF8.GetByteCount(input));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }

            return hash;
        }
    }
}