using Modelo;
using Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class NDisciplina
    {
        private List<Disciplina> discs;
        private PDisciplina p;
        public List<Disciplina> Listar()
        {
            return p.Abrir();
        }
        public List<Disciplina> Listar(string s)
        {
            discs = p.Abrir();
            return discs.Where(x => x.Nome.StartsWith(s)).ToList();
        }
        public void Inserir(Disciplina d)
        {
            discs = p.Abrir();
            int id = 1;
            if (discs.Count > 0) id = discs.Max(x => x.Id) + 1;
            d.Id = id;
            discs.Add(d);
            p.Salvar(discs);
        }
        public void Atualizar(Disciplina d)
        {
            discs = p.Abrir();
            Disciplina r = discs.Where(x => x.Id == d.Id).Single();
            discs.Remove(r);
            discs.Add(d);
            p.Salvar(discs);
        }
        public void Excluir(Disciplina d)
        {
            discs = p.Abrir();
            Disciplina r = discs.Where(x => x.Id == d.Id).Single();
            discs.Remove(r);
            p.Salvar(discs);
        }
    }
}
