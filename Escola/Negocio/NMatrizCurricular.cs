using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class NMatrizCurricular
    {
        private List<MatrizCurricular> discs;
        private PMatrizCurricular p = new PMatrizCurricular();
        public List<MatrizCurricular> Listar()
        {
            return p.Abrir();
        }
        public void Inserir(MatrizCurricular d)
        {
            discs = p.Abrir();
            int id = 1;
            if (discs.Count > 0) id = discs.Max(x => x.Id) + 1;
            d.Id = id;
            discs.Add(d);
            p.Salvar(discs);
        }
        public void Atualizar(MatrizCurricular d)
        {
            discs = p.Abrir();
            MatrizCurricular r = discs.Where(x => x.Id == d.Id).Single();
            discs.Remove(r);
            discs.Add(d);
            p.Salvar(discs);
        }
        public void Excluir(MatrizCurricular d)
        {
            discs = p.Abrir();
            MatrizCurricular r = discs.Where(x => x.Id == d.Id).Single();
            discs.Remove(r);
            p.Salvar(discs);
        }
    }
}
