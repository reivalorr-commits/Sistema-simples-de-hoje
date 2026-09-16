using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCadastro
{
    internal class Aluno : Pessoa
    {
        public int Rm { get; set; }
        public string Turma { get; set; } = string.Empty;

        public List<Disciplina> ListaDisciplinas { get; set;} 
    }
}
