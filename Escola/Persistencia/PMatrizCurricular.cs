using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Persistencia
{
    class PMatrizCurricular
    {
        private string arquivo = "matrizCurriculares.xml";
        public List<MatrizCurricular> Abrir()
        {
            List<MatrizCurricular> cs;
            XmlSerializer x = new XmlSerializer(typeof(List<MatrizCurricular>));
            StreamReader f = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = (List<MatrizCurricular>)x.Deserialize(f);
            }
            catch
            {
                cs = new List<MatrizCurricular>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Salvar(List<MatrizCurricular> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MatrizCurricular>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
