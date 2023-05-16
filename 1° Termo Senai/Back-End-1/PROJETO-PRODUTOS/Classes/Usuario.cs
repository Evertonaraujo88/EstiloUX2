using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO_PRODUTOS.Classes
{
    public class Usuario
    {
        public int Codigo{get; private set; }
        public string Nome{ get; private set; }
        public string Email{get; private set; }
        public string Senha{ get; private set;}
        public DateTime DataCadastro{ get; private set; }

    }
}