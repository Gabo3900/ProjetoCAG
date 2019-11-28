using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string TurmaId { get; set; }
    }
}
