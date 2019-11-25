using System;

namespace Modelo
{
    public class Curso
    {
        private int id;
        private string nome;
        public int Id
        {
            get { return id; }
        }
        public string Nome
        {
            get { return nome; }
        }

        public Curso(string n, int i)
        {
            nome = n;
            id = i;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
