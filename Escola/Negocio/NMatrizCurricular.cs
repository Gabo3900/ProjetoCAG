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
        private List<MatrizCurricular> matriz;
        private PMatrizCurricular p = new PMatrizCurricular();
        public List<MatrizCurricular> Listar()
        {
            return p.Abrir();
        }
        public void Inserir(MatrizCurricular d)
        {
            matriz = p.Abrir();
            int id = 1;
            if (matriz.Count > 0) id = matriz.Max(x => x.Id) + 1;
            d.Id = id;
            matriz.Add(d);
            p.Salvar(matriz);
        }
        public void Atualizar(MatrizCurricular d)
        {
            matriz = p.Abrir();
            MatrizCurricular r = matriz.Where(x => x.Id == d.Id).Single();
            matriz.Remove(r);
            matriz.Add(d);
            p.Salvar(matriz);
        }
        public void Excluir(MatrizCurricular d)
        {
            matriz = p.Abrir();
            MatrizCurricular r = matriz.Where(x => x.Id == d.Id).Single();
            matriz.Remove(r);
            p.Salvar(matriz);
        }
    }
}
