using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCadastro
{
    public class Usuario : Pessoa
    {
        public int Codigo { get; set; }
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
    }
}
