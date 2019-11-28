using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    class NDisciplina
    {
        public List<Contato> Select()
        {
            PContato p = new PContato();
            return p.Open();
        }
        public List<Contato> Select(string s)
        {
            PContato p = new PContato();
            List<Contato> cs = p.Open();
            return cs.Where(x => x.Nome.StartsWith(s)).ToList();
        }
        public void Insert(Contato c)
        {
            PContato p = new PContato();
            List<Contato> cs = p.Open();
            int id = 1;
            if (cs.Count > 0) id = cs.Max(x => x.Id) + 1;
            c.Id = id;
            cs.Add(c);
            p.Save(cs);
        }
        public void Update(Contato c)
        {
            PContato p = new PContato();
            List<Contato> cs = p.Open();
            Contato r = cs.Where(x => x.Id == c.Id).Single();
            cs.Remove(r);
            cs.Add(c);
            p.Save(cs);
        }
        public void Delete(Contato c)
        {
            PContato p = new PContato();
            List<Contato> cs = p.Open();
            Contato r = cs.Where(x => x.Id == c.Id).Single();
            cs.Remove(r);
            p.Save(cs);
        }
    }
}
