using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Persistencia
{
    public class PDisciplina
    {
        private string arquivo = "disciplinas.xml";
        public List<Disciplina> Abrir()
        {
            List<Disciplina> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Disciplina>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Disciplina>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Disciplina>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Salvar(List<Disciplina> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Disciplina>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
