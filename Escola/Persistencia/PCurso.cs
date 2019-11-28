using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PCurso
    {
        private string arquivo = "cursos.xml";
        public List<Curso> Abrir()
        {
            List<Curso> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Curso>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Curso>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Curso>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Salvar(List<Curso> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Curso>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
