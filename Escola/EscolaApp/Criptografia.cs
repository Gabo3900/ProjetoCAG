using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class Criptografia
    {
        public static string Criptografar(string valor)
        {
            string chaveCripto;
            Byte[] cript = ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;
        }

        public static string Descriptografar(string valor)
        {
            string chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;
        }
    }
}
