using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class NCurso
    {
        private List<Curso> cursos;
        private PCurso p = new PCurso();
        public List<Curso> Select()
        {
            PCurso p = new PCurso();
            return p.Abrir();
        }
        public List<Curso> Select(string s)
        {
            cursos = p.Abrir();
            return cursos.Where(x => x.Nome.StartsWith(s)).ToList();
        }
        public void Insert(Curso c)
        {
            cursos = p.Abrir();
            int id = 1;
            if (cursos.Count > 0) id = cursos.Max(x => x.Id) + 1;
            c.Id = id;
            cursos.Add(c);
            p.Salvar(cursos);
        }
        public void Update(Curso c)
        {
            cursos = p.Abrir();
            Curso r = cursos.Where(x => x.Id == c.Id).Single();
            cursos.Remove(r);
            cursos.Add(c);
            p.Salvar(cursos);
        }
        public void Delete(Curso c)
        {
            cursos = p.Abrir();
            Curso r = cursos.Where(x => x.Id == c.Id).Single();
            cursos.Remove(r);
            p.Salvar(cursos);
        }
    }
}
