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
        public void Inserir(Aluno a)
        {
            alunos = p.Abrir();
            int id = 1;
            if (alunos.Count > 0) id = alunos.Max(x => x.Id) + 1;
            a.Id = id;
            alunos.Add(a);
            p.Salvar(alunos);
        }
        public void Atualizar(Aluno a)
        {
            alunos = p.Abrir();
            Aluno r = alunos.Where(x => x.Id == a.Id).Single();
            alunos.Remove(r);
            alunos.Add(a);
            p.Salvar(alunos);
        }
        public void Excluir(Aluno a)
        {
            alunos = p.Abrir();
            Aluno r = alunos.Where(x => x.Id == a.Id).Single();
            alunos.Remove(r);
            p.Salvar(alunos);
        }
        public List<Aluno> ColegasDeClasse(Aluno a)
        {
            alunos = p.Abrir();
            return alunos.Where(x => x.TurmaId == a.TurmaId).ToList();
        }
        public List<Aluno> Displinas(Aluno a)
        {
            alunos = p.Abrir();
            Curso c = alunos.Where(x )
            return alunos
        }
    }
}
