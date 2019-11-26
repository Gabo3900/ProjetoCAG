using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Administrador
    {
        private string nome;
        private string senha;
        private string email;
        public Administrador(string n, string s, string e)
        {
            nome = n;
            senha = s;
            email = e;
        }
    }
}
