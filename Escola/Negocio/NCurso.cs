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
        public List<Curso> Listar()
        {
            return p.Abrir();
        }
        public List<Curso> Listar(string s)
        {
            cursos = p.Abrir();
            return cursos.Where(x => x.Nome.StartsWith(s)).ToList();
        }
        public void Inserir(Curso c)
        {
            cursos = p.Abrir();
            int id = 1;
            if (cursos.Count > 0) id = cursos.Max(x => x.Id) + 1;
            c.Id = id;
            cursos.Add(c);
            p.Salvar(cursos);
        }
        public void Atualizar(Curso c)
        {
            cursos = p.Abrir();
            Curso r = cursos.Where(x => x.Id == c.Id).Single();
            cursos.Remove(r);
            cursos.Add(c);
            p.Salvar(cursos);
        }
        public void Excluir(Curso c)
        {
            cursos = p.Abrir();
            Curso r = cursos.Where(x => x.Id == c.Id).Single();
            cursos.Remove(r);
            p.Salvar(cursos);
        }
    }
}
