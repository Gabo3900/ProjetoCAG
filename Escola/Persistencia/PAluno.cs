using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Persistencia
{
    public class PAluno
    {
        private string arquivo = "alunos.xml";
        public List<Aluno> Abrir()
        {
            List<Aluno> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<Aluno>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<Aluno>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<Aluno>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Salvar(List<Aluno> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Aluno>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
