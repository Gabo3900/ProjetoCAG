using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Turma
    {
        private int id, cursoId;
        public int Id
        {
            get { return id; }
        }
        public int CursoId
        {
            get { return cursoId; }
        }
        public Turma(int i, int c)
        {
            id = i;
            cursoId = c;
        }
    }
}
