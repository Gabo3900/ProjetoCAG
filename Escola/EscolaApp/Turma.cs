using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class Turma
    {
        private int id, cursoId;
        public int Id {
            get { return id; }
        }
        public int CursoId {
            get { return cursoId; }
        }
        public Turma (int i, int c)
        {
            id = i;
            cursoId = c;
        }
    }
}
