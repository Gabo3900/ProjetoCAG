using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    class NAluno
    {
        private List<Aluno> alunos;
        private PAluno p;
        public List<Aluno> Listar()
        {
            return p.Abrir();
        }
        public List<Aluno> Listar(string s)
        {
            alunos = p.Abrir();
            return alunos.Where(x => x.Nome.StartsWith(s)).ToList();
        }
        public void Inserir(Aluno c)
        {
            alunos = p.Abrir();
            int id = 1;
            if (alunos.Count > 0) id = alunos.Max(x => x.Id) + 1;
            c.Id = id;
            alunos.Add(c);
            p.Salvar(alunos);
        }
        public void Atualizar(Aluno c)
        {
            alunos = p.Abrir();
            Aluno r = alunos.Where(x => x.Id == c.Id).Single();
            alunos.Remove(r);
            alunos.Add(c);
            p.Salvar(alunos);
        }
        public void Excluir(Aluno c)
        {
            alunos = p.Abrir();
            Aluno r = alunos.Where(x => x.Id == c.Id).Single();
            alunos.Remove(r);
            p.Salvar(alunos);
        }
    }
}
