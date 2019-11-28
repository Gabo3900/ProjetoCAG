using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PTurma
    {
        private string arquivo = "turmas.xml";
        public List<Turma> Abrir()
        {
            List<Turma> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Turma>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Turma>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Turma>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Salvar(List<Turma> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Turma>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
