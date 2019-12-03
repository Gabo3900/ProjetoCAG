using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class NTurma
    {
        private List<Turma> turmas;
        private PTurma p = new PTurma();
        public List<Turma> Listar()
        {
            return p.Abrir();
        }
        public void Inserir(Turma t)
        {
            turmas = p.Abrir();
            int id = 1;
            if (turmas.Count > 0) id = turmas.Max(x => x.Id) + 1;
            t.Id = id;
            turmas.Add(t);
            p.Salvar(turmas);
        }
        public void Atualizar(Turma t)
        {
            turmas = p.Abrir();
            Turma r = turmas.Where(x => x.Id == t.Id).Single();
            turmas.Remove(r);
            turmas.Add(t);
            p.Salvar(turmas);
        }
        public void Excluir(Turma t)
        {
            turmas = p.Abrir();
            Turma r = turmas.Where(x => x.Id == t.Id).Single();
            turmas.Remove(r);
            p.Salvar(turmas);
        }
    }
}
